namespace GM21057Guia4Ejerecicio6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salir = new System.Windows.Forms.Button();
            this.botonIngresarNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datos = new System.Windows.Forms.DataGridView();
            this.numerosNegativos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerosPositivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMultiplosQuince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salir);
            this.groupBox1.Controls.Add(this.botonIngresarNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(283, 37);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 18;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // botonIngresarNum
            // 
            this.botonIngresarNum.Location = new System.Drawing.Point(176, 37);
            this.botonIngresarNum.Name = "botonIngresarNum";
            this.botonIngresarNum.Size = new System.Drawing.Size(75, 23);
            this.botonIngresarNum.TabIndex = 17;
            this.botonIngresarNum.Text = "Ingresar";
            this.botonIngresarNum.UseVisualStyleBackColor = true;
            this.botonIngresarNum.Click += new System.EventHandler(this.botonIngresarNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los numeros";
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerosNegativos,
            this.numerosPositivos,
            this.numMultiplosQuince,
            this.valorAcumulado});
            this.datos.Location = new System.Drawing.Point(7, 112);
            this.datos.Name = "datos";
            this.datos.RowTemplate.Height = 25;
            this.datos.Size = new System.Drawing.Size(443, 134);
            this.datos.TabIndex = 19;
            this.datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numerosNegativos
            // 
            this.numerosNegativos.HeaderText = "Cantidad de numeros Negativos";
            this.numerosNegativos.Name = "numerosNegativos";
            // 
            // numerosPositivos
            // 
            this.numerosPositivos.HeaderText = "Cantidad de numeros Positivos";
            this.numerosPositivos.Name = "numerosPositivos";
            // 
            // numMultiplosQuince
            // 
            this.numMultiplosQuince.HeaderText = "Cantidad de números que son múltiplos de 15 ";
            this.numMultiplosQuince.Name = "numMultiplosQuince";
            // 
            // valorAcumulado
            // 
            this.valorAcumulado.HeaderText = "Valor acumulado de los números pares ";
            this.valorAcumulado.Name = "valorAcumulado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 274);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button botonIngresarNum;
        private Label label1;
        private DataGridView datos;
        private DataGridViewTextBoxColumn numerosNegativos;
        private DataGridViewTextBoxColumn numerosPositivos;
        private DataGridViewTextBoxColumn numMultiplosQuince;
        private DataGridViewTextBoxColumn valorAcumulado;
        private Button salir;
    }
}