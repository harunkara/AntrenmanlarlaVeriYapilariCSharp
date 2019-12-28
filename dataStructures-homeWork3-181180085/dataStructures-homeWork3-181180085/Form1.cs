using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapAdiStructures_homeWork3_181180085
{
    public partial class Form1 : Form
    {
        public static int i;
        public Form1()
        {
            InitializeComponent();

        }
        public class Stack
        {

            Node headNode;

            public class Node
            {
                public string kitapAdi;
                public Node sonraki;
                public Node()
                {

                }
                public Node(string kitapAdi)
                {
                    this.kitapAdi = kitapAdi;
                }
            }

            public bool isEmpty()
            {
                if (headNode == null)
                {
                    return true;
                }
                else
                    return false;
            }

            public string push(string kitapAdi)
            {
                Node newNode = new Node(kitapAdi);

                if (headNode == null)
                {
                    headNode = newNode;
                }
                else
                {
                    Node temp = headNode;
                    headNode = newNode;
                    newNode.sonraki = temp;
                }

                return kitapAdi;

            }

            public string pop()
            {
                string poplanan = null;
                if (headNode == null)
                {
                    MessageBox.Show("Stack is Empty");
                }
                else
                {
                    poplanan = headNode.kitapAdi;
                    headNode = headNode.sonraki;
                   


                }
                return poplanan;
            }

            public string peek()
            {
                if (headNode == null)
                {
                    MessageBox.Show("Stack is empty");
                    return null;
                }
                else
                {
                    return headNode.kitapAdi;
                }
            }



        }
        Stack stck = new Stack();

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < numericUpDown1.Value)
                if (textBox1.Text != "")
                {

                    textBox2.Text = stck.push(textBox1.Text);
                    listBox1.Items.Insert(0, textBox1.Text);
                    label3.Text = "STACK SIZE= " + ++i;


                }
                else
                    MessageBox.Show("Enter a book name!");
            else

                MessageBox.Show("To push books to stack,please increase the maximum size of the stack");
        }




        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(stck.pop());
            textBox2.Text=stck.peek();
            label3.Text = "STACK SIZE= " + --i;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < i)
            {
                MessageBox.Show("You can not make the maximum size of the stack less than the number of items stored in the stack");
                numericUpDown1.Value = numericUpDown1.Value + 1;
            }
        }
    }


}
