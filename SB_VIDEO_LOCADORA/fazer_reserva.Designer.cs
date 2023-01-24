namespace SB_VIDEO_LOCADORA
{
    partial class fazer_reserva
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
            System.Windows.Forms.Label codFilmeLabel;
            System.Windows.Forms.Label observacoLabel;
            System.Windows.Forms.Label dtFimLabel;
            System.Windows.Forms.Label dtInicioLabel;
            this.minhas_reservas = new System.Windows.Forms.Button();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.dtFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codFilmeComboBox = new System.Windows.Forms.ComboBox();
            this.filmeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.SituacaoTableAdapter();
            this.rmv_filme = new System.Windows.Forms.Button();
            this.Filmes_selecionados = new System.Windows.Forms.GroupBox();
            this.lista_filmes = new System.Windows.Forms.Label();
            this.add_filme = new System.Windows.Forms.Button();
            this.filmeTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.FilmeTableAdapter();
            this.clienteTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.reservasTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ReservasTableAdapter();
            this.head = new System.Windows.Forms.Label();
            this.observacoTextBox = new System.Windows.Forms.TextBox();
            this.voltar_btn = new System.Windows.Forms.Button();
            codFilmeLabel = new System.Windows.Forms.Label();
            observacoLabel = new System.Windows.Forms.Label();
            dtFimLabel = new System.Windows.Forms.Label();
            dtInicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.Filmes_selecionados.SuspendLayout();
            this.SuspendLayout();
            // 
            // codFilmeLabel
            // 
            codFilmeLabel.AutoSize = true;
            codFilmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codFilmeLabel.Location = new System.Drawing.Point(8, 51);
            codFilmeLabel.Name = "codFilmeLabel";
            codFilmeLabel.Size = new System.Drawing.Size(51, 20);
            codFilmeLabel.TabIndex = 45;
            codFilmeLabel.Text = "Filme:";
            // 
            // observacoLabel
            // 
            observacoLabel.AutoSize = true;
            observacoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoLabel.Location = new System.Drawing.Point(8, 246);
            observacoLabel.Name = "observacoLabel";
            observacoLabel.Size = new System.Drawing.Size(98, 20);
            observacoLabel.TabIndex = 43;
            observacoLabel.Text = "Observacao:";
            observacoLabel.Click += new System.EventHandler(this.observacoLabel_Click);
            // 
            // dtFimLabel
            // 
            dtFimLabel.AutoSize = true;
            dtFimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtFimLabel.Location = new System.Drawing.Point(8, 194);
            dtFimLabel.Name = "dtFimLabel";
            dtFimLabel.Size = new System.Drawing.Size(78, 20);
            dtFimLabel.TabIndex = 40;
            dtFimLabel.Text = "Data Fim:";
            // 
            // dtInicioLabel
            // 
            dtInicioLabel.AutoSize = true;
            dtInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtInicioLabel.Location = new System.Drawing.Point(8, 139);
            dtInicioLabel.Name = "dtInicioLabel";
            dtInicioLabel.Size = new System.Drawing.Size(89, 20);
            dtInicioLabel.TabIndex = 38;
            dtInicioLabel.Text = "Data Inicio:";
            // 
            // minhas_reservas
            // 
            this.minhas_reservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhas_reservas.Location = new System.Drawing.Point(12, 381);
            this.minhas_reservas.Name = "minhas_reservas";
            this.minhas_reservas.Size = new System.Drawing.Size(129, 57);
            this.minhas_reservas.TabIndex = 14;
            this.minhas_reservas.Text = "Minhas Reservas";
            this.minhas_reservas.UseVisualStyleBackColor = true;
            this.minhas_reservas.Click += new System.EventHandler(this.minhas_reservas_Click);
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(659, 381);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 13;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFimDateTimePicker
            // 
            this.dtFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "DtFim", true));
            this.dtFimDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimDateTimePicker.Location = new System.Drawing.Point(12, 217);
            this.dtFimDateTimePicker.Name = "dtFimDateTimePicker";
            this.dtFimDateTimePicker.Size = new System.Drawing.Size(387, 26);
            this.dtFimDateTimePicker.TabIndex = 41;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // dtInicioDateTimePicker
            // 
            this.dtInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservasBindingSource, "DtInicio", true));
            this.dtInicioDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioDateTimePicker.Location = new System.Drawing.Point(12, 162);
            this.dtInicioDateTimePicker.Name = "dtInicioDateTimePicker";
            this.dtInicioDateTimePicker.Size = new System.Drawing.Size(387, 26);
            this.dtInicioDateTimePicker.TabIndex = 39;
            // 
            // codFilmeComboBox
            // 
            this.codFilmeComboBox.DataSource = this.filmeBindingSource1;
            this.codFilmeComboBox.DisplayMember = "Descricao";
            this.codFilmeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codFilmeComboBox.FormattingEnabled = true;
            this.codFilmeComboBox.Location = new System.Drawing.Point(12, 74);
            this.codFilmeComboBox.Name = "codFilmeComboBox";
            this.codFilmeComboBox.Size = new System.Drawing.Size(290, 28);
            this.codFilmeComboBox.TabIndex = 47;
            this.codFilmeComboBox.ValueMember = "Codigo";
            // 
            // filmeBindingSource1
            // 
            this.filmeBindingSource1.DataMember = "Filme";
            this.filmeBindingSource1.DataSource = this.bd_locadoraDataSet;
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.bd_locadoraDataSet;
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
            // rmv_filme
            // 
            this.rmv_filme.Location = new System.Drawing.Point(308, 108);
            this.rmv_filme.Name = "rmv_filme";
            this.rmv_filme.Size = new System.Drawing.Size(91, 28);
            this.rmv_filme.TabIndex = 51;
            this.rmv_filme.Text = "Remover Filme";
            this.rmv_filme.UseVisualStyleBackColor = true;
            this.rmv_filme.Click += new System.EventHandler(this.rmv_filme_Click);
            // 
            // Filmes_selecionados
            // 
            this.Filmes_selecionados.Controls.Add(this.lista_filmes);
            this.Filmes_selecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmes_selecionados.Location = new System.Drawing.Point(405, 54);
            this.Filmes_selecionados.Name = "Filmes_selecionados";
            this.Filmes_selecionados.Size = new System.Drawing.Size(396, 321);
            this.Filmes_selecionados.TabIndex = 50;
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
            // 
            // add_filme
            // 
            this.add_filme.Location = new System.Drawing.Point(308, 74);
            this.add_filme.Name = "add_filme";
            this.add_filme.Size = new System.Drawing.Size(91, 28);
            this.add_filme.TabIndex = 49;
            this.add_filme.Text = "Adicionar Filme";
            this.add_filme.UseVisualStyleBackColor = true;
            this.add_filme.Click += new System.EventHandler(this.add_filme_Click);
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FilmeTableAdapter = this.filmeTableAdapter;
            this.tableAdapterManager.ReservasTableAdapter = this.reservasTableAdapter;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(259, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(289, 42);
            this.head.TabIndex = 34;
            this.head.Text = "Reservar Filmes";
            // 
            // observacoTextBox
            // 
            this.observacoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoTextBox.Location = new System.Drawing.Point(12, 269);
            this.observacoTextBox.Multiline = true;
            this.observacoTextBox.Name = "observacoTextBox";
            this.observacoTextBox.Size = new System.Drawing.Size(387, 106);
            this.observacoTextBox.TabIndex = 44;
            this.observacoTextBox.TextChanged += new System.EventHandler(this.observacoTextBox_TextChanged);
            // 
            // voltar_btn
            // 
            this.voltar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar_btn.Location = new System.Drawing.Point(12, 12);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(74, 22);
            this.voltar_btn.TabIndex = 52;
            this.voltar_btn.Text = "Sair";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // fazer_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar_btn);
            this.Controls.Add(this.dtFimDateTimePicker);
            this.Controls.Add(this.dtInicioDateTimePicker);
            this.Controls.Add(this.codFilmeComboBox);
            this.Controls.Add(this.observacoTextBox);
            this.Controls.Add(this.rmv_filme);
            this.Controls.Add(this.Filmes_selecionados);
            this.Controls.Add(this.add_filme);
            this.Controls.Add(codFilmeLabel);
            this.Controls.Add(observacoLabel);
            this.Controls.Add(dtFimLabel);
            this.Controls.Add(dtInicioLabel);
            this.Controls.Add(this.head);
            this.Controls.Add(this.minhas_reservas);
            this.Controls.Add(this.gravar_btn);
            this.Name = "fazer_reserva";
            this.Text = "fazer_reserva";
            this.Load += new System.EventHandler(this.fazer_reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.Filmes_selecionados.ResumeLayout(false);
            this.Filmes_selecionados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button minhas_reservas;
        private System.Windows.Forms.Button gravar_btn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.DateTimePicker dtFimDateTimePicker;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private System.Windows.Forms.DateTimePicker dtInicioDateTimePicker;
        private System.Windows.Forms.ComboBox codFilmeComboBox;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private bd_locadoraDataSetTableAdapters.SituacaoTableAdapter situacaoTableAdapter;
        private System.Windows.Forms.Button rmv_filme;
        private System.Windows.Forms.GroupBox Filmes_selecionados;
        private System.Windows.Forms.Label lista_filmes;
        private System.Windows.Forms.Button add_filme;
        private bd_locadoraDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private bd_locadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bd_locadoraDataSetTableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.TextBox observacoTextBox;
        private System.Windows.Forms.BindingSource filmeBindingSource1;
        private System.Windows.Forms.Button voltar_btn;
    }
}