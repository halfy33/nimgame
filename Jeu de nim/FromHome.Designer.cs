namespace Jeu_de_nim
{
    partial class FromHome
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
            btn_create = new Button();
            btn_join = new Button();
            label1 = new Label();
            txt_joinGame = new TextBox();
            btn_homeGo = new Button();
            SuspendLayout();
            // 
            // btn_create
            // 
            btn_create.Location = new Point(85, 133);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(165, 29);
            btn_create.TabIndex = 0;
            btn_create.Text = "Créer une partie";
            btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_join
            // 
            btn_join.Location = new Point(38, 185);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(93, 29);
            btn_join.TabIndex = 1;
            btn_join.Text = "Rejoindre : ";
            btn_join.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 100);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Accueil";
            // 
            // txt_joinGame
            // 
            txt_joinGame.Location = new Point(137, 186);
            txt_joinGame.Name = "txt_joinGame";
            txt_joinGame.Size = new Size(125, 27);
            txt_joinGame.TabIndex = 3;
            // 
            // btn_homeGo
            // 
            btn_homeGo.Location = new Point(268, 184);
            btn_homeGo.Name = "btn_homeGo";
            btn_homeGo.Size = new Size(44, 29);
            btn_homeGo.TabIndex = 4;
            btn_homeGo.Text = "GO! ";
            btn_homeGo.UseVisualStyleBackColor = true;
            // 
            // FromHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 317);
            Controls.Add(btn_homeGo);
            Controls.Add(txt_joinGame);
            Controls.Add(label1);
            Controls.Add(btn_join);
            Controls.Add(btn_create);
            Name = "FromHome";
            Text = "FromHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_create;
        private Button btn_join;
        private Label label1;
        private TextBox txt_joinGame;
        private Button btn_homeGo;
    }
}