namespace CuadrilaterosPOO.Windows
{
    partial class frmCuadrilaterosEdit
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            LadoAtextBox = new TextBox();
            LadoBtextBox = new TextBox();
            OKbutton = new Button();
            Cancelarbutton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Lado B:";
            // 
            // LadoAtextBox
            // 
            LadoAtextBox.Location = new Point(92, 36);
            LadoAtextBox.Name = "LadoAtextBox";
            LadoAtextBox.Size = new Size(100, 23);
            LadoAtextBox.TabIndex = 2;
            // 
            // LadoBtextBox
            // 
            LadoBtextBox.Location = new Point(92, 71);
            LadoBtextBox.Name = "LadoBtextBox";
            LadoBtextBox.Size = new Size(100, 23);
            LadoBtextBox.TabIndex = 3;
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(56, 153);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(75, 59);
            OKbutton.TabIndex = 4;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click_1;
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Location = new Point(217, 153);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(75, 59);
            Cancelarbutton.TabIndex = 5;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += CancelarButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCuadrilaterosEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 273);
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(LadoBtextBox);
            Controls.Add(LadoAtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCuadrilaterosEdit";
            Text = "frmCuadrilaterosEdit";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LadoAtextBox;
        private TextBox LadoBtextBox;
        private Button OKbutton;
        private Button Cancelarbutton;
        private ErrorProvider errorProvider1;
    }
}