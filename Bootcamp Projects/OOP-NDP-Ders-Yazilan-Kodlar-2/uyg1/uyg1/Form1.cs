using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int j=0;j<10;j++)
            {
                for(int i=0;i<10;i++)
                {
                    Button btn = new Button();   //buton sınıfından bir nesne oluşturuldu.
                    btn.Location = new System.Drawing.Point(10 + i * 50, 10 + j * 50);
                    btn.Margin = new Padding(5, 4, 5, 4);
                    btn.Size=new Size(50, 30);
                    btn.Text = "btn_" + j.ToString() + i.ToString();
                    this.Controls.Add(btn);
                }
            }

        }
    }
}
