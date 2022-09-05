using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_beti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n, m;
        string a = "";
        string b = "";
        string c = "";
        string d = "";

        private void esaplaw_Click(object sender, EventArgs e)
        {
                a = "";
                b = "";
                c = "";
                d = "";
                Manis_beriw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            
        }

        private void Manis_beriw()
        {
            try
            {
                n = int.Parse(Sani.Text);
                m = int.Parse(Baslangish.Text);

                if (n % 4 == 0)
                {
                    for (int i = n - 1 + m, j = m; (i > m - 1 + n / 2) && (j < m - 1 + n / 2); i = i - 2, j = j + 2)
                    {
                        a += i + ",";
                        if (j == (m + n / 2 - 2))
                            a += j.ToString();
                        else
                            a += j + ",";

                    }

                    for (int i = m + n / 2 - 1, j = m + n / 2; i > m - 1 && j < n + m; i = i - 2, j = j + 2)
                    {
                        b += i + ",";
                        if (j == (m + n - 2))
                            b += j.ToString();
                        else
                            b += j + ",";

                    }

                    if (n % 8 == 0)
                    {
                        for (int i = n - 1 + m, j = m; (i > m - 1 + n / 2) && (j < m - 1 + n / 2); i = i - 2, j = j + 2)
                        {
                            c += i + ",";
                            if (j == (m + n / 2 - 2))
                                c += j.ToString();
                            else
                                c += j + ",";

                        }

                        for (int i = (m + n / 2 - 3), j = m + n / 2 + 2, k = m + n / 2 - 1, l = m + n / 2; (i >= m - 1) && (j <= m + n - 2) && (k >= m + 3) && (l <= m + n - 4); i = i - 4, j = j + 4, k = k - 4, l = l + 4)
                        {
                            d += i + ",";
                            d += j + ",";
                            d += k + ",";
                            if (l == (m + n - 4))
                                d += l.ToString();
                            else
                                d += l + ",";

                        }
                    }
                    else
                    {
                        c += "Betler sani 8 ge eseli boliwi kerek(8,16,24...)";
                        d += "***********************************************";
                    }
                    bir.Text = a;
                    eki.Text = b;
                    ush.Text = c;
                    tort.Text = d;
                }
                else
                {
                    panel1.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Siz pu'tin san kiritpedin'iz' ");
            }
        }
        
    }
}
