namespace E5_G2
{
    partial class Form1
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnClick1 = new System.Windows.Forms.Button();
            this.btnClick2 = new System.Windows.Forms.Button();
            this.btnClick3 = new System.Windows.Forms.Button();
            this.btnClick4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listArreglo = new System.Windows.Forms.ListBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(505, 29);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnClick1
            // 
            this.btnClick1.Location = new System.Drawing.Point(505, 126);
            this.btnClick1.Name = "btnClick1";
            this.btnClick1.Size = new System.Drawing.Size(75, 23);
            this.btnClick1.TabIndex = 1;
            this.btnClick1.Text = "MOSTRAR";
            this.btnClick1.UseVisualStyleBackColor = true;
            this.btnClick1.Click += new System.EventHandler(this.btnClick1_Click);
            // 
            // btnClick2
            // 
            this.btnClick2.Location = new System.Drawing.Point(505, 177);
            this.btnClick2.Name = "btnClick2";
            this.btnClick2.Size = new System.Drawing.Size(75, 23);
            this.btnClick2.TabIndex = 2;
            this.btnClick2.Text = "MOSTRAR";
            this.btnClick2.UseVisualStyleBackColor = true;
            this.btnClick2.Click += new System.EventHandler(this.btnClick2_Click);
            // 
            // btnClick3
            // 
            this.btnClick3.Location = new System.Drawing.Point(505, 225);
            this.btnClick3.Name = "btnClick3";
            this.btnClick3.Size = new System.Drawing.Size(75, 23);
            this.btnClick3.TabIndex = 3;
            this.btnClick3.Text = "MOSTRAR";
            this.btnClick3.UseVisualStyleBackColor = true;
            this.btnClick3.Click += new System.EventHandler(this.btnClick3_Click);
            // 
            // btnClick4
            // 
            this.btnClick4.Location = new System.Drawing.Point(505, 269);
            this.btnClick4.Name = "btnClick4";
            this.btnClick4.Size = new System.Drawing.Size(75, 23);
            this.btnClick4.TabIndex = 4;
            this.btnClick4.Text = "MOSTRAR";
            this.btnClick4.UseVisualStyleBackColor = true;
            this.btnClick4.Click += new System.EventHandler(this.btnClick4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero mayor de pages negativos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Porcentaje de ceros en el arreglo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio de impares positivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mayor de los pares positivos";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(385, 129);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 9;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(385, 180);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 10;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(385, 228);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 11;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(385, 272);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingrese un valor al arreglo";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(185, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 236);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLOS";
            // 
            // listArreglo
            // 
            this.listArreglo.FormattingEnabled = true;
            this.listArreglo.Location = new System.Drawing.Point(36, 88);
            this.listArreglo.Name = "listArreglo";
            this.listArreglo.Size = new System.Drawing.Size(120, 238);
            this.listArreglo.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(185, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(300, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 363);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.listArreglo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick4);
            this.Controls.Add(this.btnClick3);
            this.Controls.Add(this.btnClick2);
            this.Controls.Add(this.btnClick1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnClick1;
        private System.Windows.Forms.Button btnClick2;
        private System.Windows.Forms.Button btnClick3;
        private System.Windows.Forms.Button btnClick4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listArreglo;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

