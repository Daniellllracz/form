using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmmain : Form
    {
        private object rnd;

        public Frmmain()
        {
            InitializeComponent();
            btnClickMe.Click += BtnClickMe_Click;
        }

        private void BtnClickMe_Click(object sender, EventArgs e)
        {
            if (lblTextField.Text.Contains("place holder"))
            {
                lblTextField.Text = $"hello world";
            }
            else
            {
                lblTextField.BackColor = Color.FromArgb(
                    red: rnd.Next(256)
                    green: rnd.Next(256)
                    blue: rnd.Next(256)
            }

        }


    }
}
