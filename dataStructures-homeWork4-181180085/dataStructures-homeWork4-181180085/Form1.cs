using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataStructures_homeWork4_181180085
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        class queueNode
        {
            public string personName;
            public queueNode nextOne;
            public queueNode(string personName)
            {
                this.personName = personName;

            }
        }
        class queue
        {
            public int size;
            public queueNode headNode1, headNode2, headNode3;
            public queue(string personName)
            {
                this.headNode1 = new queueNode(personName);
                this.headNode1.nextOne = headNode1;
                this.headNode2 = new queueNode(personName);
                this.headNode2.nextOne = headNode2;
                this.headNode3 = new queueNode(personName);
                this.headNode3.nextOne = headNode3;
                this.size = 0;
            }
        }
        queue personQueue = new queue("");

        public void listBoxRefresh()
        {
            listBox1.Items.Clear();

            queueNode active1 = new queueNode(" ");
            active1 = personQueue.headNode1;

            while (active1.nextOne != active1)
            {


                {
                    listBox1.Items.Add(active1.nextOne.personName);
                    active1 = active1.nextOne;

                }
            }

            queueNode active2 = new queueNode(" ");
            active2 = personQueue.headNode2;
            while (active2.nextOne != active2)
            {



                {
                    listBox1.Items.Add(active2.nextOne.personName);
                    active2 = active2.nextOne;
                }

            }
            queueNode active3 = new queueNode(" ");
            active3 = personQueue.headNode3;
            while (active3.nextOne != active3)
            {

                {
                    listBox1.Items.Add(active3.nextOne.personName);
                    active3 = active3.nextOne;
                }
            }



        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    queueNode newNode1 = new queueNode(textBox1.Text);
                    queueNode active1 = personQueue.headNode1;
                    while (active1.nextOne != active1)
                    {
                        active1 = active1.nextOne;
                    }
                    newNode1.nextOne = newNode1;
                    active1.nextOne = newNode1;


                    listBoxRefresh();
                    personQueue.size++;
                }
                else if (radioButton2.Checked == true)
                {
                    queueNode newNode1 = new queueNode(textBox1.Text);
                    queueNode active1 = personQueue.headNode2;
                    while (active1.nextOne != active1)
                    {
                        active1 = active1.nextOne;
                    }
                    active1.nextOne = newNode1;
                    newNode1.nextOne = newNode1;
                    listBoxRefresh();
                    personQueue.size++;
                }
                else if (radioButton3.Checked == true)
                {
                    queueNode newNode1 = new queueNode(textBox1.Text);
                    queueNode active1 = personQueue.headNode3;
                    while (active1.nextOne != active1)
                    {
                        active1 = active1.nextOne;
                    }
                    active1.nextOne = newNode1;
                    newNode1.nextOne = newNode1;
                    listBoxRefresh();
                    personQueue.size++;
                }
            }
            else if (textBox1.Text == "" && (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true))
                MessageBox.Show("Lütfen isminizi girdiğinizden emin olun!!!");
            else if (textBox1.Text == "" && (radioButton1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false))
                MessageBox.Show("Lütfen isminizi girdiğinizden ve işlem önceliğinizi seçtiğinizden emin olun!!!");
            else
                MessageBox.Show("Lütfen işlem önceliğinizi seçtiğinizden emin olun!!!");






        }

        private void button2_Click(object sender, EventArgs e)
        {
            queueNode newNode1 = new queueNode(null);
            newNode1 = personQueue.headNode1;
            queueNode newNode2 = new queueNode(null);
            newNode2 = personQueue.headNode2;
            queueNode newNode3 = new queueNode(null);
            newNode3 = personQueue.headNode3;
            textBox2.Text = personQueue.headNode1.nextOne.personName.ToString();
            personQueue.headNode1 = personQueue.headNode1.nextOne;


            listBoxRefresh();




            if (newNode1 == personQueue.headNode1)
            {
                textBox2.Text = personQueue.headNode2.nextOne.personName.ToString();
                personQueue.headNode2 = personQueue.headNode2.nextOne;
                listBoxRefresh();
            }
            if (newNode2 == personQueue.headNode2 && newNode1 == personQueue.headNode1)
            {
                textBox2.Text = personQueue.headNode3.nextOne.personName.ToString();
                personQueue.headNode3 = personQueue.headNode3.nextOne;
                listBoxRefresh();
            }
            if (newNode2 == personQueue.headNode2 && newNode1 == personQueue.headNode1 && newNode3 == personQueue.headNode3)
            {
                textBox2.Text = null;
                MessageBox.Show("Kuyrukta Eleman Yok!!");
                listBoxRefresh();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}