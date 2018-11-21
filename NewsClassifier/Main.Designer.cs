namespace NewsClassifier
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labF1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labRecall = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labPrecision = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboM = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btn_classify = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prediction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Content,
            this.Prediction,
            this.Real,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(726, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labF1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labRecall);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labPrecision);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Performance metrics";
            // 
            // labF1
            // 
            this.labF1.AutoSize = true;
            this.labF1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labF1.Location = new System.Drawing.Point(270, 34);
            this.labF1.Name = "labF1";
            this.labF1.Size = new System.Drawing.Size(20, 22);
            this.labF1.TabIndex = 5;
            this.labF1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "F1:";
            // 
            // labRecall
            // 
            this.labRecall.AutoSize = true;
            this.labRecall.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRecall.Location = new System.Drawing.Point(177, 34);
            this.labRecall.Name = "labRecall";
            this.labRecall.Size = new System.Drawing.Size(20, 22);
            this.labRecall.TabIndex = 3;
            this.labRecall.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(137, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recall:";
            // 
            // labPrecision
            // 
            this.labPrecision.AutoSize = true;
            this.labPrecision.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPrecision.Location = new System.Drawing.Point(61, 34);
            this.labPrecision.Name = "labPrecision";
            this.labPrecision.Size = new System.Drawing.Size(20, 22);
            this.labPrecision.TabIndex = 1;
            this.labPrecision.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precision:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_classify);
            this.groupBox2.Controls.Add(this.comboM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(584, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classification";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnAddText);
            this.groupBox3.Controls.Add(this.numTo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.numFrom);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(349, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 81);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // comboM
            // 
            this.comboM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboM.FormattingEnabled = true;
            this.comboM.Items.AddRange(new object[] {
            "Feedforward MLP"});
            this.comboM.Location = new System.Drawing.Point(6, 17);
            this.comboM.Name = "comboM";
            this.comboM.Size = new System.Drawing.Size(142, 23);
            this.comboM.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "ID from:";
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(63, 21);
            this.numFrom.Maximum = new decimal(new int[] {
            21578,
            0,
            0,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(62, 21);
            this.numFrom.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "to:";
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(63, 47);
            this.numTo.Maximum = new decimal(new int[] {
            21578,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(62, 21);
            this.numTo.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "or";
            // 
            // btnAddText
            // 
            this.btnAddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddText.Image = global::NewsClassifier.Properties.Resources.newspaper_add;
            this.btnAddText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddText.Location = new System.Drawing.Point(147, 22);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(76, 42);
            this.btnAddText.TabIndex = 2;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btn_classify
            // 
            this.btn_classify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_classify.Image = global::NewsClassifier.Properties.Resources.tag_red;
            this.btn_classify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_classify.Location = new System.Drawing.Point(6, 43);
            this.btn_classify.Name = "btn_classify";
            this.btn_classify.Size = new System.Drawing.Size(142, 30);
            this.btn_classify.TabIndex = 0;
            this.btn_classify.Text = "Classify!";
            this.btn_classify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_classify.UseVisualStyleBackColor = true;
            this.btn_classify.Click += new System.EventHandler(this.btn_classify_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.DataPropertyName = "Text";
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // Prediction
            // 
            this.Prediction.DataPropertyName = "Prediction";
            this.Prediction.HeaderText = "Prediction";
            this.Prediction.Name = "Prediction";
            this.Prediction.ReadOnly = true;
            this.Prediction.Width = 200;
            // 
            // Real
            // 
            this.Real.DataPropertyName = "TrueLabels";
            this.Real.HeaderText = "Real Label";
            this.Real.Name = "Real";
            this.Real.ReadOnly = true;
            this.Real.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(766, 300);
            this.Name = "Main";
            this.Text = "News Classifier Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labF1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labRecall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPrecision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_classify;
        private System.Windows.Forms.ComboBox comboM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prediction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Real;
        private System.Windows.Forms.DataGridViewImageColumn Status;
    }
}

