
namespace practice_autosellerscentre
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
            this.authButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(75, 86);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(150, 35);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(75, 127);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(150, 35);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(75, 27);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(150, 20);
            this.loginTB.TabIndex = 2;
            this.loginTB.Text = "Логин";
            this.loginTB.TextChanged += new System.EventHandler(this.loginTB_TextChanged);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(75, 54);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(150, 20);
            this.passTB.TabIndex = 3;
            this.passTB.Text = "Пароль";
            this.passTB.TextChanged += new System.EventHandler(this.passTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 187);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.authButton);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
    }
}

