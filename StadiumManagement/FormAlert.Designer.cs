
namespace GUILayer
{
    partial class FormAlert
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.iconAlert = new FontAwesome.Sharp.IconButton();
            this.iconClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(64, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(114, 20);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message_Text";
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // iconAlert
            // 
            this.iconAlert.FlatAppearance.BorderSize = 0;
            this.iconAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAlert.ForeColor = System.Drawing.Color.Transparent;
            this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconAlert.IconColor = System.Drawing.Color.Black;
            this.iconAlert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAlert.Location = new System.Drawing.Point(4, 19);
            this.iconAlert.Name = "iconAlert";
            this.iconAlert.Size = new System.Drawing.Size(46, 46);
            this.iconAlert.TabIndex = 2;
            this.iconAlert.UseVisualStyleBackColor = true;
            // 
            // iconClose
            // 
            this.iconClose.FlatAppearance.BorderSize = 0;
            this.iconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconClose.ForeColor = System.Drawing.Color.Transparent;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.Black;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(360, -1);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(54, 85);
            this.iconClose.TabIndex = 3;
            this.iconClose.UseVisualStyleBackColor = true;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // FormAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(415, 85);
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.iconAlert);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlert";
            this.Text = "Form_Alert";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer timerAlert;
        private FontAwesome.Sharp.IconButton iconAlert;
        private FontAwesome.Sharp.IconButton iconClose;
    }
}