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
    public partial class Variebal_String : Form
    {
        public Variebal_String()
        {
            InitializeComponent();
            var DumpString = "";
            var Ho_Ten = "Lê Thành Trung";
            DumpString = Ho_Ten + "\n";
            Ho_Ten = Ho_Ten.Trim();
            DumpString = DumpString + Ho_Ten +"\n";
            var So_Ky_Tu = Ho_Ten.Length;
            DumpString = DumpString + So_Ky_Tu + "\n";

            var Ho_Ten_Chu_Hoa = Ho_Ten.ToUpper();
            DumpString = DumpString + Ho_Ten_Chu_Hoa + "\n";
            var Ho_Ten_Chu_Thuong = Ho_Ten.ToLower();
            DumpString = DumpString + Ho_Ten_Chu_Thuong + "\n";
            var Ky_Tu_Dau = Ho_Ten[0];
            DumpString = DumpString + Ky_Tu_Dau + "\n";
            var Ky_Tu_Cuoi = Ho_Ten[So_Ky_Tu - 1];
            DumpString = DumpString + Ky_Tu_Cuoi + "\n";
            var Loi_Chao = "Xin Chao" + Ho_Ten;
            DumpString = DumpString + Loi_Chao + "\n";

            var Thanh_Phan_Con = Ho_Ten.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            DumpString = DumpString + Thanh_Phan_Con + "\n";
            var Ho = Thanh_Phan_Con[0];
            DumpString = DumpString + Ho + "\n";
            var Ten = Thanh_Phan_Con[Thanh_Phan_Con.Length - 1];
            DumpString = DumpString + Ten + "\n";
            var Chu_Lot = Ho_Ten.Replace(Ho, "").Replace(Ten, "").Trim();
            DumpString = DumpString + Ho_Ten + "\n";
            Instance_Show_Variebal.Text = DumpString;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
