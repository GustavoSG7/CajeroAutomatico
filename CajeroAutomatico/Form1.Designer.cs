namespace CajeroAutomatico
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
            this.txtiden = new System.Windows.Forms.TextBox();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtiden
            // 
            this.txtiden.AccessibleDescription = "";
            this.txtiden.AccessibleName = "";
            this.txtiden.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtiden.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiden.Location = new System.Drawing.Point(135, 169);
            this.txtiden.Name = "txtiden";
            this.txtiden.Size = new System.Drawing.Size(256, 25);
            this.txtiden.TabIndex = 3;
            this.txtiden.Text = "USUARIO";
            this.txtiden.Click += new System.EventHandler(this.txtiden_Click);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(135, 251);
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(256, 25);
            this.txtpin.TabIndex = 4;
            this.txtpin.Text = "PIN DE USUARIO";
            this.txtpin.Click += new System.EventHandler(this.txtpin_Click);
            // 
            // btningresar
            // 
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(199, 311);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(124, 52);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 450);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "BIENVENIDO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtpin);
            this.Controls.Add(this.txtiden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtiden;
        private System.Windows.Forms.TextBox txtpin;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

