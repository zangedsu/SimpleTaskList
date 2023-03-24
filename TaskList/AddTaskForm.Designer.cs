namespace TaskList
{
    partial class AddTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TaskNameInput = new System.Windows.Forms.TextBox();
            this.AboutInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateFromInput = new System.Windows.Forms.DateTimePicker();
            this.DateToInput = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.InProcessInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название задачи:";
            // 
            // TaskNameInput
            // 
            this.TaskNameInput.Location = new System.Drawing.Point(12, 32);
            this.TaskNameInput.Name = "TaskNameInput";
            this.TaskNameInput.Size = new System.Drawing.Size(288, 23);
            this.TaskNameInput.TabIndex = 1;
            // 
            // AboutInput
            // 
            this.AboutInput.Location = new System.Drawing.Point(14, 87);
            this.AboutInput.Multiline = true;
            this.AboutInput.Name = "AboutInput";
            this.AboutInput.Size = new System.Drawing.Size(288, 178);
            this.AboutInput.TabIndex = 3;
            this.AboutInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание задачи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата начала:";
            // 
            // DateFromInput
            // 
            this.DateFromInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFromInput.Location = new System.Drawing.Point(327, 32);
            this.DateFromInput.Name = "DateFromInput";
            this.DateFromInput.Size = new System.Drawing.Size(200, 23);
            this.DateFromInput.TabIndex = 5;
            // 
            // DateToInput
            // 
            this.DateToInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToInput.Location = new System.Drawing.Point(327, 87);
            this.DateToInput.Name = "DateToInput";
            this.DateToInput.Size = new System.Drawing.Size(200, 23);
            this.DateToInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата сдачи:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Статус:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.DarkKhaki;
            this.ButtonSave.Location = new System.Drawing.Point(431, 228);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 37);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.CmdSave);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Coral;
            this.CloseBtn.Location = new System.Drawing.Point(327, 228);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(82, 37);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Отмена";
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // InProcessInput
            // 
            this.InProcessInput.FormattingEnabled = true;
            this.InProcessInput.Items.AddRange(new object[] {
            "В работе",
            "Не в работе",
            "Завершена",
            "Брифинг",
            "Передана",
            "Отказ",
            "Без статуса"});
            this.InProcessInput.Location = new System.Drawing.Point(327, 149);
            this.InProcessInput.Name = "InProcessInput";
            this.InProcessInput.Size = new System.Drawing.Size(200, 23);
            this.InProcessInput.TabIndex = 12;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.InProcessInput);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateToInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateFromInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AboutInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskNameInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTaskForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TaskNameInput;
        private TextBox AboutInput;
        private Label label2;
        private Label label3;
        private DateTimePicker DateFromInput;
        private DateTimePicker DateToInput;
        private Label label4;
        private Label label5;
        private Button ButtonSave;
        private Button CloseBtn;
        private ComboBox InProcessInput;
    }
}