namespace Second_Project___Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chickenRadioButton1 = new System.Windows.Forms.RadioButton();
            this.eggRadioButton2 = new System.Windows.Forms.RadioButton();
            this.MenuGroupBox1 = new System.Windows.Forms.GroupBox();
            this.drinksComboBox1 = new System.Windows.Forms.ComboBox();
            this.eggTextBox2 = new System.Windows.Forms.TextBox();
            this.chickenTextBox1 = new System.Windows.Forms.TextBox();
            this.receiveRequestButton1 = new System.Windows.Forms.Button();
            this.sendCustomerRequestButton2 = new System.Windows.Forms.Button();
            this.servePreparedFoodButton3 = new System.Windows.Forms.Button();
            this.eggQualityLabel1 = new System.Windows.Forms.Label();
            this.eggQualityLabel2 = new System.Windows.Forms.Label();
            this.resultListBox1 = new System.Windows.Forms.ListBox();
            this.resultLabel1 = new System.Windows.Forms.Label();
            this.MenuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chickenRadioButton1
            // 
            this.chickenRadioButton1.AutoSize = true;
            this.chickenRadioButton1.Location = new System.Drawing.Point(22, 37);
            this.chickenRadioButton1.Name = "chickenRadioButton1";
            this.chickenRadioButton1.Size = new System.Drawing.Size(147, 20);
            this.chickenRadioButton1.TabIndex = 1;
            this.chickenRadioButton1.TabStop = true;
            this.chickenRadioButton1.Text = "How many chicken?";
            this.chickenRadioButton1.UseVisualStyleBackColor = true;
            this.chickenRadioButton1.CheckedChanged += new System.EventHandler(this.chickenRadioButton1_CheckedChanged);
            // 
            // eggRadioButton2
            // 
            this.eggRadioButton2.AutoSize = true;
            this.eggRadioButton2.Location = new System.Drawing.Point(22, 75);
            this.eggRadioButton2.Name = "eggRadioButton2";
            this.eggRadioButton2.Size = new System.Drawing.Size(128, 20);
            this.eggRadioButton2.TabIndex = 2;
            this.eggRadioButton2.TabStop = true;
            this.eggRadioButton2.Text = "How many egg ?";
            this.eggRadioButton2.UseVisualStyleBackColor = true;
            this.eggRadioButton2.CheckedChanged += new System.EventHandler(this.eggRadioButton2_CheckedChanged);
            // 
            // MenuGroupBox1
            // 
            this.MenuGroupBox1.Controls.Add(this.drinksComboBox1);
            this.MenuGroupBox1.Controls.Add(this.eggTextBox2);
            this.MenuGroupBox1.Controls.Add(this.chickenTextBox1);
            this.MenuGroupBox1.Controls.Add(this.receiveRequestButton1);
            this.MenuGroupBox1.Controls.Add(this.eggRadioButton2);
            this.MenuGroupBox1.Controls.Add(this.chickenRadioButton1);
            this.MenuGroupBox1.Location = new System.Drawing.Point(43, 41);
            this.MenuGroupBox1.Name = "MenuGroupBox1";
            this.MenuGroupBox1.Size = new System.Drawing.Size(535, 185);
            this.MenuGroupBox1.TabIndex = 3;
            this.MenuGroupBox1.TabStop = false;
            this.MenuGroupBox1.Text = "Menu";
            // 
            // drinksComboBox1
            // 
            this.drinksComboBox1.FormattingEnabled = true;
            this.drinksComboBox1.Location = new System.Drawing.Point(242, 57);
            this.drinksComboBox1.Name = "drinksComboBox1";
            this.drinksComboBox1.Size = new System.Drawing.Size(271, 24);
            this.drinksComboBox1.TabIndex = 6;
            // 
            // eggTextBox2
            // 
            this.eggTextBox2.Location = new System.Drawing.Point(192, 76);
            this.eggTextBox2.Name = "eggTextBox2";
            this.eggTextBox2.Size = new System.Drawing.Size(30, 22);
            this.eggTextBox2.TabIndex = 5;
            // 
            // chickenTextBox1
            // 
            this.chickenTextBox1.Location = new System.Drawing.Point(192, 37);
            this.chickenTextBox1.Name = "chickenTextBox1";
            this.chickenTextBox1.Size = new System.Drawing.Size(30, 22);
            this.chickenTextBox1.TabIndex = 4;
            // 
            // receiveRequestButton1
            // 
            this.receiveRequestButton1.Location = new System.Drawing.Point(58, 141);
            this.receiveRequestButton1.Name = "receiveRequestButton1";
            this.receiveRequestButton1.Size = new System.Drawing.Size(406, 27);
            this.receiveRequestButton1.TabIndex = 3;
            this.receiveRequestButton1.Text = "Receive this request from a Customer";
            this.receiveRequestButton1.UseVisualStyleBackColor = true;
            this.receiveRequestButton1.Click += new System.EventHandler(this.receiveRequestButton1_Click);
            // 
            // sendCustomerRequestButton2
            // 
            this.sendCustomerRequestButton2.Location = new System.Drawing.Point(101, 245);
            this.sendCustomerRequestButton2.Name = "sendCustomerRequestButton2";
            this.sendCustomerRequestButton2.Size = new System.Drawing.Size(406, 29);
            this.sendCustomerRequestButton2.TabIndex = 4;
            this.sendCustomerRequestButton2.Text = "Send all Customers requests to the Cook";
            this.sendCustomerRequestButton2.UseVisualStyleBackColor = true;
            this.sendCustomerRequestButton2.Click += new System.EventHandler(this.sendCustomerRequestButton2_Click);
            // 
            // servePreparedFoodButton3
            // 
            this.servePreparedFoodButton3.Location = new System.Drawing.Point(101, 346);
            this.servePreparedFoodButton3.Name = "servePreparedFoodButton3";
            this.servePreparedFoodButton3.Size = new System.Drawing.Size(406, 27);
            this.servePreparedFoodButton3.TabIndex = 5;
            this.servePreparedFoodButton3.Text = "Serve prepared food to the Customer";
            this.servePreparedFoodButton3.UseVisualStyleBackColor = true;
            this.servePreparedFoodButton3.Click += new System.EventHandler(this.servePreparedFoodButton3_Click);
            // 
            // eggQualityLabel1
            // 
            this.eggQualityLabel1.AutoSize = true;
            this.eggQualityLabel1.Location = new System.Drawing.Point(79, 303);
            this.eggQualityLabel1.Name = "eggQualityLabel1";
            this.eggQualityLabel1.Size = new System.Drawing.Size(79, 16);
            this.eggQualityLabel1.TabIndex = 6;
            this.eggQualityLabel1.Text = "Egg Quality:";
            // 
            // eggQualityLabel2
            // 
            this.eggQualityLabel2.AutoSize = true;
            this.eggQualityLabel2.Location = new System.Drawing.Point(172, 303);
            this.eggQualityLabel2.Name = "eggQualityLabel2";
            this.eggQualityLabel2.Size = new System.Drawing.Size(63, 16);
            this.eggQualityLabel2.TabIndex = 7;
            this.eggQualityLabel2.Text = "________";
            // 
            // resultListBox1
            // 
            this.resultListBox1.FormattingEnabled = true;
            this.resultListBox1.ItemHeight = 16;
            this.resultListBox1.Location = new System.Drawing.Point(43, 403);
            this.resultListBox1.Name = "resultListBox1";
            this.resultListBox1.Size = new System.Drawing.Size(535, 100);
            this.resultListBox1.TabIndex = 8;
            this.resultListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // resultLabel1
            // 
            this.resultLabel1.AutoSize = true;
            this.resultLabel1.Location = new System.Drawing.Point(40, 383);
            this.resultLabel1.Name = "resultLabel1";
            this.resultLabel1.Size = new System.Drawing.Size(45, 16);
            this.resultLabel1.TabIndex = 9;
            this.resultLabel1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 515);
            this.Controls.Add(this.resultLabel1);
            this.Controls.Add(this.resultListBox1);
            this.Controls.Add(this.eggQualityLabel2);
            this.Controls.Add(this.eggQualityLabel1);
            this.Controls.Add(this.servePreparedFoodButton3);
            this.Controls.Add(this.sendCustomerRequestButton2);
            this.Controls.Add(this.MenuGroupBox1);
            this.Name = "Form1";
            this.Text = "Петушок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuGroupBox1.ResumeLayout(false);
            this.MenuGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton chickenRadioButton1;
        private System.Windows.Forms.RadioButton eggRadioButton2;
        private System.Windows.Forms.GroupBox MenuGroupBox1;
        private System.Windows.Forms.Button receiveRequestButton1;
        private System.Windows.Forms.Button sendCustomerRequestButton2;
        private System.Windows.Forms.Button servePreparedFoodButton3;
        private System.Windows.Forms.TextBox eggTextBox2;
        private System.Windows.Forms.TextBox chickenTextBox1;
        private System.Windows.Forms.Label eggQualityLabel1;
        private System.Windows.Forms.Label eggQualityLabel2;
        private System.Windows.Forms.ListBox resultListBox1;
        private System.Windows.Forms.Label resultLabel1;
        private System.Windows.Forms.ComboBox drinksComboBox1;
    }
}

