namespace VincenteWilliamsA7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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


        #region Windows Form Deigner generated code

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            CarsListBox = new ListBox();
            SortByMakeBtn = new Button();
            SortByMakeAndPriceBtn = new Button();
            ChooseFileBtn = new Button();
            SuspendLayout();
            // 
            // CarsListBox
            // 
            CarsListBox.FormattingEnabled = true;
            CarsListBox.Location = new Point(213, 24);
            CarsListBox.Name = "CarsListBox";
            CarsListBox.Size = new Size(561, 404);
            CarsListBox.TabIndex = 0;
            // 
            // SortByMakeBtn
            // 
            SortByMakeBtn.Location = new Point(13, 84);
            SortByMakeBtn.Name = "SortByMakeBtn";
            SortByMakeBtn.Size = new Size(116, 29);
            SortByMakeBtn.TabIndex = 1;
            SortByMakeBtn.Text = "Sort By Make";
            SortByMakeBtn.UseVisualStyleBackColor = true;
            SortByMakeBtn.Click += SortByMakeBtn_Click;
            // 
            // SortByMakeAndPriceBtn
            // 
            SortByMakeAndPriceBtn.Location = new Point(12, 128);
            SortByMakeAndPriceBtn.Name = "SortByMakeAndPriceBtn";
            SortByMakeAndPriceBtn.Size = new Size(175, 29);
            SortByMakeAndPriceBtn.TabIndex = 2;
            SortByMakeAndPriceBtn.Text = "Sort By Make and Price";
            SortByMakeAndPriceBtn.UseVisualStyleBackColor = true;
            SortByMakeAndPriceBtn.Click += SortByMakeAndPriceBtn_Click;
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(12, 34);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(94, 29);
            ChooseFileBtn.TabIndex = 3;
            ChooseFileBtn.Text = "Choose File";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChooseFileBtn);
            Controls.Add(SortByMakeAndPriceBtn);
            Controls.Add(SortByMakeBtn);
            Controls.Add(CarsListBox);
            Name = "MainForm";
            Text = "Vincente Williams Assignment 7";
            ResumeLayout(false);
        }

        #endregion

        private ListBox CarsListBox;
        private Button SortByMakeBtn;
        private Button SortByMakeAndPriceBtn;
        private Button ChooseFileBtn;
    }
}
