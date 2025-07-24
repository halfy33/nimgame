namespace Jeu_de_nim
{
    partial class FormConnexion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_LoginConnexion = new TextBox();
            txt_PasswordConnexion = new TextBox();
            btn_Connexion = new Button();
            btn_register1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 84);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Connexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Login : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 212);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Password : ";
            // 
            // txt_LoginConnexion
            // 
            txt_LoginConnexion.Location = new Point(123, 142);
            txt_LoginConnexion.Name = "txt_LoginConnexion";
            txt_LoginConnexion.Size = new Size(185, 27);
            txt_LoginConnexion.TabIndex = 3;
            // 
            // txt_PasswordConnexion
            // 
            txt_PasswordConnexion.Location = new Point(125, 209);
            txt_PasswordConnexion.Name = "txt_PasswordConnexion";
            txt_PasswordConnexion.Size = new Size(183, 27);
            txt_PasswordConnexion.TabIndex = 4;
            // 
            // btn_Connexion
            // 
            btn_Connexion.Location = new Point(157, 271);
            btn_Connexion.Name = "btn_Connexion";
            btn_Connexion.Size = new Size(111, 29);
            btn_Connexion.TabIndex = 5;
            btn_Connexion.Text = "Se connecter";
            btn_Connexion.UseVisualStyleBackColor = true;
            btn_Connexion.Click += btn_Connexion_Click;
            // 
            // btn_register1
            // 
            btn_register1.Location = new Point(157, 321);
            btn_register1.Name = "btn_register1";
            btn_register1.Size = new Size(111, 29);
            btn_register1.TabIndex = 6;
            btn_register1.Text = "S'inscrire";
            btn_register1.UseVisualStyleBackColor = true;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 450);
            Controls.Add(btn_register1);
            Controls.Add(btn_Connexion);
            Controls.Add(txt_PasswordConnexion);
            Controls.Add(txt_LoginConnexion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConnexion";
            Text = "FormConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_LoginConnexion;
        private TextBox txt_PasswordConnexion;
        private Button btn_Connexion;
        private Button btn_register1;
    }
}