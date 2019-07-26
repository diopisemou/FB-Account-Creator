using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.Threading;

namespace FBAccountCreator
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/");
        }

        private void MetroSetButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int length = 12;
            var str = "";
            for (var i = 0; i < length; i++)
            {
                str += ((char)(rnd.Next(1, 26) + 64)).ToString();
            }

            var random = new Random();
            var list = new List<string> { "Kenneth", "James", "Micheal", "Freddie", "Joyce", "Kelly", "Marie", "Ted", "David", "Antonio", "Genevieve", "Janette", "Jennie", "Ron", "Jerald", "Kenneth", "Armando", "Robert", "Kelsey", "Joyce", "Alan", "Robin", "Samuel", "Patricia", "Jennie", "Grace", "Otis", "Antonio", "Jerald", "James", "Darrin", "Donald", "Frederick", "Emma", "Keith", "Kenneth" };
            int index = random.Next(list.Count);

            var list2 = new List<string> { "Mullins", "Smith", "Savage", "Reid", "bot", "Ramos", "Dibella", "White", "Karr", "Guidry", "Wheeler", "Land", "Day", "Clark", "Maynor", "Alderman", "Cox", "Shea", "Nichols", "Burt", "Portwood", "Sandova", "Wheeler", "Santos", "Durham", "Williams", "Acevedo", "Lloyd", "Malone", "Hayes", "Branch", "Silva", "Conrad", "Nicholson", "Mullins", "Hanson" };
            int index2 = random.Next(list2.Count);

            int birthday_day = rnd.Next(1, 28);
            int birthday_month = rnd.Next(1, 12);
            int birthday_year = rnd.Next(1970, 2001);

            webBrowser1.Document.GetElementById("firstname").SetAttribute("value", list[index]);

            webBrowser1.Document.GetElementById("lastname").SetAttribute("value", list2[index2]);

            webBrowser1.Document.GetElementById("reg_email__").SetAttribute("value", str + "@domain.extension"); //over here you need fix or just create textbox and input mail info there

            webBrowser1.Document.GetElementById("reg_email_confirmation__").SetAttribute("value", str + "@domain.extension");  //same as 2 lines above

            webBrowser1.Document.GetElementById("reg_passwd__").SetAttribute("value", str);

            webBrowser1.Document.GetElementById("birthday_day").SetAttribute("value", birthday_day.ToString());

            webBrowser1.Document.GetElementById("birthday_month").SetAttribute("value", birthday_month.ToString());

            webBrowser1.Document.GetElementById("birthday_year").SetAttribute("value", birthday_year.ToString());

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("sex")[0].InvokeMember("click"); //female

            webBrowser1.Document.GetElementsByTagName("input").GetElementsByName("sex")[1].InvokeMember("click"); //male

            webBrowser1.Document.GetElementById("websubmit").InvokeMember("Click");

        }

        private void MetroSetButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", "/C RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2");

            //not needed
        }

        private void MetroSetButton3_Click(object sender, EventArgs e)
        {
            //associated with email code will redirect site after entering it currently bound to other button for manual activation to make it automatic you need fix/implement stuff for receive code from email and then move this line back to the button 1 function

            webBrowser1.Document.GetElementById("confirm").InvokeMember("Click");
        }

    }
}
