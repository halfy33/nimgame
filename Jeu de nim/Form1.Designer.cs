namespace Jeu_de_nim
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
            btn_Register = new Button();
            txt_nameRegister = new TextBox();
            txt_SurnameRegister = new TextBox();
            txt_MailRegister = new TextBox();
            txt_LoginRegister = new TextBox();
            txt_PassRegister = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(157, 371);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(94, 29);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "S'inscrire";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // txt_nameRegister
            // 
            txt_nameRegister.Location = new Point(139, 96);
            txt_nameRegister.Name = "txt_nameRegister";
            txt_nameRegister.Size = new Size(125, 27);
            txt_nameRegister.TabIndex = 1;
            // 
            // txt_SurnameRegister
            // 
            txt_SurnameRegister.Location = new Point(139, 148);
            txt_SurnameRegister.Name = "txt_SurnameRegister";
            txt_SurnameRegister.Size = new Size(125, 27);
            txt_SurnameRegister.TabIndex = 2;
            // 
            // txt_MailRegister
            // 
            txt_MailRegister.Location = new Point(139, 202);
            txt_MailRegister.Name = "txt_MailRegister";
            txt_MailRegister.Size = new Size(125, 27);
            txt_MailRegister.TabIndex = 3;
            // 
            // txt_LoginRegister
            // 
            txt_LoginRegister.Location = new Point(139, 257);
            txt_LoginRegister.Name = "txt_LoginRegister";
            txt_LoginRegister.Size = new Size(125, 27);
            txt_LoginRegister.TabIndex = 4;
            // 
            // txt_PassRegister
            // 
            txt_PassRegister.Location = new Point(139, 318);
            txt_PassRegister.Name = "txt_PassRegister";
            txt_PassRegister.Size = new Size(125, 27);
            txt_PassRegister.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Inscription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Nom : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 155);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "Prénom : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 206);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Email : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 260);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Login :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 325);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 11;
            label6.Text = "Password : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_PassRegister);
            Controls.Add(txt_LoginRegister);
            Controls.Add(txt_MailRegister);
            Controls.Add(txt_SurnameRegister);
            Controls.Add(txt_nameRegister);
            Controls.Add(btn_Register);
            Name = "Form1";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register;
        private TextBox txt_nameRegister;
        private TextBox txt_SurnameRegister;
        private TextBox txt_MailRegister;
        private TextBox txt_LoginRegister;
        private TextBox txt_PassRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
