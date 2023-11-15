using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Zjecia
{
    public partial class SortAlgorithmForm : Form
    {
        private int[] numbers;
        private Stopwatch stopwatch;
        private Random random = new Random();

        public SortAlgorithmForm()
        {
            InitializeComponent();
            numbers = new int[0];
        }

        private void MethodButton_Click(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();

            if (sender == generateButton)
            {
                // Tutaj umieść kod generowania liczb
                if (checkBoxGenerateNumbers.Checked)
                {
                    // Generowanie losowych liczb
                    numbers = Enumerable.Range(1, (int)numericUpDownMax.Value).Select(_ => random.Next()).ToArray();
                }
                else
                {
                    // Pobieranie liczb z textboxa i dzielenie ich na osobne liczby
                    numbers = textBoxInput.Text.Split(' ').Select(int.Parse).ToArray();
                }
            }
            else
            {
                // Tutaj umieść kod sortowania
                if (sender == buttonBubbleSort)
                {
                    BubbleSortAlgorithm(numbers);
                }
                else if (sender == buttonSelectionSort)
                {
                    SelectionSortAlgorithm(numbers);
                }
                else if (sender == buttonInsertionSort)
                {
                    InsertSort(numbers);
                }
                else if (sender == buttonMergeSort)
                {
                    MergeSortAlgorithm(numbers);
                }
                else if (sender == buttonQuickSort)
                {
                    QuickSortAlgorithm(numbers, 0, numbers.Length - 1);
                }
            }

            stopwatch.Stop();

            textBoxOutput.Text = string.Join(" ", numbers);
            labelTime.Text = $"Czas wykonania: {stopwatch.ElapsedMilliseconds} ms";
        }

        private void CheckBoxGenerateNumbers_CheckedChanged(object sender, EventArgs e)
        {
            // Zablokowanie lub odblokowanie TextBoxa do wprowadzania danych
            textBoxInput.ReadOnly = checkBoxGenerateNumbers.Checked;
            numericUpDownMax.Enabled = checkBoxGenerateNumbers.Checked;
        }

        // Implementacja algorytmów

        public static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Zamiana miejscami elementu arr[j] i arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public static void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public static void MergeSortAlgorithm(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int o = 0; o < n1; o++)
                leftArray[o] = arr[left + o];

            for (int v = 0; v < n2; v++)
                rightArray[v] = arr[middle + 1 + v];

            int k = left;
            int i = 0, j = 0;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }

        public void QuickSortAlgorithm(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivotIndex = Partition(array, leftIndex, rightIndex);

                if (pivotIndex > 1)
                {
                    QuickSortAlgorithm(array, leftIndex, pivotIndex - 1);
                }
                if (pivotIndex + 1 < rightIndex)
                {
                    QuickSortAlgorithm(array, pivotIndex + 1, rightIndex);
                }
            }
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }

            }
        }
    }
}
