using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(60, 20 + i * 40);
                btn.Size = new Size(30, 30);
                btn.Name = "btn_" + i.ToString();
                btn.Text = "=";
                btn.Click += new EventHandler(btn_tikla);
                this.Controls.Add(btn);

                TextBox txt = new TextBox();
                txt.Location = new Point(10, 25 + i * 40);
                txt.Size = new Size(50, 30);
                txt.Name = "txt_" + i.ToString();
                this.Controls.Add(txt);
            }
        }
        public string sayilaribul1(string s)
        {
            string[] sdizi = s.Split('_');     //split belirli bir karaktere kadar alır ondan sonrasına göre işlem yapar.
            return sdizi[1];                   // 3 fonksiyonda aynı işi yapar ama en hızlısı 1 numaralı olandır.
        }
        public string sayilaribul2(string s)
        {
            return s.Substring(4);
        }
        public string sayilaribul3(string s)
        {
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    int x = Convert.ToInt32(s[i].ToString());
                    temp += s[i];
                }
                catch (Exception)
                { }
            }
            return temp;
        }
        public void btn_tikla(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            string btn_no = sayilaribul1(btn.Name);
            for(int i=0;i<this.Controls.Count;i++)
            {
                try
                {
                    TextBox txt = (TextBox)this.Controls[i];
                    if (btn_no == sayilaribul1(txt.Name))
                        txt.Text = "TIKLANDI";
                    else
                       txt.Text = "";
                }
                catch (Exception)
                {

                    
                }
            }

        }
    }
}
