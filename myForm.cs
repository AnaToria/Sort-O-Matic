using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading.Tasks;

namespace Sort_O_Matic
{
    public partial class myForm : Form
    {
        Graphics Graph1;
        Graphics Graph2;
        ArrayList MyData1;
        ArrayList MyData2;
        Bitmap BM1;
        Bitmap BM2;

        static Random myRand = new Random();

        public myForm()
        {
            InitializeComponent();
        }

        // Set form appearance 
        private void myForm_Load(object sender, EventArgs e)
        {
            algorithm1.SelectedIndex = algorithm1.Items.IndexOf("Odd-Even Sort");
            algorithm2.SelectedIndex = algorithm2.Items.IndexOf("Quicksort");
            sizeTracker.Value = 25;
            generatedData.SelectedIndex = generatedData.Items.IndexOf("Random");
        }

        // This method randomizes my data list
        public void RandomData(IList myList)
        {
            for (int i = myList.Count-1; i > 0; i--)
            {
                int temp = myRand.Next(i + 1);
                if (temp!=i)
                {
                    object obj = myList[temp];
                    myList[temp] = myList[i];
                    myList[i] = obj;
                }
            }
        }

        // This method loads primary form
        private void SetUp()
        {
            // PictureBox I
            BM1 = new Bitmap(sortBox1.Width, sortBox1.Height);
            Graph1 = Graphics.FromImage(BM1);
            sortBox1.Image = BM1;

            // PictureBox II
            BM2 = new Bitmap(sortBox2.Width, sortBox2.Height);
            Graph2 = Graphics.FromImage(BM2);
            sortBox2.Image = BM2;

            // Data for sorting
            MyData1 = new ArrayList(sizeTracker.Value);
            MyData2 = new ArrayList(sizeTracker.Value);

            // Initializing data
            for (int i = 1; i <= MyData1.Capacity; i++)
            {
                // Defining each element's column height
                int el = (int)((double)(i) * sortBox1.Height / MyData1.Capacity );
                MyData1.Add(el);
            }
            //Randomizing data
            RandomData(MyData1);

            // Creating shallow copy to duplicate as little as possiblee
            MyData2 = (ArrayList)MyData1.Clone();
        }

        // This method is response to clicking sort button
        private void sort_Click(object sender, EventArgs e)
        {
            SetUp();
            if (generatedData.SelectedItem.ToString() == "Random")
            {
                // Data is already randomized
            }
            else if (generatedData.SelectedItem.ToString() == "Ascending Order")
            {
                MyData1.Sort();
                MyData2 = (ArrayList)MyData1.Clone();
            }
            else if (generatedData.SelectedItem.ToString() == "Descending Order")
            {
                MyData1.Sort();
                MyData1.Reverse();
                MyData2 = (ArrayList)MyData1.Clone();
            }

            string sortAlg1 = "";
            if (algorithm1.SelectedItem != null)
            {
                sortAlg1 = algorithm1.SelectedItem.ToString();
            }
            SortingAlgorithms myAlg1 = new SortingAlgorithms(MyData1, sortBox1);
            // Using Task.Run for asynchronous programming
            Task.Run(() =>
            {
                switch (sortAlg1)
                {
                    case "Odd-Even Sort":
                        myAlg1.OddEvenSort(MyData1);
                        break;
                    case "Quicksort":
                        myAlg1.QuickSort(MyData1, 0, MyData1.Count - 1);
                        break;
                    case "Selection Sort":
                        myAlg1.SelectionSort(MyData1);
                        break;
                    case "Bubble Sort":
                        myAlg1.BubbleSort(MyData1);
                        break;
                }
            });

            string sortAlg2 = "";
            if (algorithm2.SelectedItem != null)
            {
                sortAlg2 = algorithm2.SelectedItem.ToString();
            }
            SortingAlgorithms myAlg2 = new SortingAlgorithms(MyData2, sortBox2);
            // Using Task.Run for asynchronous programming
            Task.Run(() =>
            {
                switch (sortAlg2)
                {
                    case "Odd-Even Sort":
                        myAlg2.OddEvenSort(MyData2);
                        break;
                    case "Quicksort":
                        myAlg2.QuickSort(MyData2, 0, MyData2.Count - 1);
                        break;
                    case "Selection Sort":
                        myAlg2.SelectionSort(MyData2);
                        break;
                    case "Bubble Sort":
                        myAlg2.BubbleSort(MyData2);
                        break;
                }
            });
        }

        // This method shows value of data size
        private void sizeTracker_Scroll(object sender, EventArgs e)
        {
            sizeValue.Text = sizeTracker.Value.ToString();
        }
    }
}