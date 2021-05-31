﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormAlert : Form
    {
        public FormAlert(string msg, AlertType type)
        {
            InitializeComponent();
            ShowAlert(msg, type);
        }
        public enum AlertType
        {
            Success, Warning, Error, Infor
        }

        public enum Action
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
                    timerAlert.Interval = 5000;
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

        public void ShowAlert(string msg, AlertType type)
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

            switch (type)
            {
                case AlertType.Success:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Procedures;
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.Warning:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    this.BackColor = Color.DarkOrange;
                    break;
                case AlertType.Error:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Redhat;
                    this.BackColor = Color.DarkRed;
                    break;
                case AlertType.Infor:
                    this.iconAlert.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
                    this.BackColor = Color.RoyalBlue;
                    break;
            }

            this.lblMsg.Text = msg;
            this.Show();
            this.action = Action.Start;
            this.timerAlert.Interval = 1;
            timerAlert.Start();
        }
    }
}