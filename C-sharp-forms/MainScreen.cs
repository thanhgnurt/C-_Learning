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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Instance_Hello_Everybody.Click += (Th, Ts) =>
             {
                 var Screen = new Hello_Everybody();
                 Screen.ShowDialog();
             };
            Instance_Variebal_String.Click += (Th, Ts) =>
              {
                  var Screen = new Variebal_String();
                  Screen.ShowDialog();
              };
        }

       
    }
}
