namespace capaPresentacionWF
{
    partial class fMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxSolicitud = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuarios = new System.Windows.Forms.PictureBox();
            this.pictureBoxRecursos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Acceder a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Solicitud";
            // 
            // pictureBoxSolicitud
            // 
            this.pictureBoxSolicitud.Image = global::capaPresentacionWF.Properties.Resources.entrevista;
            this.pictureBoxSolicitud.Location = new System.Drawing.Point(240, 331);
            this.pictureBoxSolicitud.Name = "pictureBoxSolicitud";
            this.pictureBoxSolicitud.Size = new System.Drawing.Size(100, 110);
            this.pictureBoxSolicitud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSolicitud.TabIndex = 2;
            this.pictureBoxSolicitud.TabStop = false;
            this.pictureBoxSolicitud.Click += new System.EventHandler(this.pictureBoxSolicitud_Click);
            // 
            // pictureBoxUsuarios
            // 
            this.pictureBoxUsuarios.Image = global::capaPresentacionWF.Properties.Resources.grupo;
            this.pictureBoxUsuarios.Location = new System.Drawing.Point(240, 215);
            this.pictureBoxUsuarios.Name = "pictureBoxUsuarios";
            this.pictureBoxUsuarios.Size = new System.Drawing.Size(100, 110);
            this.pictureBoxUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuarios.TabIndex = 1;
            this.pictureBoxUsuarios.TabStop = false;
            this.pictureBoxUsuarios.Click += new System.EventHandler(this.pictureBoxUsuarios_Click);
            // 
            // pictureBoxRecursos
            // 
            this.pictureBoxRecursos.Image = global::capaPresentacionWF.Properties.Resources.reunion;
            this.pictureBoxRecursos.Location = new System.Drawing.Point(240, 99);
            this.pictureBoxRecursos.Name = "pictureBoxRecursos";
            this.pictureBoxRecursos.Size = new System.Drawing.Size(100, 110);
            this.pictureBoxRecursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecursos.TabIndex = 0;
            this.pictureBoxRecursos.TabStop = false;
            this.pictureBoxRecursos.Click += new System.EventHandler(this.pictureBoxRecursos_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 483);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSolicitud);
            this.Controls.Add(this.pictureBoxUsuarios);
            this.Controls.Add(this.pictureBoxRecursos);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMenu";
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRecursos;
        private System.Windows.Forms.PictureBox pictureBoxUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}