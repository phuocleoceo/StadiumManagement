
namespace GUILayer.ChildForm.SubForm
{
    partial class FormChonSan
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
            this.lvSan = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvSan
            // 
            this.lvSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSan.HideSelection = false;
            this.lvSan.LargeImageList = this.imgList;
            this.lvSan.Location = new System.Drawing.Point(0, 0);
            this.lvSan.Name = "lvSan";
            this.lvSan.Size = new System.Drawing.Size(664, 393);
            this.lvSan.TabIndex = 1;
            this.lvSan.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imgList.ImageSize = new System.Drawing.Size(120, 120);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormChonSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 393);
            this.Controls.Add(this.lvSan);
            this.Name = "FormChonSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChonSan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSan;
        private System.Windows.Forms.ImageList imgList;
    }
}