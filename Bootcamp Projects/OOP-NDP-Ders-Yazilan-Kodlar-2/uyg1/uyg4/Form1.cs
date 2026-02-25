using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg4
{
    public partial class Form1 : Form
    {
        int satilan_koltuk;
        int koltuk_no;
        public  Form1()
        {
            InitializeComponent();
        }
        public void Tikla(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor == Color.Pink)
            {
                btn.BackColor = System.Drawing.SystemColors.Control;
                satilan_koltuk--;
            }
            else
            {
                btn.BackColor = Color.Pink;
                satilan_koltuk++;
            }
            label2.Text = "SATILAN KOLTUK" + satilan_koltuk.ToString();
            label3.Text = "KALAN KOLTUK " + (koltuk_no - satilan_koltuk).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            koltuk_no = 1;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (j != 2)
                    {
                        Button btn = new Button();
                        btn.Location = new Point(10 + i * 45, 10 + j * 45);
                        btn.Name = "btn_" + j.ToString() + i.ToString();
                        btn.Text = koltuk_no.ToString();
                        btn.Size = new Size(40, 40);
                        btn.Click += new EventHandler(Tikla);
                        this.Controls.Add(btn);
                        koltuk_no++;

                    }
                }
            }
            koltuk_no--;
            satilan_koltuk = 0;
            label1.Text = "KOLTUK SAYISI" + koltuk_no.ToString();
        }
    }
}
