namespace CuadrilaterosPOO.Windows
{
    partial class frmCuadrilateros
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
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            DatosDataGridView1 = new DataGridView();
            ColumnaLadoA = new DataGridViewTextBoxColumn();
            ColumnaLadoB = new DataGridViewTextBoxColumn();
            ColumnaArea = new DataGridViewTextBoxColumn();
            ColumnaPerimetro = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatosDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, toolStripButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(611, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.Nuevo_32;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 51);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += NuevotoolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.Borrar_32;
            toolStripButton2.ImageAlign = ContentAlignment.BottomCenter;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(43, 51);
            toolStripButton2.Text = "Borrar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.Click += BorrarToolStripButton_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.Editar_32;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(41, 51);
            toolStripButton3.Text = "Editar";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton3.Click += EditartoolStripButton2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.Salir_32;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(65, 51);
            toolStripButton4.Text = "Salir";
            toolStripButton4.Click += SalirtoolStripButton2_Click;
            // 
            // DatosDataGridView1
            // 
            DatosDataGridView1.AllowUserToAddRows = false;
            DatosDataGridView1.AllowUserToDeleteRows = false;
            DatosDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaLadoA, ColumnaLadoB, ColumnaArea, ColumnaPerimetro });
            DatosDataGridView1.Dock = DockStyle.Fill;
            DatosDataGridView1.Location = new Point(0, 54);
            DatosDataGridView1.MultiSelect = false;
            DatosDataGridView1.Name = "DatosDataGridView1";
            DatosDataGridView1.ReadOnly = true;
            DatosDataGridView1.RowTemplate.Height = 25;
            DatosDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosDataGridView1.Size = new Size(611, 496);
            DatosDataGridView1.TabIndex = 1;
            // 
            // ColumnaLadoA
            // 
            ColumnaLadoA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaLadoA.HeaderText = "Lado A:";
            ColumnaLadoA.Name = "ColumnaLadoA";
            ColumnaLadoA.ReadOnly = true;
            // 
            // ColumnaLadoB
            // 
            ColumnaLadoB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaLadoB.HeaderText = "Lado B:";
            ColumnaLadoB.Name = "ColumnaLadoB";
            ColumnaLadoB.ReadOnly = true;
            // 
            // ColumnaArea
            // 
            ColumnaArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaArea.HeaderText = "Area:";
            ColumnaArea.Name = "ColumnaArea";
            ColumnaArea.ReadOnly = true;
            // 
            // ColumnaPerimetro
            // 
            ColumnaPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaPerimetro.HeaderText = "Perimetro:";
            ColumnaPerimetro.Name = "ColumnaPerimetro";
            ColumnaPerimetro.ReadOnly = true;
            // 
            // frmCuadrilateros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 550);
            Controls.Add(DatosDataGridView1);
            Controls.Add(toolStrip1);
            Name = "frmCuadrilateros";
            Text = "frmCuadrilateros";
            Load += frmCuadrilateros_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatosDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private DataGridView DatosDataGridView1;
        private DataGridViewTextBoxColumn ColumnaLadoA;
        private DataGridViewTextBoxColumn ColumnaLadoB;
        private DataGridViewTextBoxColumn ColumnaArea;
        private DataGridViewTextBoxColumn ColumnaPerimetro;
    }
}