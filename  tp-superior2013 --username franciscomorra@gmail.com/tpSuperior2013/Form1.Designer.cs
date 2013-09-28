namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dataSet1 = new System.Data.DataSet();
            this.tablaDatos = new System.Data.DataTable();
            this.dataX = new System.Data.DataColumn();
            this.dataY = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valoresXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoresYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tablaDatos});
            // 
            // tablaDatos
            // 
            this.tablaDatos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataX,
            this.dataY});
            this.tablaDatos.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "valoresX"}, true)});
            this.tablaDatos.PrimaryKey = new System.Data.DataColumn[] {
        this.dataX};
            this.tablaDatos.TableName = "tablaDatos";
            // 
            // dataX
            // 
            this.dataX.AllowDBNull = false;
            this.dataX.ColumnName = "valoresX";
            this.dataX.DataType = typeof(int);
            // 
            // dataY
            // 
            this.dataY.AllowDBNull = false;
            this.dataY.ColumnName = "valoresY";
            this.dataY.DataType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valoresXDataGridViewTextBoxColumn,
            this.valoresYDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "tablaDatos";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // valoresXDataGridViewTextBoxColumn
            // 
            this.valoresXDataGridViewTextBoxColumn.DataPropertyName = "valoresX";
            this.valoresXDataGridViewTextBoxColumn.HeaderText = "valoresX";
            this.valoresXDataGridViewTextBoxColumn.Name = "valoresXDataGridViewTextBoxColumn";
            // 
            // valoresYDataGridViewTextBoxColumn
            // 
            this.valoresYDataGridViewTextBoxColumn.DataPropertyName = "valoresY";
            this.valoresYDataGridViewTextBoxColumn.HeaderText = "valoresY";
            this.valoresYDataGridViewTextBoxColumn.Name = "valoresYDataGridViewTextBoxColumn";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(13, 182);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(240, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Polinomio";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 233);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Data.DataTable tablaDatos;
        private System.Data.DataColumn dataX;
        private System.Data.DataColumn dataY;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoresXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoresYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGenerar;


    }
}

