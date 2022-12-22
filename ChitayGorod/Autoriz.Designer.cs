namespace ChitayGorod
{
    partial class Autoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoriz));
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReg = new System.Windows.Forms.Button();
            this.CapchaLabel = new System.Windows.Forms.Label();
            this.CapchaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(90, 200);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(90, 29);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(90, 134);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(76, 29);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(208, 134);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(154, 37);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(208, 197);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(154, 37);
            this.PassTextBox.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.buttonNext.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(176, 409);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(86, 38);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Вход";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 100);
            this.panel2.TabIndex = 6;
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.buttonReg.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(142, 453);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(153, 38);
            this.buttonReg.TabIndex = 7;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // CapchaLabel
            // 
            this.CapchaLabel.AutoSize = true;
            this.CapchaLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapchaLabel.Location = new System.Drawing.Point(182, 281);
            this.CapchaLabel.Name = "CapchaLabel";
            this.CapchaLabel.Size = new System.Drawing.Size(0, 29);
            this.CapchaLabel.TabIndex = 8;
            // 
            // CapchaTextBox
            // 
            this.CapchaTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapchaTextBox.Location = new System.Drawing.Point(141, 325);
            this.CapchaTextBox.Name = "CapchaTextBox";
            this.CapchaTextBox.Size = new System.Drawing.Size(154, 37);
            this.CapchaTextBox.TabIndex = 9;
            // 
            // Autoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(484, 622);
            this.Controls.Add(this.CapchaTextBox);
            this.Controls.Add(this.CapchaLabel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PassLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autoriz";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label CapchaLabel;
        private System.Windows.Forms.TextBox CapchaTextBox;
    }
}

