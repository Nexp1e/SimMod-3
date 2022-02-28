namespace SimMod_3
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
            this.btnStart = new System.Windows.Forms.Button();
            this.inputRule = new System.Windows.Forms.NumericUpDown();
            this.labelInputRule = new System.Windows.Forms.Label();
            this.CellsTable = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(15, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start/Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // inputRule
            // 
            this.inputRule.Location = new System.Drawing.Point(47, 30);
            this.inputRule.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputRule.Name = "inputRule";
            this.inputRule.Size = new System.Drawing.Size(120, 20);
            this.inputRule.TabIndex = 1;
            this.inputRule.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // labelInputRule
            // 
            this.labelInputRule.AutoSize = true;
            this.labelInputRule.Location = new System.Drawing.Point(12, 32);
            this.labelInputRule.Name = "labelInputRule";
            this.labelInputRule.Size = new System.Drawing.Size(29, 13);
            this.labelInputRule.TabIndex = 2;
            this.labelInputRule.Text = "Rule";
            // 
            // CellsTable
            // 
            this.CellsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CellsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CellsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Cell1,
            this.Cell2,
            this.Cell3,
            this.Cell4,
            this.Cell5,
            this.Cell6,
            this.Cell7,
            this.Cell8,
            this.Cell9,
            this.Cell10,
            this.Cell11,
            this.Cell12});
            this.CellsTable.Location = new System.Drawing.Point(173, 12);
            this.CellsTable.MultiSelect = false;
            this.CellsTable.Name = "CellsTable";
            this.CellsTable.ReadOnly = true;
            this.CellsTable.RowHeadersWidth = 10;
            this.CellsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CellsTable.ShowEditingIcon = false;
            this.CellsTable.Size = new System.Drawing.Size(814, 497);
            this.CellsTable.TabIndex = 3;
            this.CellsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellTable1_CellClick);
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Cell1
            // 
            this.Cell1.HeaderText = "";
            this.Cell1.Name = "Cell1";
            this.Cell1.ReadOnly = true;
            // 
            // Cell2
            // 
            this.Cell2.HeaderText = "";
            this.Cell2.Name = "Cell2";
            this.Cell2.ReadOnly = true;
            // 
            // Cell3
            // 
            this.Cell3.HeaderText = "";
            this.Cell3.Name = "Cell3";
            this.Cell3.ReadOnly = true;
            // 
            // Cell4
            // 
            this.Cell4.HeaderText = "";
            this.Cell4.Name = "Cell4";
            this.Cell4.ReadOnly = true;
            // 
            // Cell5
            // 
            this.Cell5.HeaderText = "";
            this.Cell5.Name = "Cell5";
            this.Cell5.ReadOnly = true;
            // 
            // Cell6
            // 
            this.Cell6.HeaderText = "";
            this.Cell6.Name = "Cell6";
            this.Cell6.ReadOnly = true;
            // 
            // Cell7
            // 
            this.Cell7.HeaderText = "";
            this.Cell7.Name = "Cell7";
            this.Cell7.ReadOnly = true;
            // 
            // Cell8
            // 
            this.Cell8.HeaderText = "";
            this.Cell8.Name = "Cell8";
            this.Cell8.ReadOnly = true;
            // 
            // Cell9
            // 
            this.Cell9.HeaderText = "";
            this.Cell9.Name = "Cell9";
            this.Cell9.ReadOnly = true;
            // 
            // Cell10
            // 
            this.Cell10.HeaderText = "";
            this.Cell10.Name = "Cell10";
            this.Cell10.ReadOnly = true;
            // 
            // Cell11
            // 
            this.Cell11.HeaderText = "";
            this.Cell11.Name = "Cell11";
            this.Cell11.ReadOnly = true;
            // 
            // Cell12
            // 
            this.Cell12.HeaderText = "";
            this.Cell12.Name = "Cell12";
            this.Cell12.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 521);
            this.Controls.Add(this.CellsTable);
            this.Controls.Add(this.labelInputRule);
            this.Controls.Add(this.inputRule);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown inputRule;
        private System.Windows.Forms.Label labelInputRule;
        private System.Windows.Forms.DataGridView CellsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell12;
        private System.Windows.Forms.Timer timer1;
    }
}

