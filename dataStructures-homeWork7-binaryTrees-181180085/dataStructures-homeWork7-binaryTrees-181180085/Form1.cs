using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataStructures_homeWork7_binaryTrees_181180085
{
    public partial class Form1 : Form
    {
        static int kontrol = 0;
        static string levelorder=null;
        public Form1()
        {
            InitializeComponent();
        }
        public class BinaryTree
        {
            public  class Node
            {
                public int key;
                public Node left, right;

                public Node(int item)
                {
                    key = item;
                    left = right = null;
                }
            }
           public Node root; 
            public BinaryTree()
            {
                root = null;
            }
  
            public void deleteK(int key)
            {
                root = deleteRecursively(root, key);
            }
            public Node deleteRecursively(Node root, int key)
            {
                if (root == null) return root;

                if (key < root.key)
                    root.left = deleteRecursively(root.left, key);
                else if (key > root.key)
                    root.right = deleteRecursively(root.right, key);
                else
                {
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;  
                    root.key = minVal(root.right);  
                    root.right = deleteRecursively(root.right, root.key);
                }
                return root;
            }

            public int minVal(Node root)
            {
                int minv = root.key;
                while (root.left != null)
                {
                    minv = root.left.key;
                    root = root.left;
                }
                return minv;
            }  
            public void Insert(int key)
            {
                root = InsertRec(root, key);
            }

            public Node InsertRec(Node root, int key)
            {
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }
                if (key < root.key)
                    root.left = InsertRec(root.left, key);
                else if (key > root.key)
                    root.right = InsertRec(root.right, key);
                return root;
            }
  
            public void Inlevelorder()
            {
                InlevelorderRec(root);
            }
            
            public void InlevelorderRec(Node root)
            {
                if (root != null)
                {
                    InlevelorderRec(root.left);
                    Console.Write(root.key + " ");
                    InlevelorderRec(root.right);
                }
            }
            public static int findMax(Node node)
            {
                if (node == null)
                {
                    return int.MinValue;
                }

                int res = node.key;
                int lres = findMax(node.left);
                int rres = findMax(node.right);

                if (lres > res)
                {
                    res = lres;
                }
                if (rres > res)
                {
                    res = rres;
                }
                return res;
            }
            public static int findMin(Node node)
            {
                if (node == null)
                    return int.MaxValue;

                int res = node.key;
                int lres = findMin(node.left);
                int rres = findMin(node.right);

                if (lres < res)
                    res = lres;
                if (rres < res)
                    res = rres;
                return res;
            }
            public virtual void printLevellevelorder()
            {
                int h = height(root);
                int i;
                for (i = 1; i <= h; i++)
                {
                    printGivenLevel(root, i);
                }
            }

            public virtual int height(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    int lheight = height(root.left);
                    int rheight = height(root.right);


                    if (lheight > rheight)
                    {
                        return (lheight + 1);
                    }
                    else
                    {
                        return (rheight + 1);
                    }
                }
            }

            public virtual void printGivenLevel(Node root, int level)
            {
                if (root == null)
                {
                    return;
                }
                if (level == 1)
                {
                    levelorder += root.key.ToString()+"-";
                }
                else if (level > 1)
                {
                    printGivenLevel(root.left, level - 1);
                    printGivenLevel(root.right, level - 1);
                }
            }
            public virtual void deleteTree(Node node)
            {
                
                root = null;
            }


        }



        BinaryTree tree = new BinaryTree();

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = "";
                tree.Insert(Convert.ToInt32(textBox1.Text));
                listBox1.Items.Add(textBox1.Text);
                levelorder = null;
            }
            catch
            {
                MessageBox.Show("Lütfen kutuya bir sayı yazıp eklemeye çalışınız!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString() == textBox2.Text)
                        {

                            tree.deleteK(Convert.ToInt32(textBox2.Text));
                            listBox1.Items.Remove(textBox2.Text);
                            levelorder = null;
                            textBox4.Text = "";
                            kontrol = 1;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        MessageBox.Show("Silmek istediğniz sayı ağaçta bulunmamaktadır!");
                    }
                    else
                    {
                        kontrol--;
                    }

                }
                catch
                {
                    MessageBox.Show("Lütfen kutuyu boş bırakmayınız!");
                }
            }
            else
                MessageBox.Show("Lütfen kutuyu boş bırakmayınız!");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
                textBox3.Text = BinaryTree.findMax(tree.root).ToString();
            else
                MessageBox.Show("Maksimum sayı bulunamaz çünkü oluşturulmuş bir ağaç yok!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
                textBox3.Text = BinaryTree.findMin(tree.root).ToString();
            else
                MessageBox.Show("Minimum sayı bulunamaz çünkü oluşturulmuş bir ağaç yok!");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                tree.printLevellevelorder();
                textBox4.Text = levelorder.ToString();
            }
            else
                MessageBox.Show("Ağacı Level-levelorder sırasına sokabilmek için önce bir ağaç oluşturmanız gerek!");



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                tree.deleteTree(tree.root);
                tree.root = null;
                listBox1.Items.Clear();
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Ağacı silebilmeniz için önce bir ağaç oluşturmanız gerek!");
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                levelorder = null;
            }
              
              
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
   
}

