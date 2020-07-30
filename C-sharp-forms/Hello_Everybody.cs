using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_forms
{
    public partial class Hello_Everybody : Form
    {
        public Hello_Everybody()
        {
            InitializeComponent();
            Instance_Submit.Click += (Th, Ts) =>
             {
                 var name = Instant_Input.Text.Trim();
                 var hello = "Hello " + name + " !! Wellcome to my C#.";
                 if (name.Length > 0)
                 {
                     Instance_Show_Hello.Text = hello;
                 } else
                 {
                     Instance_Show_Hello.Text = "Please !! do not leave it blank.";
                 }
             };
        }

        private void Instance_Submit_Click(object sender, EventArgs e)
        {

        }

        private void Instance_Show_Hello_Click(object sender, EventArgs e)
        {

        }
    }
}
