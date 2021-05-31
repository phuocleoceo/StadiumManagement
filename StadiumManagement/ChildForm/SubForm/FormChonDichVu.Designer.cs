
namespace GUILayer.ChildForm.SubForm
{
    partial class FormChonDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lvDV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imgList.ImageSize = new System.Drawing.Size(120, 120);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvDV
            // 
            this.lvDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDV.HideSelection = false;
            this.lvDV.LargeImageList = this.imgList;
            this.lvDV.Location = new System.Drawing.Point(0, 0);
            this.lvDV.Name = "lvDV";
            this.lvDV.Size = new System.Drawing.Size(677, 393);
            this.lvDV.TabIndex = 0;
            this.lvDV.UseCompatibleStateImageBehavior = false;
            this.lvDV.Click += new System.EventHandler(this.lvDV_Click);
            // 
            // FormChonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 393);
            this.Controls.Add(this.lvDV);
            this.Name = "FormChonDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn dịch vụ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lvDV;
    }
}