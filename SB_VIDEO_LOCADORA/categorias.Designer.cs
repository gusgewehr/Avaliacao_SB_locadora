namespace SB_VIDEO_LOCADORA
{
    partial class categorias
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label codigoLabel;
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.categoriaFilmeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaFilmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.gravar_btn = new System.Windows.Forms.Button();
            this.atualizar_btn = new System.Windows.Forms.Button();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.categoriaFilmeTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.CategoriaFilmeTableAdapter();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.codigoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(8, 115);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(84, 20);
            descricaoLabel.TabIndex = 7;
            descricaoLabel.Text = "Descricao:";
            descricaoLabel.Click += new System.EventHandler(this.descricaoLabel_Click);
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoLabel.Location = new System.Drawing.Point(8, 57);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(63, 20);
            codigoLabel.TabIndex = 9;
            codigoLabel.Text = "Codigo:";
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
            this.head.Location = new System.Drawing.Point(304, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(199, 42);
            this.head.TabIndex = 7;
            this.head.Text = "Categorias";
            // 
            // categoriaFilmeDataGridView
            // 
            this.categoriaFilmeDataGridView.AllowUserToAddRows = false;
            this.categoriaFilmeDataGridView.AllowUserToDeleteRows = false;
            this.categoriaFilmeDataGridView.AllowUserToOrderColumns = true;
            this.categoriaFilmeDataGridView.AutoGenerateColumns = false;
            this.categoriaFilmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaFilmeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriaFilmeDataGridView.DataSource = this.categoriaFilmeBindingSource;
            this.categoriaFilmeDataGridView.EnableHeadersVisualStyles = false;
            this.categoriaFilmeDataGridView.Location = new System.Drawing.Point(12, 182);
            this.categoriaFilmeDataGridView.Name = "categoriaFilmeDataGridView";
            this.categoriaFilmeDataGridView.ReadOnly = true;
            this.categoriaFilmeDataGridView.Size = new System.Drawing.Size(776, 193);
            this.categoriaFilmeDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categoriaFilmeBindingSource
            // 
            this.categoriaFilmeBindingSource.DataMember = "CategoriaFilme";
            this.categoriaFilmeBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaFilmeBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(12, 138);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(776, 26);
            this.descricaoTextBox.TabIndex = 8;
            // 
            // gravar_btn
            // 
            this.gravar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravar_btn.Location = new System.Drawing.Point(659, 389);
            this.gravar_btn.Name = "gravar_btn";
            this.gravar_btn.Size = new System.Drawing.Size(129, 57);
            this.gravar_btn.TabIndex = 9;
            this.gravar_btn.Text = "Gravar";
            this.gravar_btn.UseVisualStyleBackColor = true;
            this.gravar_btn.Click += new System.EventHandler(this.gravar_btn_Click);
            // 
            // atualizar_btn
            // 
            this.atualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar_btn.Location = new System.Drawing.Point(524, 389);
            this.atualizar_btn.Name = "atualizar_btn";
            this.atualizar_btn.Size = new System.Drawing.Size(129, 57);
            this.atualizar_btn.TabIndex = 11;
            this.atualizar_btn.Text = "Atualizar";
            this.atualizar_btn.UseVisualStyleBackColor = true;
            this.atualizar_btn.Click += new System.EventHandler(this.atualizar_btn_Click);
            // 
            // deletar_btn
            // 
            this.deletar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_btn.Location = new System.Drawing.Point(389, 389);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(129, 57);
            this.deletar_btn.TabIndex = 12;
            this.deletar_btn.Text = "Deletar";
            this.deletar_btn.UseVisualStyleBackColor = true;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // categoriaFilmeTableAdapter
            // 
            this.categoriaFilmeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = this.categoriaFilmeTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FilmesReservaTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = null;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // codigoNumericUpDown
            // 
            this.codigoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.categoriaFilmeBindingSource, "Codigo", true));
            this.codigoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoNumericUpDown.Location = new System.Drawing.Point(12, 80);
            this.codigoNumericUpDown.Name = "codigoNumericUpDown";
            this.codigoNumericUpDown.Size = new System.Drawing.Size(776, 26);
            this.codigoNumericUpDown.TabIndex = 10;
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
            // categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.atualizar_btn);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoNumericUpDown);
            this.Controls.Add(this.gravar_btn);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.categoriaFilmeDataGridView);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "categorias";
            this.Text = "categorias";
            this.Load += new System.EventHandler(this.categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.Label head;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.BindingSource categoriaFilmeBindingSource;
        private bd_locadoraDataSetTableAdapters.CategoriaFilmeTableAdapter categoriaFilmeTableAdapter;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView categoriaFilmeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button gravar_btn;
        private System.Windows.Forms.Button atualizar_btn;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.NumericUpDown codigoNumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}