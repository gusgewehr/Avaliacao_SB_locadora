namespace SB_VIDEO_LOCADORA
{
    partial class clientes
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label senhaLabel;
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.codigoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(9, 105);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome:";
            nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(261, 52);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(44, 20);
            cPFLabel.TabIndex = 10;
            cPFLabel.Text = "CPF:";
            cPFLabel.Click += new System.EventHandler(this.cPFLabel_Click);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(9, 53);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 11;
            codigoLabel.Text = "Codigo:";
            codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(541, 53);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 12;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(12, 157);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(82, 20);
            enderecoLabel.TabIndex = 13;
            enderecoLabel.Text = "Endereco:";
            enderecoLabel.Click += new System.EventHandler(this.enderecoLabel_Click);
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.Location = new System.Drawing.Point(437, 157);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(55, 20);
            bairroLabel.TabIndex = 14;
            bairroLabel.Text = "Bairro:";
            bairroLabel.Click += new System.EventHandler(this.bairroLabel_Click);
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(605, 157);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 15;
            cidadeLabel.Text = "Cidade:";
            cidadeLabel.Click += new System.EventHandler(this.cidadeLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(8, 209);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.Location = new System.Drawing.Point(437, 209);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(60, 20);
            senhaLabel.TabIndex = 18;
            senhaLabel.Text = "Senha:";
            senhaLabel.Click += new System.EventHandler(this.senhaLabel_Click);
            // 
            // voltar_btn
            // 
            this.voltar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar_btn.Location = new System.Drawing.Point(12, 389);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(129, 57);
            this.voltar_btn.TabIndex = 1;
            this.voltar_btn.Text = "Voltar";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(319, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(153, 42);
            this.head.TabIndex = 7;
            this.head.Text = "Clientes";
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bd_locadoraDataSet;
            this.clienteBindingSource.CurrentChanged += new System.EventHandler(this.clienteBindingSource_CurrentChanged);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FilmesReservaTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 128);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(764, 26);
            this.nomeTextBox.TabIndex = 10;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFTextBox.Location = new System.Drawing.Point(264, 76);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(275, 26);
            this.cPFTextBox.TabIndex = 11;
            this.cPFTextBox.TextChanged += new System.EventHandler(this.cPFTextBox_TextChanged);
            // 
            // codigoNumericUpDown
            // 
            this.codigoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Codigo", true));
            this.codigoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoNumericUpDown.Location = new System.Drawing.Point(13, 76);
            this.codigoNumericUpDown.Name = "codigoNumericUpDown";
            this.codigoNumericUpDown.Size = new System.Drawing.Size(245, 26);
            this.codigoNumericUpDown.TabIndex = 12;
            this.codigoNumericUpDown.ValueChanged += new System.EventHandler(this.codigoNumericUpDown_ValueChanged);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(545, 76);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(231, 26);
            this.telefoneTextBox.TabIndex = 13;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(12, 180);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(423, 26);
            this.enderecoTextBox.TabIndex = 14;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.enderecoTextBox_TextChanged);
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTextBox.Location = new System.Drawing.Point(441, 180);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(162, 26);
            this.bairroTextBox.TabIndex = 15;
            this.bairroTextBox.TextChanged += new System.EventHandler(this.bairroTextBox_TextChanged);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTextBox.Location = new System.Drawing.Point(609, 180);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(167, 26);
            this.cidadeTextBox.TabIndex = 16;
            this.cidadeTextBox.TextChanged += new System.EventHandler(this.cidadeTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(12, 232);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(423, 26);
            this.emailTextBox.TabIndex = 17;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(441, 232);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(335, 26);
            this.senhaTextBox.TabIndex = 19;
            this.senhaTextBox.TextChanged += new System.EventHandler(this.senhaTextBox_TextChanged);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 264);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(764, 119);
            this.clienteDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn3.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Senha";
            this.dataGridViewTextBoxColumn9.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // deletar_btn
            // 
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.Location = new System.Drawing.Point(377, 389);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 57);
            this.deletar_btn.TabIndex = 23;
            this.deletar_btn.Text = "Deletar";
            this.deletar_btn.UseVisualStyleBackColor = true;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar_btn.Location = new System.Drawing.Point(512, 389);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(129, 57);
            this.atualizar_btn.TabIndex = 22;
            this.atualizar_btn.Text = "Atualizar";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.atualizar_btn_Click);
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(647, 389);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 21;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 54;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.atualizar_btn);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoNumericUpDown);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "clientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.Label head;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bd_locadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.NumericUpDown codigoNumericUpDown;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button gravar_btn;
        private System.Windows.Forms.Button button1;
    }
}