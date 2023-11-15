using System.Windows.Forms;

namespace Zjecia
{
    partial class SortAlgorithmForm
    {
        private CheckBox checkBoxGenerateNumbers;
        private NumericUpDown numericUpDownMax;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Label labelTime;
        private Button buttonBubbleSort;
        private Button buttonSelectionSort;
        private Button buttonInsertionSort;
        private Button buttonMergeSort;
        private Button buttonQuickSort;
        private Button generateButton;

        private void InitializeComponent()
        {
            this.checkBoxGenerateNumbers = new System.Windows.Forms.CheckBox();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonBubbleSort = new System.Windows.Forms.Button();
            this.buttonSelectionSort = new System.Windows.Forms.Button();
            this.buttonInsertionSort = new System.Windows.Forms.Button();
            this.buttonMergeSort = new System.Windows.Forms.Button();
            this.buttonQuickSort = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();

            this.buttonBubbleSort.Click += new System.EventHandler(this.MethodButton_Click);
            this.buttonSelectionSort.Click += new System.EventHandler(this.MethodButton_Click);
            this.buttonInsertionSort.Click += new System.EventHandler(this.MethodButton_Click);
            this.buttonMergeSort.Click += new System.EventHandler(this.MethodButton_Click);
            this.buttonQuickSort.Click += new System.EventHandler(this.MethodButton_Click);
            this.generateButton.Click += new System.EventHandler(this.MethodButton_Click);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxGenerateNumbers
            // 
            this.checkBoxGenerateNumbers.Location = new System.Drawing.Point(212, 26);
            this.checkBoxGenerateNumbers.Name = "checkBoxGenerateNumbers";
            this.checkBoxGenerateNumbers.Size = new System.Drawing.Size(104, 24);
            this.checkBoxGenerateNumbers.TabIndex = 0;
            this.checkBoxGenerateNumbers.Text = "Generate Random Numbers";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(322, 26);
            this.numericUpDownMax.Maximum = new decimal(new int[] {2000000,0,0,0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {1,0,0,0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 1;
            this.numericUpDownMax.Value = new decimal(new int[] {1,0,0,0});
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(5, 26);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(200, 50);
            this.textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(10, 140);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(200, 50);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(319, 140);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 23);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Czas wykonania: ";
            // 
            // buttonBubbleSort
            // 
            this.buttonBubbleSort.Location = new System.Drawing.Point(10, 240);
            this.buttonBubbleSort.Name = "buttonBubbleSort";
            this.buttonBubbleSort.Size = new System.Drawing.Size(104, 24);
            this.buttonBubbleSort.TabIndex = 5;
            this.buttonBubbleSort.Text = "Bubble Sort";
            // 
            // buttonSelectionSort
            // 
            this.buttonSelectionSort.Location = new System.Drawing.Point(120, 240);
            this.buttonSelectionSort.Name = "buttonSelectionSort";
            this.buttonSelectionSort.Size = new System.Drawing.Size(104, 24);
            this.buttonSelectionSort.TabIndex = 6;
            this.buttonSelectionSort.Text = "Selection Sort";
            // 
            // buttonInsertionSort
            // 
            this.buttonInsertionSort.Location = new System.Drawing.Point(230, 240);
            this.buttonInsertionSort.Name = "buttonInsertionSort";
            this.buttonInsertionSort.Size = new System.Drawing.Size(104, 24);
            this.buttonInsertionSort.TabIndex = 7;
            this.buttonInsertionSort.Text = "Insertion Sort";
            // 
            // buttonMergeSort
            // 
            this.buttonMergeSort.Location = new System.Drawing.Point(338, 240);
            this.buttonMergeSort.Name = "buttonMergeSort";
            this.buttonMergeSort.Size = new System.Drawing.Size(104, 24);
            this.buttonMergeSort.TabIndex = 8;
            this.buttonMergeSort.Text = "Merge Sort";
            // 
            // buttonQuickSort
            // 
            this.buttonQuickSort.Location = new System.Drawing.Point(448, 240);
            this.buttonQuickSort.Name = "buttonQuickSort";
            this.buttonQuickSort.Size = new System.Drawing.Size(104, 24);
            this.buttonQuickSort.TabIndex = 9;
            this.buttonQuickSort.Text = "Quick Sort";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(322, 72);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            
            
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.Controls.Add(this.checkBoxGenerateNumbers);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonBubbleSort);
            this.Controls.Add(this.buttonSelectionSort);
            this.Controls.Add(this.buttonInsertionSort);
            this.Controls.Add(this.buttonMergeSort);
            this.Controls.Add(this.buttonQuickSort);
            this.Controls.Add(this.generateButton);
            this.Name = "SortAlgorithmForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button SortBubble;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
