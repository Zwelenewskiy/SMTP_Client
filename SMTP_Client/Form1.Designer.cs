namespace SMTP_Client
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
            this.B_send = new System.Windows.Forms.Button();
            this.TB_host = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.L_host = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_message = new System.Windows.Forms.TextBox();
            this.TB_recepient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_send
            // 
            this.B_send.Location = new System.Drawing.Point(12, 349);
            this.B_send.Name = "B_send";
            this.B_send.Size = new System.Drawing.Size(75, 23);
            this.B_send.TabIndex = 0;
            this.B_send.Text = "Send";
            this.B_send.UseVisualStyleBackColor = true;
            this.B_send.Click += new System.EventHandler(this.B_send_Click);
            // 
            // TB_host
            // 
            this.TB_host.Location = new System.Drawing.Point(12, 25);
            this.TB_host.Name = "TB_host";
            this.TB_host.Size = new System.Drawing.Size(100, 20);
            this.TB_host.TabIndex = 1;
            this.TB_host.Text = "mail.oreluniver.ru";
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(118, 82);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(100, 20);
            this.TB_pass.TabIndex = 2;
            this.TB_pass.Text = "Cio01p";
            // 
            // TB_login
            // 
            this.TB_login.Location = new System.Drawing.Point(12, 82);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(100, 20);
            this.TB_login.TabIndex = 3;
            this.TB_login.Text = "Cio01@ostu.ru";
            // 
            // L_host
            // 
            this.L_host.AutoSize = true;
            this.L_host.Location = new System.Drawing.Point(12, 9);
            this.L_host.Name = "L_host";
            this.L_host.Size = new System.Drawing.Size(37, 13);
            this.L_host.TabIndex = 4;
            this.L_host.Text = "HOST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // TB_message
            // 
            this.TB_message.Location = new System.Drawing.Point(12, 108);
            this.TB_message.Multiline = true;
            this.TB_message.Name = "TB_message";
            this.TB_message.Size = new System.Drawing.Size(390, 235);
            this.TB_message.TabIndex = 7;
            // 
            // TB_recepient
            // 
            this.TB_recepient.Location = new System.Drawing.Point(224, 82);
            this.TB_recepient.Name = "TB_recepient";
            this.TB_recepient.Size = new System.Drawing.Size(100, 20);
            this.TB_recepient.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recepient";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_recepient);
            this.Controls.Add(this.TB_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_host);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_host);
            this.Controls.Add(this.B_send);
            this.Name = "Form1";
            this.Text = "SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_send;
        private System.Windows.Forms.TextBox TB_host;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.Label L_host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_message;
        private System.Windows.Forms.TextBox TB_recepient;
        private System.Windows.Forms.Label label1;
    }
}

