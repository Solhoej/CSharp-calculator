namespace Teknologi_Eksamen
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            NewCategory = new TextBox();
            SubmitNewCategory = new Button();
            label3 = new Label();
            label4 = new Label();
            EarningsBox = new TextBox();
            SubmitEarnings = new Button();
            label5 = new Label();
            label6 = new Label();
            ExpenseBox = new TextBox();
            SubmitExpense = new Button();
            SelectCategory = new ComboBox();
            categoriesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(23, 29, 92);
            label1.Location = new Point(305, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Lav ny kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(315, 48);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Kategori";
            // 
            // NewCategory
            // 
            NewCategory.Location = new Point(370, 45);
            NewCategory.Name = "NewCategory";
            NewCategory.Size = new Size(100, 23);
            NewCategory.TabIndex = 2;
            // 
            // SubmitNewCategory
            // 
            SubmitNewCategory.Location = new Point(480, 45);
            SubmitNewCategory.Name = "SubmitNewCategory";
            SubmitNewCategory.Size = new Size(75, 23);
            SubmitNewCategory.TabIndex = 3;
            SubmitNewCategory.Text = "Submit";
            SubmitNewCategory.UseVisualStyleBackColor = true;
            SubmitNewCategory.Click += SubmitNewCategory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(23, 29, 92);
            label3.Location = new Point(25, 30);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Indsæt penge";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(35, 48);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Indtægt";
            // 
            // EarningsBox
            // 
            EarningsBox.Location = new Point(90, 45);
            EarningsBox.Name = "EarningsBox";
            EarningsBox.Size = new Size(100, 23);
            EarningsBox.TabIndex = 6;
            // 
            // SubmitEarnings
            // 
            SubmitEarnings.Location = new Point(200, 45);
            SubmitEarnings.Name = "SubmitEarnings";
            SubmitEarnings.Size = new Size(75, 23);
            SubmitEarnings.TabIndex = 7;
            SubmitEarnings.Text = "Submit";
            SubmitEarnings.UseVisualStyleBackColor = true;
            SubmitEarnings.Click += SubmitEarnings_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.FromArgb(23, 29, 92);
            label5.Location = new Point(585, 30);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 8;
            label5.Text = "Indskriv forbrug";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(595, 48);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Forbrug";
            // 
            // ExpenseBox
            // 
            ExpenseBox.Location = new Point(650, 45);
            ExpenseBox.Name = "ExpenseBox";
            ExpenseBox.Size = new Size(100, 23);
            ExpenseBox.TabIndex = 10;
            // 
            // SubmitExpense
            // 
            SubmitExpense.Location = new Point(760, 45);
            SubmitExpense.Name = "SubmitExpense";
            SubmitExpense.Size = new Size(75, 23);
            SubmitExpense.TabIndex = 11;
            SubmitExpense.Text = "Submit";
            SubmitExpense.UseVisualStyleBackColor = true;
            // 
            // SelectCategory
            // 
            SelectCategory.FormattingEnabled = true;
            SelectCategory.Location = new Point(650, 74);
            SelectCategory.Name = "SelectCategory";
            SelectCategory.Size = new Size(100, 23);
            SelectCategory.TabIndex = 12;
            SelectCategory.SelectedIndexChanged += SelectCategory_SelectedIndexChanged;
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataSource = typeof(Categories);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(SelectCategory);
            Controls.Add(SubmitExpense);
            Controls.Add(ExpenseBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SubmitEarnings);
            Controls.Add(EarningsBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SubmitNewCategory);
            Controls.Add(NewCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NewCategory;
        private Button SubmitNewCategory;
        private Label label3;
        private Label label4;
        private TextBox EarningsBox;
        private Button SubmitEarnings;
        private Label label5;
        private Label label6;
        private TextBox ExpenseBox;
        private Button SubmitExpense;
        private ComboBox SelectCategory;
        private BindingSource categoriesBindingSource;
    }
}