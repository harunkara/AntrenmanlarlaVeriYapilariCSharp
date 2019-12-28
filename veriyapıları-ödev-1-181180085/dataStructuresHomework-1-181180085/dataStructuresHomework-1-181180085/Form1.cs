using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataStructuresHomework_1_181180085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {
             }
        }*/
        /* private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {

             }
         }*/
        int[] dizi = new int[] { 13, 34, 248, 287, 311, 386, 427, 585, 885, 915 };
        public void okKonumuSon(int[] dizi,int orta)
        {
            if (dizi[orta] == 13)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 41);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 34)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 66);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 248)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 93);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 287)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 118);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 311)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 145);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 386)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 169);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 427)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 193);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 585)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 219);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 885)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 245);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }
            if (dizi[orta] == 915)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 271);
                MessageBox.Show(orta.ToString() + ". indiste bulunmaktadır");

            }

        }
        public void okKonumuOrta(int[] dizi,int orta)
        {
            if (dizi[orta] == 13)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 41);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 34)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 66);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 248)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 93);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 287)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 118);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 311)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 145);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 386)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 169);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 427)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 193);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 585)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 219);
                MessageBox.Show(dizi[orta].ToString());

            }
            if (dizi[orta] == 885)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 245);
                MessageBox.Show(dizi[orta].ToString());
            }
            if (dizi[orta] == 915)
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(377, 271);
                MessageBox.Show(dizi[orta].ToString());

            }

        }
    


        private void Form1_Load(object sender, EventArgs e)
        {
           
        


        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                int kucuk = 0, buyuk = dizi.Length - 1, orta, bayrak = 0;
                int arananint = Convert.ToInt32(aranan.Text);
                while (kucuk <= buyuk)
                {
                    orta = (buyuk + kucuk) / 2;
                    if (arananint == dizi[orta])
                    {

                        if (dizi[orta].ToString() == listBox1.Items[orta].ToString())
                        {
                            listBox1.SelectedItem = dizi[orta].ToString();


                            pictureBox1.Location = new Point(294, 102);
                            bayrak = 1;
                            okKonumuSon(dizi, orta);
                            

                            break;
                        }


                    }
                    else if (arananint < dizi[orta])
                    {
                        if (dizi[orta].ToString() == listBox1.Items[orta].ToString())
                        {
                            listBox1.SelectedItem = dizi[orta].ToString();


                            buyuk = orta - 1;
                            okKonumuOrta(dizi, orta);
                           


                        }



                    }
                    else if (arananint > dizi[orta])
                    {
                        if (dizi[orta].ToString() == listBox1.Items[orta].ToString())
                        {
                            listBox1.SelectedItem = dizi[orta].ToString();

                            kucuk = orta + 1;
                            okKonumuOrta(dizi, orta);
                        }
                    }




                }

                if (bayrak == 0)
                {
                    MessageBox.Show("bu sayı bulunmamaktadır");
                    pictureBox1.Hide();

                }






            }
            catch (Exception)
            {
                MessageBox.Show("lutfen kutuya sayı girin");
            }
        }

        private void aranan_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
