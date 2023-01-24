namespace SB_VIDEO_LOCADORA
{
    partial class menu
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
            this.reservas_btn = new System.Windows.Forms.Button();
            this.clientes_btn = new System.Windows.Forms.Button();
            this.cadastrar_reservas_btn = new System.Windows.Forms.Button();
            this.filmes_btn = new System.Windows.Forms.Button();
            this.categorias_btn = new System.Windows.Forms.Button();
            this.usuarios_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservas_btn
            // 
            this.reservas_btn.Location = new System.Drawing.Point(13, 13);
            this.reservas_btn.Name = "reservas_btn";
            this.reservas_btn.Size = new System.Drawing.Size(775, 135);
            this.reservas_btn.TabIndex = 0;
            this.reservas_btn.Text = "Reservas";
            this.reservas_btn.UseVisualStyleBackColor = true;
            this.reservas_btn.Click += new System.EventHandler(this.reservas_btn_Click);
            // 
            // clientes_btn
            // 
            this.clientes_btn.Location = new System.Drawing.Point(537, 154);
            this.clientes_btn.Name = "clientes_btn";
            this.clientes_btn.Size = new System.Drawing.Size(251, 135);
            this.clientes_btn.TabIndex = 7;
            this.clientes_btn.Text = "Clientes";
            this.clientes_btn.UseVisualStyleBackColor = true;
            this.clientes_btn.Click += new System.EventHandler(this.clientes_btn_Click);
            // 
            // cadastrar_reservas_btn
            // 
            this.cadastrar_reservas_btn.Location = new System.Drawing.Point(13, 154);
            this.cadastrar_reservas_btn.Name = "cadastrar_reservas_btn";
            this.cadastrar_reservas_btn.Size = new System.Drawing.Size(251, 135);
            this.cadastrar_reservas_btn.TabIndex = 8;
            this.cadastrar_reservas_btn.Text = "Cadastrar Reservas";
            this.cadastrar_reservas_btn.UseVisualStyleBackColor = true;
            this.cadastrar_reservas_btn.Click += new System.EventHandler(this.cadastrar_reservas_btn_Click);
            // 
            // filmes_btn
            // 
            this.filmes_btn.Location = new System.Drawing.Point(270, 154);
            this.filmes_btn.Name = "filmes_btn";
            this.filmes_btn.Size = new System.Drawing.Size(261, 135);
            this.filmes_btn.TabIndex = 9;
            this.filmes_btn.Text = "Filmes";
            this.filmes_btn.UseVisualStyleBackColor = true;
            this.filmes_btn.Click += new System.EventHandler(this.filmes_btn_Click);
            // 
            // categorias_btn
            // 
            this.categorias_btn.Location = new System.Drawing.Point(13, 295);
            this.categorias_btn.Name = "categorias_btn";
            this.categorias_btn.Size = new System.Drawing.Size(251, 135);
            this.categorias_btn.TabIndex = 10;
            this.categorias_btn.Text = "Categorias";
            this.categorias_btn.UseVisualStyleBackColor = true;
            this.categorias_btn.Click += new System.EventHandler(this.categorias_btn_Click);
            // 
            // usuarios_btn
            // 
            this.usuarios_btn.Location = new System.Drawing.Point(537, 295);
            this.usuarios_btn.Name = "usuarios_btn";
            this.usuarios_btn.Size = new System.Drawing.Size(251, 135);
            this.usuarios_btn.TabIndex = 11;
            this.usuarios_btn.Text = "Usuários";
            this.usuarios_btn.UseVisualStyleBackColor = true;
            this.usuarios_btn.Click += new System.EventHandler(this.usuarios_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(359, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 54;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuarios_btn);
            this.Controls.Add(this.categorias_btn);
            this.Controls.Add(this.filmes_btn);
            this.Controls.Add(this.cadastrar_reservas_btn);
            this.Controls.Add(this.clientes_btn);
            this.Controls.Add(this.reservas_btn);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservas_btn;
        private System.Windows.Forms.Button clientes_btn;
        private System.Windows.Forms.Button cadastrar_reservas_btn;
        private System.Windows.Forms.Button filmes_btn;
        private System.Windows.Forms.Button categorias_btn;
        private System.Windows.Forms.Button usuarios_btn;
        private System.Windows.Forms.Button button1;
    }
}