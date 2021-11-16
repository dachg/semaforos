
namespace Cliente
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
            this.g1_red = new System.Windows.Forms.Panel();
            this.g1_yellow = new System.Windows.Forms.Panel();
            this.g1_green = new System.Windows.Forms.Panel();
            this.g2_red = new System.Windows.Forms.Panel();
            this.g2_yellow = new System.Windows.Forms.Panel();
            this.g2_green = new System.Windows.Forms.Panel();
            this.label111 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.g1_report = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.TextBox();
            this.g1_amount = new System.Windows.Forms.NumericUpDown();
            this.g1_ligth = new System.Windows.Forms.NumericUpDown();
            this.g2_amount = new System.Windows.Forms.NumericUpDown();
            this.g2_ligth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.g1_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1_ligth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g2_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g2_ligth)).BeginInit();
            this.SuspendLayout();
            // 
            // g1_red
            // 
            this.g1_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.g1_red.Location = new System.Drawing.Point(204, 82);
            this.g1_red.Name = "g1_red";
            this.g1_red.Size = new System.Drawing.Size(50, 50);
            this.g1_red.TabIndex = 0;
            // 
            // g1_yellow
            // 
            this.g1_yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.g1_yellow.Location = new System.Drawing.Point(204, 138);
            this.g1_yellow.Name = "g1_yellow";
            this.g1_yellow.Size = new System.Drawing.Size(50, 50);
            this.g1_yellow.TabIndex = 1;
            // 
            // g1_green
            // 
            this.g1_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.g1_green.Location = new System.Drawing.Point(204, 194);
            this.g1_green.Name = "g1_green";
            this.g1_green.Size = new System.Drawing.Size(50, 50);
            this.g1_green.TabIndex = 1;
            // 
            // g2_red
            // 
            this.g2_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.g2_red.Location = new System.Drawing.Point(539, 82);
            this.g2_red.Name = "g2_red";
            this.g2_red.Size = new System.Drawing.Size(50, 50);
            this.g2_red.TabIndex = 0;
            // 
            // g2_yellow
            // 
            this.g2_yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.g2_yellow.Location = new System.Drawing.Point(539, 138);
            this.g2_yellow.Name = "g2_yellow";
            this.g2_yellow.Size = new System.Drawing.Size(50, 50);
            this.g2_yellow.TabIndex = 1;
            // 
            // g2_green
            // 
            this.g2_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.g2_green.Location = new System.Drawing.Point(539, 194);
            this.g2_green.Name = "g2_green";
            this.g2_green.Size = new System.Drawing.Size(50, 50);
            this.g2_green.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(209, 39);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(45, 13);
            this.label111.TabIndex = 2;
            this.label111.Text = "Grupo 1";
            this.label111.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo 2";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de semáforos";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Luces fallando";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // g1_report
            // 
            this.g1_report.Location = new System.Drawing.Point(204, 333);
            this.g1_report.Name = "g1_report";
            this.g1_report.Size = new System.Drawing.Size(90, 23);
            this.g1_report.TabIndex = 4;
            this.g1_report.Text = "Enviar reporte";
            this.g1_report.UseVisualStyleBackColor = true;
            this.g1_report.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad de semáforos";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Luces fallando";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id cliente";
            // 
            // clientId
            // 
            this.clientId.Location = new System.Drawing.Point(344, 394);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(100, 20);
            this.clientId.TabIndex = 7;
            // 
            // g1_amount
            // 
            this.g1_amount.Location = new System.Drawing.Point(194, 277);
            this.g1_amount.Name = "g1_amount";
            this.g1_amount.Size = new System.Drawing.Size(120, 20);
            this.g1_amount.TabIndex = 8;
            // 
            // g1_ligth
            // 
            this.g1_ligth.Location = new System.Drawing.Point(194, 307);
            this.g1_ligth.Name = "g1_ligth";
            this.g1_ligth.Size = new System.Drawing.Size(120, 20);
            this.g1_ligth.TabIndex = 9;
            this.g1_ligth.ValueChanged += new System.EventHandler(this.g1_ligth_ValueChanged);
            // 
            // g2_amount
            // 
            this.g2_amount.Location = new System.Drawing.Point(529, 277);
            this.g2_amount.Name = "g2_amount";
            this.g2_amount.Size = new System.Drawing.Size(120, 20);
            this.g2_amount.TabIndex = 10;
            // 
            // g2_ligth
            // 
            this.g2_ligth.Location = new System.Drawing.Point(529, 308);
            this.g2_ligth.Name = "g2_ligth";
            this.g2_ligth.Size = new System.Drawing.Size(120, 20);
            this.g2_ligth.TabIndex = 11;
            this.g2_ligth.ValueChanged += new System.EventHandler(this.g2_ligth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.g2_ligth);
            this.Controls.Add(this.g2_amount);
            this.Controls.Add(this.g1_ligth);
            this.Controls.Add(this.g1_amount);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.g1_report);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.g2_green);
            this.Controls.Add(this.g1_green);
            this.Controls.Add(this.g2_yellow);
            this.Controls.Add(this.g2_red);
            this.Controls.Add(this.g1_yellow);
            this.Controls.Add(this.g1_red);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g1_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g1_ligth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g2_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g2_ligth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel g1_red;
        private System.Windows.Forms.Panel g1_yellow;
        private System.Windows.Forms.Panel g1_green;
        private System.Windows.Forms.Panel g2_red;
        private System.Windows.Forms.Panel g2_yellow;
        private System.Windows.Forms.Panel g2_green;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button g1_report;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.NumericUpDown g1_amount;
        private System.Windows.Forms.NumericUpDown g1_ligth;
        private System.Windows.Forms.NumericUpDown g2_amount;
        private System.Windows.Forms.NumericUpDown g2_ligth;
    }
}

