using System;

namespace algoritma_odev
{
    class Program
    {
        protected void btSort_Click(object sender, EventArgs e)
        {
            int length = int.Parse(tbNumber.Text);
            int limit = int.Parse(tbLimit.Text);
            int[] dizi = new int[length];
            Random random = new Random();
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < length; i++)
                dizi[i] = random.Next(1, limit);

            sw.Start();
            insertion_sort(dizi);
            sw.Stop();
            TimeSpan time = sw.Elapsed;
            Response.Write("Geçen süre:" + time.ToString());

            for (int i = 0; i < length; i++)
                lbSorted.Text += (dizi[i].ToString() + " ");
        }

            public void insertion_sort(int[] dizi)
            {
                for (int j = 1; j < dizi.Length; j++)
                {
                    int key = dizi[j];
                    int i = j - 1;
                    while (i >= 0 && dizi[i] > key)
                    {
                        dizi[i + 1] = dizi[i];
                        i = i - 1;
                    }
                    dizi[i + 1] = key;
                }
            }
        }
    }
}
