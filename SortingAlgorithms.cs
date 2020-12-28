using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_O_Matic
{
    class SortingAlgorithms
    {
        Graphics Graph;
        Bitmap BMsaver;
        ArrayList SortingArr;
        PictureBox DataSamples;
        int PanHeight;
        Dictionary<int, bool> SwappingSample = new Dictionary<int, bool>(); // Where key is sample's index

        public SortingAlgorithms(ArrayList myArrList, PictureBox myPB)
        {
            SortingArr = myArrList;
            DataSamples = myPB;

            BMsaver = new Bitmap(DataSamples.Width, DataSamples.Height);
            Graph = Graphics.FromImage(BMsaver);
            PanHeight = DataSamples.Height;
            DataSamples.Image = BMsaver;
            DrawDataSample();
        }


        // Sorting Algorithms
        // These algorithms are based on online sources

        //https://www.geeksforgeeks.org/odd-even-sort-brick-sort/
        internal void OddEvenSort(ArrayList myData)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                // Odd indexes 
                for (int i = 1; i < myData.Count-1; i+=2)
                {
                    if (((IComparable)myData[i]).CompareTo(myData[i+1]) > 0)
                    {
                        Swap(myData, i, i + 1);
                        isSorted = false;
                    }
                }

                // Even indexes 
                for (int i = 0; i < myData.Count - 1; i += 2)
                {
                    if (((IComparable)myData[i]).CompareTo(myData[i + 1]) > 0)
                    {
                        Swap(myData, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        // https://www.geeksforgeeks.org/selection-sort/
        internal void SelectionSort(ArrayList myData)
        {
            for (int i = 0; i < myData.Count; i++)
            {
                int min_idx = i;
                // Finding minimum
                for (int j = i+1; j < myData.Count; j++)
                {
                    if(((IComparable)myData[j]).CompareTo(myData[min_idx]) < 0)
                    {
                        min_idx = j;
                    }                   
                }

                // Swapping
                if (i < min_idx)
                {
                    Swap(myData, i, min_idx);
                }
            }
        }

        //https://www.geeksforgeeks.org/quick-sort/
        internal void QuickSort(ArrayList myData, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(myData, low, high);
                QuickSort(myData, low, p - 1);
                QuickSort(myData, p + 1, high);
            }
        }

        private int Partition(ArrayList myData, int low, int high)
        {
            int pivot = Convert.ToInt32(myData[high]);
            int min_idx = low - 1;

            for (int j = low; j < high; j++)
            {
                if(((IComparable)myData[j]).CompareTo(pivot) < 0)
                {
                    min_idx++;
                    Swap(myData, min_idx, j);
                }
            }

            Swap(myData, min_idx + 1, high);
            return min_idx + 1;
        }

        //https://www.geeksforgeeks.org/bubble-sort/
        internal void BubbleSort(ArrayList myData)
        {
            for (int i = 0; i < myData.Count-1; i++)
            {
                for (int j = 0; j<myData.Count-i-1; j++)
                {
                    if (((IComparable)myData[j]).CompareTo(myData[j+1]) > 0)
                    {
                        Swap(myData, j, j+1);
                    }
                }
            }
        }

        // These methods easing sorting and illustrating
        private void Swap(ArrayList arr, int id1, int id2)
        {
            // Standard swapping algorithm
            object temp = arr[id1];
            arr[id1] = arr[id2];
            arr[id2] = temp;

            // Updating Dictionary
            if (!(SwappingSample.ContainsKey(id1)))
            {
                SwappingSample.Add(id1, false);
            }
            if (!(SwappingSample.ContainsKey(id2)))
            {
                SwappingSample.Add(id2, false);
            }

            DrawDataSample();
            Refreshing(DataSamples);
            Thread.Sleep(100);
            SwappingSample.Clear();
        }

        public void DrawDataSample()
        {
            double modifyH = 1.0; // Depending on size of data

            // Checking need of modifing height
            if((BMsaver.Width!=DataSamples.Width) || (BMsaver.Height) != DataSamples.Height)
            {
                BMsaver = new Bitmap(DataSamples.Width, DataSamples.Height);
                Graph = Graphics.FromImage(BMsaver);
                DataSamples.Image = BMsaver;
            }
            if (DataSamples.Height != PanHeight)
            {
                modifyH = (double)(DataSamples.Height) / (double)(PanHeight);
            }

            // Design part
            Graph.Clear(Color.White);

            // Gray for data samples
            Pen grayPen = new Pen(Color.DarkSlateGray);
            SolidBrush grayBrush = new SolidBrush(Color.DarkSlateGray);

            // Aquamarine for swaping
            Pen aquaPen = new Pen(Color.Aquamarine);
            SolidBrush aquaBrush = new SolidBrush(Color.Aquamarine);

            int sampleW = (DataSamples.Width / SortingArr.Count) - 1;

            // Start drawing
            for (int i = 0; i < this.SortingArr.Count; i++)
            {
                int index = (int)(((double)DataSamples.Width / SortingArr.Count) * i);
                int sampleH = Convert.ToInt32(Math.Round(Convert.ToDouble(SortingArr[i]) * modifyH));

                // Drawing swapped sample
                if (SwappingSample.ContainsKey(i))
                {
                    if (sampleW <= 1)
                    {
                        // Thinner drawing
                        Graph.DrawLine(aquaPen, new Point(index, DataSamples.Height), new Point(index, DataSamples.Height - sampleH));
                    }
                    else
                    {
                        // Thicker drawing
                        Graph.FillRectangle(aquaBrush, index, DataSamples.Height - sampleH, sampleW, DataSamples.Height);
                    }
                }
                else // Remaining samples
                {
                    if (sampleW <= 1)
                    {
                        // Thinner drawing
                        Graph.DrawLine(grayPen, new Point(index, DataSamples.Height), new Point(index, DataSamples.Height - sampleH));
                    }
                    else
                    {
                        // Thicker drawing
                        Graph.FillRectangle(grayBrush, index, DataSamples.Height - sampleH, sampleW, DataSamples.Height);
                    }
                }
            }
        }

        // Solving a cross-threading exception
        //https://stackoverflow.com/questions/5868783/solve-a-cross-threading-exception-in-winforms 
        delegate void InvocationDelegate(Control dataSamples);

        private void Refreshing(Control dataSamples)
        {
            if (dataSamples.InvokeRequired)
            {
                InvocationDelegate d = new InvocationDelegate(Refreshing);
                dataSamples.Invoke(d, new object[] { dataSamples });
            }
            else
            {
                dataSamples.Refresh();
            }
        }
    }
}