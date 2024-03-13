namespace Computer_club_program
{
    partial class Enter
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
            this.authbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authbutton
            // 
            this.authbutton.Location = new System.Drawing.Point(337, 324);
            this.authbutton.Name = "authbutton";
            this.authbutton.Size = new System.Drawing.Size(75, 23);
            this.authbutton.TabIndex = 0;
            this.authbutton.Text = "Enter";
            this.authbutton.UseVisualStyleBackColor = true;
            this.authbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authbutton);
            this.Name = "Enter";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authbutton;
    }
}

