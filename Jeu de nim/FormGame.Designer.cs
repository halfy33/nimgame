namespace Jeu_de_nim
{
    partial class FormGame
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
            lbl_batonTotal = new Label();
            label4 = new Label();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            label5 = new Label();
            lbl_tourjoueur = new Label();
            label7 = new Label();
            lbl_time = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Jeu de NIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 87);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Baton total : ";
            // 
            // lbl_batonTotal
            // 
            lbl_batonTotal.AutoSize = true;
            lbl_batonTotal.Font = new Font("Segoe UI", 16F);
            lbl_batonTotal.Location = new Point(256, 76);
            lbl_batonTotal.Name = "lbl_batonTotal";
            lbl_batonTotal.Size = new Size(37, 30);
            lbl_batonTotal.TabIndex = 2;
            lbl_batonTotal.Text = "21";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 124);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Baton retiré :";
            // 
            // btn_1
            // 
            btn_1.Location = new Point(247, 121);
            btn_1.Margin = new Padding(3, 2, 3, 2);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(30, 22);
            btn_1.TabIndex = 4;
            btn_1.Text = "-1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(282, 121);
            btn_2.Margin = new Padding(3, 2, 3, 2);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(28, 22);
            btn_2.TabIndex = 5;
            btn_2.Text = "-2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(315, 121);
            btn_3.Margin = new Padding(3, 2, 3, 2);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(28, 22);
            btn_3.TabIndex = 6;
            btn_3.Text = "-3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 32);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 7;
            label5.Text = "Tour du joueur : ";
            // 
            // lbl_tourjoueur
            // 
            lbl_tourjoueur.AutoSize = true;
            lbl_tourjoueur.Location = new Point(493, 31);
            lbl_tourjoueur.Name = "lbl_tourjoueur";
            lbl_tourjoueur.Size = new Size(24, 15);
            lbl_tourjoueur.TabIndex = 8;
            lbl_tourjoueur.Text = "1/2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(389, 87);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 9;
            label7.Text = "Temps restant :";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(491, 86);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(28, 15);
            lbl_time.TabIndex = 10;
            lbl_time.Text = "1:30";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 119);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 11;
            label3.Text = "Temps joueur:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 119);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 119);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 13;
            label8.Text = "label8";
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 226);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lbl_time);
            Controls.Add(label7);
            Controls.Add(lbl_tourjoueur);
            Controls.Add(label5);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(label4);
            Controls.Add(lbl_batonTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGame";
            Text = "FormGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_batonTotal;
        private Label label4;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Label label5;
        private Label lbl_tourjoueur;
        private Label label7;
        private Label lbl_time;
        private Label label3;
        private Label label6;
        private Label label8;


    }
}