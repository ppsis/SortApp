using System;
using System.Windows.Forms;

namespace SortApp
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Введите числа для сортировки ");
                return;
            }

            int[] sortedArray = null;

            switch (cmbSortingMethod.SelectedIndex)
            {
                case 0:
                    sortedArray = BubbleSort(array);
                    break;
                case 1:
                    sortedArray = InsertionSort(array);
                    break;
                case 2:
                    sortedArray = TreeSort(array);
                    break;
                case 3:
                    sortedArray = SelectionSort(array);
                    break;
            }

            if (sortedArray != null)
            {
                string sortedString = string.Join(", ", sortedArray);
                txtSortedData.Text = sortedString;
            }
        }

        // Bubble sort algorithm
        private int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        // Insertion sort algorithm
        private int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        // Tree sort algorithm
        private int[] TreeSort(int[] arr)
        {
            throw new NotImplementedException("Tree sort algorithm is not implemented yet.");
        }

        // Selection sort algorithm
        private int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        // validate user input and store the array
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            string input = txtInputData.Text.Trim();
            string[] inputArray = input.Split(',');
            int[] intArray = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; if (int.TryParse(inputArray[i], out int result))
                {
                    intArray[i] = result;
                }
                else
                {
                    MessageBox.Show("Ввод неправильного значения, перезапишите");
                    return;
                }
        }

        // store the array
        array = intArray;
        txtInputData.Clear();
        txtSortedData.Clear();
        MessageBox.Show("Массив успешно введен");
    }
}
