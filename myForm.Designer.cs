namespace Sort_O_Matic
{
    partial class myForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sortBox1 = new System.Windows.Forms.PictureBox();
            this.sortBox2 = new System.Windows.Forms.PictureBox();
            this.algorithm1 = new System.Windows.Forms.ComboBox();
            this.algorithm2 = new System.Windows.Forms.ComboBox();
            this.dataSize = new System.Windows.Forms.Label();
            this.sizeTracker = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generatedData = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.Button();
            this.sizeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sortBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // sortBox1
            // 
            this.sortBox1.BackColor = System.Drawing.Color.White;
            this.sortBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortBox1.Location = new System.Drawing.Point(13, 13);
            this.sortBox1.Margin = new System.Windows.Forms.Padding(4);
            this.sortBox1.Name = "sortBox1";
            this.sortBox1.Size = new System.Drawing.Size(266, 246);
            this.sortBox1.TabIndex = 7;
            this.sortBox1.TabStop = false;
            // 
            // sortBox2
            // 
            this.sortBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortBox2.BackColor = System.Drawing.Color.White;
            this.sortBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sortBox2.Location = new System.Drawing.Point(288, 13);
            this.sortBox2.Margin = new System.Windows.Forms.Padding(4);
            this.sortBox2.Name = "sortBox2";
            this.sortBox2.Size = new System.Drawing.Size(266, 246);
            this.sortBox2.TabIndex = 8;
            this.sortBox2.TabStop = false;
            // 
            // algorithm1
            // 
            this.algorithm1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.algorithm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algorithm1.FormattingEnabled = true;
            this.algorithm1.Items.AddRange(new object[] {
            "",
            "Odd-Even Sort",
            "Quicksort",
            "Selection Sort",
            "Bubble Sort"});
            this.algorithm1.Location = new System.Drawing.Point(14, 280);
            this.algorithm1.Margin = new System.Windows.Forms.Padding(4);
            this.algorithm1.Name = "algorithm1";
            this.algorithm1.Size = new System.Drawing.Size(265, 24);
            this.algorithm1.TabIndex = 9;
            // 
            // algorithm2
            // 
            this.algorithm2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.algorithm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algorithm2.FormattingEnabled = true;
            this.algorithm2.Items.AddRange(new object[] {
            "",
            "Odd-Even Sort",
            "Quicksort",
            "Selection Sort",
            "Bubble Sort"});
            this.algorithm2.Location = new System.Drawing.Point(288, 280);
            this.algorithm2.Margin = new System.Windows.Forms.Padding(4);
            this.algorithm2.Name = "algorithm2";
            this.algorithm2.Size = new System.Drawing.Size(265, 24);
            this.algorithm2.TabIndex = 10;
            // 
            // dataSize
            // 
            this.dataSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataSize.AutoSize = true;
            this.dataSize.Location = new System.Drawing.Point(13, 325);
            this.dataSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataSize.Name = "dataSize";
            this.dataSize.Size = new System.Drawing.Size(71, 17);
            this.dataSize.TabIndex = 11;
            this.dataSize.Text = "Data size:";
            // 
            // sizeTracker
            // 
            this.sizeTracker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sizeTracker.BackColor = System.Drawing.Color.DarkGray;
            this.sizeTracker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeTracker.LargeChange = 10;
            this.sizeTracker.Location = new System.Drawing.Point(71, 346);
            this.sizeTracker.Margin = new System.Windows.Forms.Padding(4);
            this.sizeTracker.Maximum = 500;
            this.sizeTracker.Minimum = 10;
            this.sizeTracker.Name = "sizeTracker";
            this.sizeTracker.Size = new System.Drawing.Size(160, 56);
            this.sizeTracker.TabIndex = 12;
            this.sizeTracker.TickFrequency = 50;
            this.sizeTracker.Value = 25;
            this.sizeTracker.Scroll += new System.EventHandler(this.sizeTracker_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "500";
            // 
            // generatedData
            // 
            this.generatedData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generatedData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatedData.FormattingEnabled = true;
            this.generatedData.Items.AddRange(new object[] {
            "Random",
            "Ascending Order",
            "Descending Order"});
            this.generatedData.Location = new System.Drawing.Point(288, 339);
            this.generatedData.Margin = new System.Windows.Forms.Padding(4);
            this.generatedData.Name = "generatedData";
            this.generatedData.Size = new System.Drawing.Size(265, 24);
            this.generatedData.TabIndex = 35;
            // 
            // sort
            // 
            this.sort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sort.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.Location = new System.Drawing.Point(213, 401);
            this.sort.Margin = new System.Windows.Forms.Padding(4);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(145, 56);
            this.sort.TabIndex = 36;
            this.sort.Text = "Start Sorting";
            this.sort.UseVisualStyleBackColor = false;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // sizeValue
            // 
            this.sizeValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sizeValue.AutoSize = true;
            this.sizeValue.Location = new System.Drawing.Point(92, 325);
            this.sizeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeValue.Name = "sizeValue";
            this.sizeValue.Size = new System.Drawing.Size(24, 17);
            this.sizeValue.TabIndex = 37;
            this.sizeValue.Text = "25";
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(569, 470);
            this.Controls.Add(this.sizeValue);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.generatedData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTracker);
            this.Controls.Add(this.dataSize);
            this.Controls.Add(this.algorithm2);
            this.Controls.Add(this.algorithm1);
            this.Controls.Add(this.sortBox2);
            this.Controls.Add(this.sortBox1);
            this.Name = "myForm";
            this.Text = "Sort-O-Matic";
            this.Load += new System.EventHandler(this.myForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sortBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sortBox1;
        private System.Windows.Forms.PictureBox sortBox2;
        private System.Windows.Forms.ComboBox algorithm1;
        private System.Windows.Forms.ComboBox algorithm2;
        private System.Windows.Forms.Label dataSize;
        private System.Windows.Forms.TrackBar sizeTracker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox generatedData;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Label sizeValue;
    }
}

