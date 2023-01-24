namespace SB_VIDEO_LOCADORA
{
    partial class reservas
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
            this.voltar_btn = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.filmesReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.reservasTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.ReservasTableAdapter();
            this.tableAdapterManager = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager();
            this.filmesReservaTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.FilmesReservaTableAdapter();
            this.reservas_view_geralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservas_view_geralTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.reservas_view_geralTableAdapter();
            this.reservas_view_geralDataGridView = new System.Windows.Forms.DataGridView();
            this.Ações = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmesReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar_btn
            // 
            this.voltar_btn.Location = new System.Drawing.Point(12, 389);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(129, 57);
            this.voltar_btn.TabIndex = 2;
            this.voltar_btn.Text = "Voltar";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(317, 9);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(177, 42);
            this.head.TabIndex = 7;
            this.head.Text = "Reservas";
            // 
            // filmesReservaBindingSource
            // 
            this.filmesReservaBindingSource.DataMember = "fk_fr_reserva";
            this.filmesReservaBindingSource.DataSource = this.reservasBindingSource;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FilmesReservaTableAdapter = this.filmesReservaTableAdapter;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = this.reservasTableAdapter;
            this.tableAdapterManager.SituacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // filmesReservaTableAdapter
            // 
            this.filmesReservaTableAdapter.ClearBeforeFill = true;
            // 
            // reservas_view_geralBindingSource
            // 
            this.reservas_view_geralBindingSource.DataMember = "reservas_view_geral";
            this.reservas_view_geralBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // reservas_view_geralTableAdapter
            // 
            this.reservas_view_geralTableAdapter.ClearBeforeFill = true;
            // 
            // reservas_view_geralDataGridView
            // 
            this.reservas_view_geralDataGridView.AutoGenerateColumns = false;
            this.reservas_view_geralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservas_view_geralDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ações,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.reservas_view_geralDataGridView.DataSource = this.reservas_view_geralBindingSource;
            this.reservas_view_geralDataGridView.Location = new System.Drawing.Point(12, 54);
            this.reservas_view_geralDataGridView.Name = "reservas_view_geralDataGridView";
            this.reservas_view_geralDataGridView.Size = new System.Drawing.Size(788, 329);
            this.reservas_view_geralDataGridView.TabIndex = 18;
            this.reservas_view_geralDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservas_view_geralDataGridView_CellContentClick);
            // 
            // Ações
            // 
            this.Ações.DataPropertyName = "Codigo";
            this.Ações.HeaderText = "Ações";
            this.Ações.Name = "Ações";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Filmes";
            this.dataGridViewTextBoxColumn3.HeaderText = "Filmes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DtInicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "DtInicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DtFim";
            this.dataGridViewTextBoxColumn5.HeaderText = "DtFim";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Observaco";
            this.dataGridViewTextBoxColumn7.HeaderText = "Observaco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            // reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservas_view_geralDataGridView);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "reservas";
            this.Text = "reservas";
            this.Load += new System.EventHandler(this.reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmesReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.Label head;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private bd_locadoraDataSetTableAdapters.ReservasTableAdapter reservasTableAdapter;
        private bd_locadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bd_locadoraDataSetTableAdapters.FilmesReservaTableAdapter filmesReservaTableAdapter;
        private System.Windows.Forms.BindingSource filmesReservaBindingSource;
        private System.Windows.Forms.BindingSource reservas_view_geralBindingSource;
        private bd_locadoraDataSetTableAdapters.reservas_view_geralTableAdapter reservas_view_geralTableAdapter;
        private System.Windows.Forms.DataGridView reservas_view_geralDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Ações;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
    }
}