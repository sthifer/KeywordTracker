﻿
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
            this.buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posihoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesar_todo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(282, 34);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "button1";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
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
            this.posihoy});
            this.dataGridView1.Location = new System.Drawing.Point(35, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 323);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Keyword
            // 
            this.Keyword.HeaderText = "Keyword";
            this.Keyword.Name = "Keyword";
            // 
            // Dominio
            // 
            this.Dominio.HeaderText = "Dominio";
            this.Dominio.Name = "Dominio";
            // 
            // posihoy
            // 
            this.posihoy.HeaderText = "Posición Hoy";
            this.posihoy.Name = "posihoy";
            // 
            // procesar_todo
            // 
            this.procesar_todo.Location = new System.Drawing.Point(224, 477);
            this.procesar_todo.Name = "procesar_todo";
            this.procesar_todo.Size = new System.Drawing.Size(142, 49);
            this.procesar_todo.TabIndex = 4;
            this.procesar_todo.Text = "A Buscar!";
            this.procesar_todo.UseVisualStyleBackColor = true;
            this.procesar_todo.Click += new System.EventHandler(this.procesar_todo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(718, 477);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 49);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "button1";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // KeywordTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 564);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.procesar_todo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buscar);
            this.Name = "KeywordTracker";
            this.Text = "Keyword Tracker by JM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn posihoy;
        private System.Windows.Forms.Button procesar_todo;
        private System.Windows.Forms.Button btnActualizar;
    }
}

