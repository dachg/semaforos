
namespace server
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
            this.components = new System.ComponentModel.Container();
            this.dataTrafficLight = new System.Windows.Forms.DataGridView();
            this.trafficLightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.timerLight = new System.Windows.Forms.Timer(this.components);
            this.numberLigthsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrafficLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTrafficLight
            // 
            this.dataTrafficLight.AutoGenerateColumns = false;
            this.dataTrafficLight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrafficLight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberLigthsDataGridViewTextBoxColumn,
            this.numberFailsDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn});
            this.dataTrafficLight.DataSource = this.trafficLightBindingSource;
            this.dataTrafficLight.Location = new System.Drawing.Point(334, 13);
            this.dataTrafficLight.Name = "dataTrafficLight";
            this.dataTrafficLight.ReadOnly = true;
            this.dataTrafficLight.Size = new System.Drawing.Size(379, 226);
            this.dataTrafficLight.TabIndex = 0;
            // 
            // trafficLightBindingSource
            // 
            this.trafficLightBindingSource.DataSource = typeof(DataInformation.TrafficLight);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "color";
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(142, 56);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(121, 21);
            this.comboGroup.TabIndex = 6;
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(142, 95);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(121, 21);
            this.comboColor.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(109, 148);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // timerLight
            // 
            this.timerLight.Tick += new System.EventHandler(this.timerLight_Tick);
            // 
            // numberLigthsDataGridViewTextBoxColumn
            // 
            this.numberLigthsDataGridViewTextBoxColumn.DataPropertyName = "NumberLigths";
            this.numberLigthsDataGridViewTextBoxColumn.HeaderText = "NumberLigths";
            this.numberLigthsDataGridViewTextBoxColumn.Name = "numberLigthsDataGridViewTextBoxColumn";
            this.numberLigthsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberFailsDataGridViewTextBoxColumn
            // 
            this.numberFailsDataGridViewTextBoxColumn.DataPropertyName = "NumberFails";
            this.numberFailsDataGridViewTextBoxColumn.HeaderText = "NumberFails";
            this.numberFailsDataGridViewTextBoxColumn.Name = "numberFailsDataGridViewTextBoxColumn";
            this.numberFailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataTrafficLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTrafficLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLightBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource trafficLightBindingSource;
        private System.Windows.Forms.DataGridView dataTrafficLight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Timer timerLight;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberLigthsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
    }
}

