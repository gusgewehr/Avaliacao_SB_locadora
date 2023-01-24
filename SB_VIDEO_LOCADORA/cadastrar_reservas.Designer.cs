namespace SB_VIDEO_LOCADORA
{
    partial class cadastrar_reservas
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label codClienteLabel;
            System.Windows.Forms.Label dtInicioLabel;
            System.Windows.Forms.Label dtFimLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label observacoLabel;
            System.Windows.Forms.Label codFilmeLabel;
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ReservasTableAdapter();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ClienteTableAdapter();
            this.filmeTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.FilmeTableAdapter();
            this.codigoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dtInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacoTextBox = new System.Windows.Forms.TextBox();
            this.codClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codFilmeComboBox = new System.Windows.Forms.ComboBox();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.SituacaoTableAdapter();
            this.add_filme = new System.Windows.Forms.Button();
            this.Filmes_selecionados = new System.Windows.Forms.GroupBox();
            this.lista_filmes = new System.Windows.Forms.Label();
            this.rmv_filme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            codClienteLabel = new System.Windows.Forms.Label();
            dtInicioLabel = new System.Windows.Forms.Label();
            dtFimLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            observacoLabel = new System.Windows.Forms.Label();
            codFilmeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.Filmes_selecionados.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(8, 51);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 19;
            codigoLabel.Text = "Codigo:";
            codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // codClienteLabel
            // 
            codClienteLabel.AutoSize = true;
            codClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codClienteLabel.Location = new System.Drawing.Point(8, 182);
            codClienteLabel.Name = "codClienteLabel";
            codClienteLabel.Size = new System.Drawing.Size(62, 20);
            codClienteLabel.TabIndex = 20;
            codClienteLabel.Text = "Cliente:";
            codClienteLabel.Click += new System.EventHandler(this.codClienteLabel_Click);
            // 
            // dtInicioLabel
            // 
            dtInicioLabel.AutoSize = true;
            dtInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtInicioLabel.Location = new System.Drawing.Point(8, 236);
            dtInicioLabel.Name = "dtInicioLabel";
            dtInicioLabel.Size = new System.Drawing.Size(89, 20);
            dtInicioLabel.TabIndex = 21;
            dtInicioLabel.Text = "Data Inicio:";
            dtInicioLabel.Click += new System.EventHandler(this.dtInicioLabel_Click);
            // 
            // dtFimLabel
            // 
            dtFimLabel.AutoSize = true;
            dtFimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtFimLabel.Location = new System.Drawing.Point(410, 236);
            dtFimLabel.Name = "dtFimLabel";
            dtFimLabel.Size = new System.Drawing.Size(78, 20);
            dtFimLabel.TabIndex = 22;
            dtFimLabel.Text = "Data Fim:";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            situacaoLabel.Location = new System.Drawing.Point(8, 288);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(76, 20);
            situacaoLabel.TabIndex = 23;
            situacaoLabel.Text = "Situacao:";
            // 
            // observacoLabel
            // 
            observacoLabel.AutoSize = true;
            observacoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoLabel.Location = new System.Drawing.Point(8, 342);
            observacoLabel.Name = "observacoLabel";
            observacoLabel.Size = new System.Drawing.Size(89, 20);
            observacoLabel.TabIndex = 24;
            observacoLabel.Text = "Observaco:";
            observacoLabel.Click += new System.EventHandler(this.observacoLabel_Click);
            // 
            // codFilmeLabel
            // 
            codFilmeLabel.AutoSize = true;
            codFilmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codFilmeLabel.Location = new System.Drawing.Point(8, 103);
            codFilmeLabel.Name = "codFilmeLabel";
            codFilmeLabel.Size = new System.Drawing.Size(51, 20);
            codFilmeLabel.TabIndex = 26;
            codFilmeLabel.Text = "Filme:";
            // 
            // voltar_btn
            // 
            this.voltar_btn.Location = new System.Drawing.Point(12, 397);
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
            this.head.Location = new System.Drawing.Point(224, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(351, 42);
            this.head.TabIndex = 6;
            this.head.Text = "Cadastrar Reservas";
            // 
            // deletar_btn
            // 
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.Location = new System.Drawing.Point(403, 397);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 57);
            this.deletar_btn.TabIndex = 18;
            this.deletar_btn.Text = "Deletar";
            this.deletar_btn.UseVisualStyleBackColor = true;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar_btn.Location = new System.Drawing.Point(538, 397);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(129, 57);
            this.atualizar_btn.TabIndex = 17;
            this.atualizar_btn.Text = "Atualizar";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.atualizar_btn_Click);
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(681, 397);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 16;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FilmesReservaTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = this.filmeTableAdapter;
            this.tableAdapterManager.ReservasTableAdapter = this.reservasTableAdapter;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // codigoNumericUpDown
            // 
            this.codigoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "Codigo", true));
            this.codigoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoNumericUpDown.Location = new System.Drawing.Point(12, 74);
            this.codigoNumericUpDown.Name = "codigoNumericUpDown";
            this.codigoNumericUpDown.Size = new System.Drawing.Size(396, 26);
            this.codigoNumericUpDown.TabIndex = 20;
            // 
            // dtInicioDateTimePicker
            // 
            this.dtInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "DtInicio", true));
            this.dtInicioDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioDateTimePicker.Location = new System.Drawing.Point(12, 259);
            this.dtInicioDateTimePicker.Name = "dtInicioDateTimePicker";
            this.dtInicioDateTimePicker.Size = new System.Drawing.Size(396, 26);
            this.dtInicioDateTimePicker.TabIndex = 22;
            // 
            // dtFimDateTimePicker
            // 
            this.dtFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "DtFim", true));
            this.dtFimDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimDateTimePicker.Location = new System.Drawing.Point(414, 259);
            this.dtFimDateTimePicker.Name = "dtFimDateTimePicker";
            this.dtFimDateTimePicker.Size = new System.Drawing.Size(396, 26);
            this.dtFimDateTimePicker.TabIndex = 23;
            // 
            // observacoTextBox
            // 
            this.observacoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "Observaco", true));
            this.observacoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoTextBox.Location = new System.Drawing.Point(12, 365);
            this.observacoTextBox.Name = "observacoTextBox";
            this.observacoTextBox.Size = new System.Drawing.Size(798, 26);
            this.observacoTextBox.TabIndex = 25;
            // 
            // codClienteComboBox
            // 
            this.codClienteComboBox.DataSource = this.clienteBindingSource;
            this.codClienteComboBox.DisplayMember = "Nome";
            this.codClienteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codClienteComboBox.FormattingEnabled = true;
            this.codClienteComboBox.Location = new System.Drawing.Point(12, 205);
            this.codClienteComboBox.Name = "codClienteComboBox";
            this.codClienteComboBox.Size = new System.Drawing.Size(396, 28);
            this.codClienteComboBox.TabIndex = 28;
            this.codClienteComboBox.ValueMember = "Codigo";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // codFilmeComboBox
            // 
            this.codFilmeComboBox.DataSource = this.filmeBindingSource;
            this.codFilmeComboBox.DisplayMember = "Descricao";
            this.codFilmeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codFilmeComboBox.FormattingEnabled = true;
            this.codFilmeComboBox.Location = new System.Drawing.Point(12, 126);
            this.codFilmeComboBox.Name = "codFilmeComboBox";
            this.codFilmeComboBox.Size = new System.Drawing.Size(299, 28);
            this.codFilmeComboBox.TabIndex = 29;
            this.codFilmeComboBox.ValueMember = "Codigo";
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasBindingSource, "Situacao", true));
            this.situacaoComboBox.DataSource = this.situacaoBindingSource;
            this.situacaoComboBox.DisplayMember = "Descricao";
            this.situacaoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Location = new System.Drawing.Point(12, 311);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(798, 28);
            this.situacaoComboBox.TabIndex = 30;
            this.situacaoComboBox.ValueMember = "Codigo";
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataMember = "Situacao";
            this.situacaoBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // situacaoTableAdapter
            // 
            this.situacaoTableAdapter.ClearBeforeFill = true;
            // 
            // add_filme
            // 
            this.add_filme.Location = new System.Drawing.Point(317, 126);
            this.add_filme.Name = "add_filme";
            this.add_filme.Size = new System.Drawing.Size(91, 28);
            this.add_filme.TabIndex = 31;
            this.add_filme.Text = "Adicionar Filme";
            this.add_filme.UseVisualStyleBackColor = true;
            this.add_filme.Click += new System.EventHandler(this.add_filme_Click);
            // 
            // Filmes_selecionados
            // 
            this.Filmes_selecionados.Controls.Add(this.lista_filmes);
            this.Filmes_selecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmes_selecionados.Location = new System.Drawing.Point(414, 51);
            this.Filmes_selecionados.Name = "Filmes_selecionados";
            this.Filmes_selecionados.Size = new System.Drawing.Size(396, 182);
            this.Filmes_selecionados.TabIndex = 32;
            this.Filmes_selecionados.TabStop = false;
            this.Filmes_selecionados.Text = "Filmes Selecionados";
            // 
            // lista_filmes
            // 
            this.lista_filmes.AutoSize = true;
            this.lista_filmes.Location = new System.Drawing.Point(7, 26);
            this.lista_filmes.Name = "lista_filmes";
            this.lista_filmes.Size = new System.Drawing.Size(51, 20);
            this.lista_filmes.TabIndex = 0;
            this.lista_filmes.Text = "label1";
            this.lista_filmes.Click += new System.EventHandler(this.lista_filmes_Click);
            // 
            // rmv_filme
            // 
            this.rmv_filme.Location = new System.Drawing.Point(317, 160);
            this.rmv_filme.Name = "rmv_filme";
            this.rmv_filme.Size = new System.Drawing.Size(91, 28);
            this.rmv_filme.TabIndex = 33;
            this.rmv_filme.Text = "Remover Filme";
            this.rmv_filme.UseVisualStyleBackColor = true;
            this.rmv_filme.Click += new System.EventHandler(this.rmv_filme_Click);
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
            // cadastrar_reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rmv_filme);
            this.Controls.Add(this.Filmes_selecionados);
            this.Controls.Add(this.add_filme);
            this.Controls.Add(this.situacaoComboBox);
            this.Controls.Add(this.codFilmeComboBox);
            this.Controls.Add(this.codClienteComboBox);
            this.Controls.Add(codFilmeLabel);
            this.Controls.Add(observacoLabel);
            this.Controls.Add(this.observacoTextBox);
            this.Controls.Add(situacaoLabel);
            this.Controls.Add(dtFimLabel);
            this.Controls.Add(this.dtFimDateTimePicker);
            this.Controls.Add(dtInicioLabel);
            this.Controls.Add(this.dtInicioDateTimePicker);
            this.Controls.Add(codClienteLabel);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoNumericUpDown);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.atualizar_btn);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "cadastrar_reservas";
            this.Text = "cadastrar_reservas";
            this.Load += new System.EventHandler(this.cadastrar_reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.Filmes_selecionados.ResumeLayout(false);
            this.Filmes_selecionados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button gravar_btn;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private bd_locadoraDataSetTableAdapters.ReservasTableAdapter reservasTableAdapter;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown codigoNumericUpDown;
        private System.Windows.Forms.DateTimePicker dtInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker dtFimDateTimePicker;
        private System.Windows.Forms.TextBox observacoTextBox;
        private System.Windows.Forms.ComboBox codClienteComboBox;
        private System.Windows.Forms.ComboBox codFilmeComboBox;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private bd_locadoraDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private bd_locadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private bd_locadoraDataSetTableAdapters.SituacaoTableAdapter situacaoTableAdapter;
        private System.Windows.Forms.Button add_filme;
        private System.Windows.Forms.GroupBox Filmes_selecionados;
        private System.Windows.Forms.Label lista_filmes;
        private System.Windows.Forms.Button rmv_filme;
        private System.Windows.Forms.Button button1;
    }
}