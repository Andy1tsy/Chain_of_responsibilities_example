using static ChainOfResponsibilitiesWorkers.Program;
namespace ChainOfResponsibilitiesWorkers
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.checkBoxSalary = new System.Windows.Forms.CheckBox();
            this.checkBoxPosition = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinSalary = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPositionSelect = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listBoxBase = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAge.Location = new System.Drawing.Point(43, 58);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(186, 33);
            this.checkBoxAge.TabIndex = 0;
            this.checkBoxAge.Text = "По возрасту :";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalary
            // 
            this.checkBoxSalary.AutoSize = true;
            this.checkBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSalary.Location = new System.Drawing.Point(43, 110);
            this.checkBoxSalary.Name = "checkBoxSalary";
            this.checkBoxSalary.Size = new System.Drawing.Size(193, 33);
            this.checkBoxSalary.TabIndex = 1;
            this.checkBoxSalary.Text = "По зарплате :";
            this.checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxPosition
            // 
            this.checkBoxPosition.AutoSize = true;
            this.checkBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPosition.Location = new System.Drawing.Point(43, 164);
            this.checkBoxPosition.Name = "checkBoxPosition";
            this.checkBoxPosition.Size = new System.Drawing.Size(207, 33);
            this.checkBoxPosition.TabIndex = 2;
            this.checkBoxPosition.Text = "По должности:";
            this.checkBoxPosition.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(33, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(708, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Выбор приносимых в жертву Ктулху  для повышения урожайности";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinAge.Location = new System.Drawing.Point(351, 68);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownMinAge.TabIndex = 4;
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(608, 68);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownMaxAge.TabIndex = 5;
            this.numericUpDownMaxAge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMinSalary
            // 
            this.numericUpDownMinSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMinSalary.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinSalary.Location = new System.Drawing.Point(351, 119);
            this.numericUpDownMinSalary.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinSalary.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMinSalary.Name = "numericUpDownMinSalary";
            this.numericUpDownMinSalary.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownMinSalary.TabIndex = 6;
            this.numericUpDownMinSalary.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSalary
            // 
            this.numericUpDownMaxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxSalary.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxSalary.Location = new System.Drawing.Point(608, 119);
            this.numericUpDownMaxSalary.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSalary.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSalary.Name = "numericUpDownMaxSalary";
            this.numericUpDownMaxSalary.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownMaxSalary.TabIndex = 7;
            this.numericUpDownMaxSalary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // comboBoxPositionSelect
            // 
            this.comboBoxPositionSelect.AllowDrop = true;
            this.comboBoxPositionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPositionSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPositionSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPositionSelect.FormattingEnabled = true;
            this.comboBoxPositionSelect.Items.AddRange(new string[] {
            "Крестьянин",
            "Доярка",
            "Тракторист",
            "Комбайнер",
            "Бригадир",
            "Агроном",
            "Председатель"});
            this.comboBoxPositionSelect.Location = new System.Drawing.Point(367, 174);
            this.comboBoxPositionSelect.Name = "comboBoxPositionSelect";
            this.comboBoxPositionSelect.Size = new System.Drawing.Size(243, 28);
            this.comboBoxPositionSelect.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(274, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(56, 30);
            this.textBox2.TabIndex = 11;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "От";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(274, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 30);
            this.textBox3.TabIndex = 12;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "От";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(250, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(95, 30);
            this.textBox4.TabIndex = 13;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Выбрать";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(532, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(63, 30);
            this.textBox5.TabIndex = 14;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "До";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(532, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(62, 30);
            this.textBox6.TabIndex = 15;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "До";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBase
            // 
            this.textBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBase.Location = new System.Drawing.Point(23, 242);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.ReadOnly = true;
            this.textBoxBase.Size = new System.Drawing.Size(245, 34);
            this.textBoxBase.TabIndex = 16;
            this.textBoxBase.TabStop = false;
            this.textBoxBase.Text = "Все работники :";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(532, 242);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(218, 34);
            this.textBoxResult.TabIndex = 17;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.Text = "Избранные :";
            // 
            // buttonAction
            // 
            this.buttonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAction.Location = new System.Drawing.Point(789, 58);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(155, 165);
            this.buttonAction.TabIndex = 18;
            this.buttonAction.Text = "Избрать!";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(-3, 486);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(1255, 28);
            this.textBox7.TabIndex = 19;
            // 
            // listBoxBase
            // 
            this.listBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBase.FormattingEnabled = true;
            this.listBoxBase.ItemHeight = 20;
            this.listBoxBase.Location = new System.Drawing.Point(-3, 293);
            this.listBoxBase.Name = "listBoxBase";
            this.listBoxBase.Size = new System.Drawing.Size(618, 184);
            this.listBoxBase.TabIndex = 20;
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(621, 293);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(624, 184);
            this.listBoxResult.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 514);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxBase);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxPositionSelect);
            this.Controls.Add(this.numericUpDownMaxSalary);
            this.Controls.Add(this.numericUpDownMinSalary);
            this.Controls.Add(this.numericUpDownMaxAge);
            this.Controls.Add(this.numericUpDownMinAge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxPosition);
            this.Controls.Add(this.checkBoxSalary);
            this.Controls.Add(this.checkBoxAge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Колхоз им. 5000-летия Ктулху";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBoxAge;
        public System.Windows.Forms.CheckBox checkBoxSalary;
        public System.Windows.Forms.CheckBox checkBoxPosition;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        public System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        public System.Windows.Forms.NumericUpDown numericUpDownMinSalary;
        public System.Windows.Forms.NumericUpDown numericUpDownMaxSalary;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBoxBase;
        public System.Windows.Forms.TextBox textBoxResult;
        public System.Windows.Forms.Button buttonAction;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.ComboBox comboBoxPositionSelect;
        public System.Windows.Forms.ListBox listBoxBase;
        public System.Windows.Forms.ListBox listBoxResult;
    }
}

