using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BusinessLayer
{
    public static class Utility
    {
        // Validate
        public static string Validate(this object obj)
        {
            StringBuilder sb = new StringBuilder();
            ValidationContext context = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(obj, context, errors, true))
            {
                foreach (ValidationResult vr in errors)
                {
                    sb.AppendLine(vr.ErrorMessage);
                }
            }
            return sb.ToString();
        }
        // Dinh dang DGV
        public static void FormatTable(this DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dgv.BorderStyle = BorderStyle.None;
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

        // Ma hoa mat khau
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

        // Xu ly anh
        public static Image ByteArrayToImage(this byte[] img)
        {
            if (img == null || img.Length == 0) return null;
            else
            {
                MemoryStream ms = new MemoryStream(img);
                return Image.FromStream(ms);
            }
        }

        public static byte[] ImageToByteArray(this Image img)
        {
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    return ms.ToArray();
                }
            }
            else return null;
        }

        public static DateTime TrimSeconds(this DateTime dt)
        {
            return dt.AddSeconds(-dt.Second);
        }
    }
}
