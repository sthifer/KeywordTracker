
namespace KeywordTracker
{
    partial class KeywordTracker
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posihoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MejorPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Busquedas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "D:\\Keywords.xlsx";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Keyword,
            this.Dominio,
            this.posihoy,
            this.Cambio,
            this.MejorPosicion,
            this.Busquedas,
            this.Dia1,
            this.Dia2,
            this.Dia3,
            this.Dia4,
            this.Dia5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 410);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Keyword
            // 
            this.Keyword.HeaderText = "Keyword";
            this.Keyword.Name = "Keyword";
            this.Keyword.ReadOnly = true;
            this.Keyword.Width = 200;
            // 
            // Dominio
            // 
            this.Dominio.HeaderText = "Dominio";
            this.Dominio.Name = "Dominio";
            this.Dominio.ReadOnly = true;
            this.Dominio.Width = 200;
            // 
            // posihoy
            // 
            this.posihoy.HeaderText = "Ultima posición";
            this.posihoy.Name = "posihoy";
            this.posihoy.ReadOnly = true;
            // 
            // Cambio
            // 
            this.Cambio.HeaderText = "Cambio";
            this.Cambio.Name = "Cambio";
            this.Cambio.ReadOnly = true;
            // 
            // MejorPosicion
            // 
            this.MejorPosicion.HeaderText = "Mejor Posición";
            this.MejorPosicion.Name = "MejorPosicion";
            this.MejorPosicion.ReadOnly = true;
            // 
            // Busquedas
            // 
            this.Busquedas.HeaderText = "Busquedas Mensuales";
            this.Busquedas.Name = "Busquedas";
            this.Busquedas.ReadOnly = true;
            // 
            // Dia1
            // 
            this.Dia1.HeaderText = "Dia1";
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            this.Dia1.Width = 40;
            // 
            // Dia2
            // 
            this.Dia2.HeaderText = "Dia2";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            this.Dia2.Width = 40;
            // 
            // Dia3
            // 
            this.Dia3.HeaderText = "Dia3";
            this.Dia3.Name = "Dia3";
            this.Dia3.ReadOnly = true;
            this.Dia3.Width = 40;
            // 
            // Dia4
            // 
            this.Dia4.HeaderText = "Dia4";
            this.Dia4.Name = "Dia4";
            this.Dia4.ReadOnly = true;
            this.Dia4.Width = 40;
            // 
            // Dia5
            // 
            this.Dia5.HeaderText = "Dia5";
            this.Dia5.Name = "Dia5";
            this.Dia5.ReadOnly = true;
            this.Dia5.Width = 40;
            // 
            // procesar
            // 
            this.procesar.Location = new System.Drawing.Point(624, 34);
            this.procesar.Name = "procesar";
            this.procesar.Size = new System.Drawing.Size(193, 54);
            this.procesar.TabIndex = 6;
            this.procesar.Text = "Procesar";
            this.procesar.UseVisualStyleBackColor = true;
            this.procesar.Click += new System.EventHandler(this.Automatico_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 561);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(810, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta de la excel junto a su nombre.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aplicación hecha por jmtravel.es";
            // 
            // KeywordTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.procesar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "KeywordTracker";
            this.Text = "Keyword Tracker by JM - jmtravel.es";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button procesar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn posihoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MejorPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Busquedas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

