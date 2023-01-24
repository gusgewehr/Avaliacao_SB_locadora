namespace SB_VIDEO_LOCADORA
{
    partial class minhas_reservas
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
            this.reservas_view_geralDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasviewgeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_locadoraDataSet = new SB_VIDEO_LOCADORA.bd_locadoraDataSet();
            this.head = new System.Windows.Forms.Label();
            this.reservas_view_geralTableAdapter = new SB_VIDEO_LOCADORA.bd_locadoraDataSetTableAdapters.reservas_view_geralTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasviewgeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar_btn
            // 
            this.voltar_btn.Location = new System.Drawing.Point(12, 381);
            this.voltar_btn.Name = "voltar_btn";
            this.voltar_btn.Size = new System.Drawing.Size(129, 57);
            this.voltar_btn.TabIndex = 2;
            this.voltar_btn.Text = "Voltar";
            this.voltar_btn.UseVisualStyleBackColor = true;
            this.voltar_btn.Click += new System.EventHandler(this.voltar_btn_Click);
            // 
            // reservas_view_geralDataGridView
            // 
            this.reservas_view_geralDataGridView.AllowUserToAddRows = false;
            this.reservas_view_geralDataGridView.AllowUserToDeleteRows = false;
            this.reservas_view_geralDataGridView.AllowUserToOrderColumns = true;
            this.reservas_view_geralDataGridView.AutoGenerateColumns = false;
            this.reservas_view_geralDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservas_view_geralDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.filmesDataGridViewTextBoxColumn,
            this.dtInicioDataGridViewTextBoxColumn,
            this.dtFimDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.observacoDataGridViewTextBoxColumn});
            this.reservas_view_geralDataGridView.DataSource = this.reservasviewgeralBindingSource;
            this.reservas_view_geralDataGridView.Location = new System.Drawing.Point(12, 44);
            this.reservas_view_geralDataGridView.Name = "reservas_view_geralDataGridView";
            this.reservas_view_geralDataGridView.ReadOnly = true;
            this.reservas_view_geralDataGridView.Size = new System.Drawing.Size(776, 331);
            this.reservas_view_geralDataGridView.TabIndex = 20;
            this.reservas_view_geralDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservas_view_geralDataGridView_CellContentClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmesDataGridViewTextBoxColumn
            // 
            this.filmesDataGridViewTextBoxColumn.DataPropertyName = "Filmes";
            this.filmesDataGridViewTextBoxColumn.HeaderText = "Filmes";
            this.filmesDataGridViewTextBoxColumn.Name = "filmesDataGridViewTextBoxColumn";
            this.filmesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtInicioDataGridViewTextBoxColumn
            // 
            this.dtInicioDataGridViewTextBoxColumn.DataPropertyName = "DtInicio";
            this.dtInicioDataGridViewTextBoxColumn.HeaderText = "DtInicio";
            this.dtInicioDataGridViewTextBoxColumn.Name = "dtInicioDataGridViewTextBoxColumn";
            this.dtInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtFimDataGridViewTextBoxColumn
            // 
            this.dtFimDataGridViewTextBoxColumn.DataPropertyName = "DtFim";
            this.dtFimDataGridViewTextBoxColumn.HeaderText = "DtFim";
            this.dtFimDataGridViewTextBoxColumn.Name = "dtFimDataGridViewTextBoxColumn";
            this.dtFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacoDataGridViewTextBoxColumn
            // 
            this.observacoDataGridViewTextBoxColumn.DataPropertyName = "Observaco";
            this.observacoDataGridViewTextBoxColumn.HeaderText = "Observaco";
            this.observacoDataGridViewTextBoxColumn.Name = "observacoDataGridViewTextBoxColumn";
            this.observacoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservasviewgeralBindingSource
            // 
            this.reservasviewgeralBindingSource.DataMember = "reservas_view_geral";
            this.reservasviewgeralBindingSource.DataSource = this.bd_locadoraDataSet;
            // 
            // bd_locadoraDataSet
            // 
            this.bd_locadoraDataSet.DataSetName = "bd_locadoraDataSet";
            this.bd_locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(312, -1);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(177, 42);
            this.head.TabIndex = 19;
            this.head.Text = "Reservas";
            // 
            // reservas_view_geralTableAdapter
            // 
            this.reservas_view_geralTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 53;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minhas_reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservas_view_geralDataGridView);
            this.Controls.Add(this.head);
            this.Controls.Add(this.voltar_btn);
            this.Name = "minhas_reservas";
            this.Text = "minhas_reservas";
            this.Load += new System.EventHandler(this.minhas_reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservas_view_geralDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasviewgeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_locadoraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar_btn;
        private System.Windows.Forms.DataGridView reservas_view_geralDataGridView;
        private System.Windows.Forms.Label head;
        private bd_locadoraDataSet bd_locadoraDataSet;
        private System.Windows.Forms.BindingSource reservasviewgeralBindingSource;
        private bd_locadoraDataSetTableAdapters.reservas_view_geralTableAdapter reservas_view_geralTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}