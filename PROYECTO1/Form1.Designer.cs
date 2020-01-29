namespace PROYECTO1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPro = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optMulti = new System.Windows.Forms.RadioButton();
            this.optDivi = new System.Windows.Forms.RadioButton();
            this.grbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.White;
            this.btnPro.Location = new System.Drawing.Point(38, 185);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(156, 32);
            this.btnPro.TabIndex = 0;
            this.btnPro.Text = "PROCESAR";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.Color.Black;
            this.txt1.Location = new System.Drawing.Point(116, 19);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(66, 31);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.Color.Black;
            this.txt2.Location = new System.Drawing.Point(116, 56);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(66, 31);
            this.txt2.TabIndex = 2;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Black;
            this.lblNum1.Location = new System.Drawing.Point(38, 22);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(72, 25);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "NUM1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Black;
            this.lblNum2.Location = new System.Drawing.Point(38, 59);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(72, 25);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "NUM2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "______________";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblAnswer.Location = new System.Drawing.Point(38, 123);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(175, 25);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "RESPUESTA: ¿?";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.grbOperaciones.Controls.Add(this.optDivi);
            this.grbOperaciones.Controls.Add(this.optMulti);
            this.grbOperaciones.Controls.Add(this.optResta);
            this.grbOperaciones.Controls.Add(this.optSuma);
            this.grbOperaciones.Location = new System.Drawing.Point(265, 22);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(157, 158);
            this.grbOperaciones.TabIndex = 7;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "OPERACIONES";
            this.grbOperaciones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSuma.ForeColor = System.Drawing.Color.Black;
            this.optSuma.Location = new System.Drawing.Point(6, 31);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(69, 22);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "SUMA";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optResta.ForeColor = System.Drawing.Color.Black;
            this.optResta.Location = new System.Drawing.Point(6, 59);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(75, 22);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "RESTA";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optMulti
            // 
            this.optMulti.AutoSize = true;
            this.optMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMulti.ForeColor = System.Drawing.Color.Black;
            this.optMulti.Location = new System.Drawing.Point(6, 87);
            this.optMulti.Name = "optMulti";
            this.optMulti.Size = new System.Drawing.Size(148, 22);
            this.optMulti.TabIndex = 2;
            this.optMulti.Text = "MULTIPLICACION";
            this.optMulti.UseVisualStyleBackColor = true;
            // 
            // optDivi
            // 
            this.optDivi.AutoSize = true;
            this.optDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDivi.ForeColor = System.Drawing.Color.Black;
            this.optDivi.Location = new System.Drawing.Point(6, 115);
            this.optDivi.Name = "optDivi";
            this.optDivi.Size = new System.Drawing.Size(88, 22);
            this.optDivi.TabIndex = 3;
            this.optDivi.Text = "DIVISION";
            this.optDivi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 252);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnPro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOperaciones.ResumeLayout(false);
            this.grbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.RadioButton optDivi;
        private System.Windows.Forms.RadioButton optMulti;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
    }
}

