﻿namespace SQLite_Assignment
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnTotalPopulation = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.radFindByName = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvCity
            // 
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(16, 17);
            this.dgvCity.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.Size = new System.Drawing.Size(361, 346);
            this.dgvCity.TabIndex = 40;
            this.dgvCity.SelectionChanged += new System.EventHandler(this.dgvCity_SelectionChanged);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(427, 91);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(205, 28);
            this.btnAverage.TabIndex = 39;
            this.btnAverage.Text = "Average population (all cities)";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnTotalPopulation
            // 
            this.btnTotalPopulation.Location = new System.Drawing.Point(427, 55);
            this.btnTotalPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalPopulation.Name = "btnTotalPopulation";
            this.btnTotalPopulation.Size = new System.Drawing.Size(205, 28);
            this.btnTotalPopulation.TabIndex = 38;
            this.btnTotalPopulation.Text = "Total population (all cities)";
            this.btnTotalPopulation.UseVisualStyleBackColor = true;
            this.btnTotalPopulation.Click += new System.EventHandler(this.btnTotalPopulation_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // radFindByName
            // 
            this.radFindByName.AutoSize = true;
            this.radFindByName.Location = new System.Drawing.Point(525, 201);
            this.radFindByName.Margin = new System.Windows.Forms.Padding(4);
            this.radFindByName.Name = "radFindByName";
            this.radFindByName.Size = new System.Drawing.Size(116, 21);
            this.radFindByName.TabIndex = 51;
            this.radFindByName.Text = "Find by Name";
            this.radFindByName.UseVisualStyleBackColor = true;
            this.radFindByName.CheckedChanged += new System.EventHandler(this.radFindByName_CheckedChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(440, 335);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(205, 28);
            this.btnProcess.TabIndex = 50;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(443, 201);
            this.radEdit.Margin = new System.Windows.Forms.Padding(4);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(53, 21);
            this.radEdit.TabIndex = 49;
            this.radEdit.Text = "Edit";
            this.radEdit.UseVisualStyleBackColor = true;
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(525, 172);
            this.radDelete.Margin = new System.Windows.Forms.Padding(4);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(70, 21);
            this.radDelete.TabIndex = 48;
            this.radDelete.Text = "Delete";
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(440, 172);
            this.radAdd.Margin = new System.Windows.Forms.Padding(4);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(54, 21);
            this.radAdd.TabIndex = 47;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(512, 292);
            this.txtPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(132, 22);
            this.txtPopulation.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Population:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(512, 260);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 22);
            this.txtCity.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "City:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(427, 16);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(205, 28);
            this.btnShowAll.TabIndex = 42;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 416);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCity);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnTotalPopulation);
            this.Controls.Add(this.radFindByName);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.radEdit);
            this.Controls.Add(this.radDelete);
            this.Controls.Add(this.radAdd);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Populations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnTotalPopulation;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.RadioButton radFindByName;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
    }
}

