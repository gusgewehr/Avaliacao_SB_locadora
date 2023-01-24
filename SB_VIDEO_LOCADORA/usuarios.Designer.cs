namespace SB_VIDEO_LOCADORA
{
    partial class usuarios
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
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltar_btn
            // 
            this.voltar_btn.Location = new System.Drawing.Point(13, 381);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(129, 57);
            this.voltar_btn.TabIndex = 0;
            this.voltar_btn.Text = "Voltar";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(306, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(166, 42);
            this.head.TabIndex = 7;
            this.head.Text = "Usuários";
            // 
            // deletar_btn
            // 
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.Location = new System.Drawing.Point(389, 381);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 57);
            this.deletar_btn.TabIndex = 18;
            this.deletar_btn.Text = "Deletar";
            this.deletar_btn.UseVisualStyleBackColor = true;
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar_btn.Location = new System.Drawing.Point(524, 381);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(129, 57);
            this.atualizar_btn.TabIndex = 17;
            this.atualizar_btn.Text = "Atualizar";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(659, 381);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 16;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 55;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.atualizar_btn);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "usuarios";
            this.Text = "usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button gravar_btn;
        private System.Windows.Forms.Button button1;
    }
}