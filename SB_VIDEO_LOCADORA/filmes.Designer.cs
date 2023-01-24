namespace SB_VIDEO_LOCADORA
{
    partial class filmes
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
            System.Windows.Forms.Label codcat_txt;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label anoLancamentoLabel;
            System.Windows.Forms.Label valorLabel;
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.filmesReservaTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.FilmesReservaTableAdapter();
            this.codCat_combobox = new System.Windows.Forms.ComboBox();
            this.categoriaFilmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet1 = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.categoriaFilmeTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.CategoriaFilmeTableAdapter();
            this.filmeTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.FilmeTableAdapter();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.codigoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.filmeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoLancamentoTextBox = new System.Windows.Forms.TextBox();
            this.valorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            codcat_txt = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            anoLancamentoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(8, 49);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 16;
            codigoLabel.Text = "Codigo:";
            codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // codcat_txt
            // 
            codcat_txt.AutoSize = true;
            codcat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codcat_txt.Location = new System.Drawing.Point(8, 99);
            codcat_txt.Name = "codcat_txt";
            codcat_txt.Size = new System.Drawing.Size(78, 20);
            codcat_txt.TabIndex = 18;
            codcat_txt.Text = "Categoria";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(8, 151);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(84, 20);
            descricaoLabel.TabIndex = 18;
            descricaoLabel.Text = "Descricao:";
            // 
            // anoLancamentoLabel
            // 
            anoLancamentoLabel.AutoSize = true;
            anoLancamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLancamentoLabel.Location = new System.Drawing.Point(8, 202);
            anoLancamentoLabel.Name = "anoLancamentoLabel";
            anoLancamentoLabel.Size = new System.Drawing.Size(135, 20);
            anoLancamentoLabel.TabIndex = 22;
            anoLancamentoLabel.Text = "Ano Lancamento:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.Location = new System.Drawing.Point(8, 254);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(50, 20);
            valorLabel.TabIndex = 23;
            valorLabel.Text = "Valor:";
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
            this.head.Location = new System.Drawing.Point(339, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(127, 42);
            this.head.TabIndex = 7;
            this.head.Text = "Filmes";
            // 
            // deletar_btn
            // 
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.Location = new System.Drawing.Point(397, 389);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 57);
            this.deletar_btn.TabIndex = 15;
            this.deletar_btn.Text = "Deletar";
            this.deletar_btn.UseVisualStyleBackColor = true;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar_btn.Location = new System.Drawing.Point(532, 389);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(129, 57);
            this.atualizar_btn.TabIndex = 14;
            this.atualizar_btn.Text = "Atualizar";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.atualizar_btn_Click);
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(667, 389);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 13;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmesReservaTableAdapter
            // 
            this.filmesReservaTableAdapter.ClearBeforeFill = true;
            // 
            // codCat_combobox
            // 
            this.codCat_combobox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bd_locadoraDataSet, "CategoriaFilme.Codigo", true));
            this.codCat_combobox.DataSource = this.categoriaFilmeBindingSource;
            this.codCat_combobox.DisplayMember = "Descricao";
            this.codCat_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codCat_combobox.FormattingEnabled = true;
            this.codCat_combobox.Location = new System.Drawing.Point(12, 122);
            this.codCat_combobox.Name = "codCat_combobox";
            this.codCat_combobox.Size = new System.Drawing.Size(784, 28);
            this.codCat_combobox.TabIndex = 16;
            this.codCat_combobox.ValueMember = "CategoriaFilme.Codigo";
            // 
            // categoriaFilmeBindingSource
            // 
            this.categoriaFilmeBindingSource.DataMember = "CategoriaFilme";
            this.categoriaFilmeBindingSource.DataSource = this.bd_locadoraDataSet1;
            // 
            // bd_locadoraDataSet1
            // 
            this.bd_locadoraDataSet1.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaFilmeTableAdapter
            // 
            this.categoriaFilmeTableAdapter.ClearBeforeFill = true;
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FilmesReservaTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // codigoNumericUpDown
            // 
            this.codigoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmeBindingSource, "Codigo", true));
            this.codigoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoNumericUpDown.Location = new System.Drawing.Point(12, 72);
            this.codigoNumericUpDown.Name = "codigoNumericUpDown";
            this.codigoNumericUpDown.Size = new System.Drawing.Size(784, 26);
            this.codigoNumericUpDown.TabIndex = 17;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmeBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(12, 174);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(784, 26);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // filmeDataGridView
            // 
            this.filmeDataGridView.AllowUserToAddRows = false;
            this.filmeDataGridView.AllowUserToDeleteRows = false;
            this.filmeDataGridView.AllowUserToOrderColumns = true;
            this.filmeDataGridView.AutoGenerateColumns = false;
            this.filmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.filmeDataGridView.DataSource = this.filmeBindingSource;
            this.filmeDataGridView.Location = new System.Drawing.Point(12, 312);
            this.filmeDataGridView.Name = "filmeDataGridView";
            this.filmeDataGridView.ReadOnly = true;
            this.filmeDataGridView.Size = new System.Drawing.Size(784, 71);
            this.filmeDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodCategoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodCategoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnoLancamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnoLancamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // anoLancamentoTextBox
            // 
            this.anoLancamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmeBindingSource, "AnoLancamento", true));
            this.anoLancamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoLancamentoTextBox.Location = new System.Drawing.Point(12, 225);
            this.anoLancamentoTextBox.Name = "anoLancamentoTextBox";
            this.anoLancamentoTextBox.Size = new System.Drawing.Size(784, 26);
            this.anoLancamentoTextBox.TabIndex = 23;
            // 
            // valorNumericUpDown
            // 
            this.valorNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmeBindingSource, "Valor", true));
            this.valorNumericUpDown.DecimalPlaces = 2;
            this.valorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorNumericUpDown.Location = new System.Drawing.Point(12, 277);
            this.valorNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.valorNumericUpDown.Name = "valorNumericUpDown";
            this.valorNumericUpDown.Size = new System.Drawing.Size(784, 26);
            this.valorNumericUpDown.TabIndex = 24;
            this.valorNumericUpDown.ValueChanged += new System.EventHandler(this.valorNumericUpDown_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 54;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorNumericUpDown);
            this.Controls.Add(anoLancamentoLabel);
            this.Controls.Add(this.anoLancamentoTextBox);
            this.Controls.Add(this.filmeDataGridView);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(codcat_txt);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoNumericUpDown);
            this.Controls.Add(this.codCat_combobox);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.atualizar_btn);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "filmes";
            this.Text = "filmes";
            this.Load += new System.EventHandler(this.filmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumericUpDown)).EndInit();
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
        private bd_locadoraDataSetTableAdapters.FilmesReservaTableAdapter filmesReservaTableAdapter;
        private System.Windows.Forms.ComboBox codCat_combobox;
        private bd_locadoraDataSetTableAdapters.CategoriaFilmeTableAdapter categoriaFilmeTableAdapter;
        private bd_locadoraDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private System.Windows.Forms.BindingSource categoriaFilmeBindingSource;
        private bd_locadoraDataSet bd_locadoraDataSet1;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown codigoNumericUpDown;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DataGridView filmeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox anoLancamentoTextBox;
        private System.Windows.Forms.NumericUpDown valorNumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}