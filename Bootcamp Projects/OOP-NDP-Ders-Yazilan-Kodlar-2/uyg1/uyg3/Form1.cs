using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg3
{
    public partial class Form1 : Form
    {
        List<Kartanesi> Kar_List;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kar_List = new List<Kartanesi>();
        }
        private void KarTanesiYarat(int x,int y)
        {
            Label lbl = new Label();
            lbl.Location = new Point(x, y);
            lbl.Text = "*";
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }
        private void RastgeleKarTanesiYarat(int sayi)
        {
            Random rnd = new Random();
            for(int i=0;i<sayi;i++)
            {
                int x = rnd.Next(this.Width);
                KarTanesiYarat(x, 1);
                Kar_List.Add(new Kartanesi(x, 1));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            RastgeleKarTanesiYarat(5);
            int i = 0;
            while (true)
            {
                try
                {
                    if (i == this.Controls.Count)
                        break;

                    Kartanesi _kt = Kar_List[i];
                    _kt.Kar_Dus();
                    Label lbl = (Label)this.Controls[i];
                    if (_kt.Y > this.Height)
                    {
                        Kar_List.RemoveAt(i);
                        this.Controls.Remove(lbl);
                        lbl = null;
                    }
                    else
                    {
                        lbl.Location = new Point(_kt.X, _kt.Y);
                        Kar_List[i] = _kt;
                        i++;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
