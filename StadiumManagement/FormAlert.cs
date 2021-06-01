using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUILayer
{
    public enum AlertType
    {
        Success, Warning, Error, Infor
    }

    public partial class FormAlert : Form
    {
        public FormAlert(string msg, AlertType type)
        {
            InitializeComponent();
            SubmitAlertDisplay(type);
            msg = ChangeDefaultMessage(msg);
            ShowAlert(msg);
        }

        private string ChangeDefaultMessage(string msg)
        {
            if (msg.Equals("Input string was not in a correct format."))
                msg = "Định dạng số không hợp lệ";
            return msg;
        }

        private enum Action
        {
            Wait, Start, Close
        }
        private Action action;

        private int x, y;

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.Wait:
                    timerAlert.Interval = 3500;  //Thoi gian tat
                    action = Action.Close;
                    break;
                case Action.Start:
                    timerAlert.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Action.Wait;
                        }
                    }
                    break;
                case Action.Close:
                    timerAlert.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Dispose();
                    }
                    break;
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            timerAlert.Interval = 1;
            action = Action.Close;
        }

        private void ShowAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            String fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormAlert f = (FormAlert)Application.OpenForms[fname];
                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;            

            this.lblMsg.Text = msg;
            this.Show();
            this.action = Action.Start;
            this.timerAlert.Interval = 1;
            timerAlert.Start();
        }

        private void SubmitAlertDisplay(AlertType type)
        {
            switch (type)
            {
                case AlertType.Success:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    this.BackColor = Color.SeaGreen;
                    this.iconAlert.ForeColor = Color.SeaGreen;
                    break;
                case AlertType.Warning:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    this.BackColor = Color.DarkOrange;
                    this.iconAlert.ForeColor = Color.DarkOrange;
                    break;
                case AlertType.Error:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    this.BackColor = Color.DarkRed;
                    this.iconAlert.ForeColor = Color.DarkRed;
                    break;
                case AlertType.Infor:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                    this.BackColor = Color.RoyalBlue;
                    this.iconAlert.ForeColor = Color.RoyalBlue;
                    break;
            }
        }
    }
}
