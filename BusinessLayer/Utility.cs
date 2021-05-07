using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace BusinessLayer
{
    public static class Utility
    {
        public static void FormatTable(this DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.DefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static string GetMD5(this string str)
        {
            MD5 md5 = MD5.Create();
            byte[] fromData = Encoding.ASCII.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < targetData.Length; i++)
            {
                sb.Append(targetData[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static void LoadImage(this PictureBox pic, byte[] img)
        {
            if (img == null || img.Length == 0)
            {
                pic.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pic.Image = Image.FromStream(ms);
            }
        }

        public static byte[] ImagePathToByte(this string imgPath)
        {
            try
            {
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                return br.ReadBytes((int)fs.Length);
            }
            catch
            {
                return null;
            }
        }
    }
}
