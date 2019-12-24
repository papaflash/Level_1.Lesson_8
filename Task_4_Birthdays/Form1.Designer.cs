namespace Task_4_Birthdays
{
    partial class frmBirthdays
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
            this.dtPickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.tBoxUsers = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPickerBirthday
            // 
            this.dtPickerBirthday.CustomFormat = "dd MMMM";
            this.dtPickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerBirthday.Location = new System.Drawing.Point(286, 60);
            this.dtPickerBirthday.Name = "dtPickerBirthday";
            this.dtPickerBirthday.Size = new System.Drawing.Size(128, 20);
            this.dtPickerBirthday.TabIndex = 0;
            this.dtPickerBirthday.ValueChanged += new System.EventHandler(this.dtPickerBirthday_ValueChanged);
            // 
            // tBoxUsers
            // 
            this.tBoxUsers.Location = new System.Drawing.Point(12, 60);
            this.tBoxUsers.Name = "tBoxUsers";
            this.tBoxUsers.Size = new System.Drawing.Size(268, 20);
            this.tBoxUsers.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 131);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Показать Д.Р.";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 166);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tBoxUsers);
            this.Controls.Add(this.dtPickerBirthday);
            this.Name = "frmBirthdays";
            this.Text = "Записная по Д.Р.";
            this.Load += new System.EventHandler(this.frmBirthdays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPickerBirthday;
        private System.Windows.Forms.TextBox tBoxUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
    }
}

