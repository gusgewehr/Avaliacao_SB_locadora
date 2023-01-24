namespace SB_VIDEO_LOCADORA
{
    partial class login
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.entrar_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(172, 165);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(462, 26);
            this.txt_user.TabIndex = 0;
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(172, 269);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(462, 26);
            this.pass_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // entrar_btn
            // 
            this.entrar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar_btn.Location = new System.Drawing.Point(318, 345);
            this.entrar_btn.Name = "entrar_btn";
            this.entrar_btn.Size = new System.Drawing.Size(141, 72);
            this.entrar_btn.TabIndex = 4;
            this.entrar_btn.Text = "Entrar";
            this.entrar_btn.UseVisualStyleBackColor = true;
            this.entrar_btn.Click += new System.EventHandler(this.entrar_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vídeo Locadora SB Filmes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadastrar-se";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entrar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.txt_user);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrar_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}