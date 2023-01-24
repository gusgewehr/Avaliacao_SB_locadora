namespace SB_VIDEO_LOCADORA
{
    partial class cadastrar_se
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label enderecoLabel;
            this.gravar_btn = new System.Windows.Forms.Button();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.head = new System.Windows.Forms.Label();
            this.voltar_btn = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(655, 387);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 45;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FilmesReservaTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bd_locadoraDataSet;
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(449, 178);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(162, 26);
            this.bairroTextBox.TabIndex = 37;
            this.bairroTextBox.TextChanged += new System.EventHandler(this.bairroTextBox_TextChanged);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(445, 103);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 32;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(449, 126);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(335, 26);
            this.telefoneTextBox.TabIndex = 33;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(16, 103);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(44, 20);
            cPFLabel.TabIndex = 27;
            cPFLabel.Text = "CPF:";
            cPFLabel.Click += new System.EventHandler(this.cPFLabel_Click);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFTextBox.Location = new System.Drawing.Point(20, 126);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(423, 26);
            this.cPFTextBox.TabIndex = 29;
            this.cPFTextBox.TextChanged += new System.EventHandler(this.cPFTextBox_TextChanged);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(16, 51);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 26;
            nomeLabel.Text = "Nome:";
            nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(274, 5);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(222, 42);
            this.head.TabIndex = 25;
            this.head.Text = "Cadastre-se";
            this.head.Click += new System.EventHandler(this.head_Click);
            // 
            // voltar_btn
            // 
            this.voltar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar_btn.Location = new System.Drawing.Point(20, 387);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(129, 57);
            this.voltar_btn.TabIndex = 24;
            this.voltar_btn.Text = "Voltar";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(445, 207);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(60, 20);
            senhaLabel.TabIndex = 42;
            senhaLabel.Text = "Senha:";
            senhaLabel.Click += new System.EventHandler(this.senhaLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(16, 207);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 40;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(20, 230);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(423, 26);
            this.emailTextBox.TabIndex = 41;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(613, 155);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 38;
            cidadeLabel.Text = "Cidade:";
            cidadeLabel.Click += new System.EventHandler(this.cidadeLabel_Click);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.Location = new System.Drawing.Point(617, 178);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(167, 26);
            this.cidadeTextBox.TabIndex = 39;
            this.cidadeTextBox.TextChanged += new System.EventHandler(this.cidadeTextBox_TextChanged);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(449, 230);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(335, 26);
            this.senhaTextBox.TabIndex = 43;
            this.senhaTextBox.TextChanged += new System.EventHandler(this.senhaTextBox_TextChanged);
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.Location = new System.Drawing.Point(445, 155);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 20);
            bairroLabel.TabIndex = 36;
            bairroLabel.Text = "Bairro:";
            bairroLabel.Click += new System.EventHandler(this.bairroLabel_Click);
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(16, 155);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(82, 20);
            enderecoLabel.TabIndex = 34;
            enderecoLabel.Text = "Endereco:";
            enderecoLabel.Click += new System.EventHandler(this.enderecoLabel_Click);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(20, 178);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(423, 26);
            this.enderecoTextBox.TabIndex = 35;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.enderecoTextBox_TextChanged);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(20, 74);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(764, 26);
            this.nomeTextBox.TabIndex = 28;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // cadastrar_se
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Name = "cadastrar_se";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gravar_btn;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bd_locadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}