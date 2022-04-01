namespace Lab_1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCTNBRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYMBOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHARESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOLDINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Lab_1.Database1DataSet();
            this.hOLDINGSTableAdapter = new Lab_1.Database1DataSetTableAdapters.HOLDINGSTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iNDUSTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNDUSTRYTableAdapter = new Lab_1.Database1DataSetTableAdapters.INDUSTRYTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lONGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASTERTableAdapter = new Lab_1.Database1DataSetTableAdapters.MASTERTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYMBOLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXCHANGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yRLHIGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yRLLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERATIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRTHGRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDUSTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICECHGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAFETYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTLOOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCMNDATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rISKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOLDINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNDUSTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться в главное окно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOLDINGS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Запрос";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INDUSTRY";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Запрос";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MASTER";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Запрос";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aCCTNBRDataGridViewTextBoxColumn,
            this.sYMBOLDataGridViewTextBoxColumn,
            this.sHARESDataGridViewTextBoxColumn,
            this.pURPRICEDataGridViewTextBoxColumn,
            this.pURDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOLDINGSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 274);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCCTNBRDataGridViewTextBoxColumn
            // 
            this.aCCTNBRDataGridViewTextBoxColumn.DataPropertyName = "ACCT_NBR";
            this.aCCTNBRDataGridViewTextBoxColumn.HeaderText = "ACCT_NBR";
            this.aCCTNBRDataGridViewTextBoxColumn.Name = "aCCTNBRDataGridViewTextBoxColumn";
            // 
            // sYMBOLDataGridViewTextBoxColumn
            // 
            this.sYMBOLDataGridViewTextBoxColumn.DataPropertyName = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn.HeaderText = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn.Name = "sYMBOLDataGridViewTextBoxColumn";
            // 
            // sHARESDataGridViewTextBoxColumn
            // 
            this.sHARESDataGridViewTextBoxColumn.DataPropertyName = "SHARES";
            this.sHARESDataGridViewTextBoxColumn.HeaderText = "SHARES";
            this.sHARESDataGridViewTextBoxColumn.Name = "sHARESDataGridViewTextBoxColumn";
            // 
            // pURPRICEDataGridViewTextBoxColumn
            // 
            this.pURPRICEDataGridViewTextBoxColumn.DataPropertyName = "PUR_PRICE";
            this.pURPRICEDataGridViewTextBoxColumn.HeaderText = "PUR_PRICE";
            this.pURPRICEDataGridViewTextBoxColumn.Name = "pURPRICEDataGridViewTextBoxColumn";
            // 
            // pURDATEDataGridViewTextBoxColumn
            // 
            this.pURDATEDataGridViewTextBoxColumn.DataPropertyName = "PUR_DATE";
            this.pURDATEDataGridViewTextBoxColumn.HeaderText = "PUR_DATE";
            this.pURDATEDataGridViewTextBoxColumn.Name = "pURDATEDataGridViewTextBoxColumn";
            // 
            // hOLDINGSBindingSource
            // 
            this.hOLDINGSBindingSource.DataMember = "HOLDINGS";
            this.hOLDINGSBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOLDINGSTableAdapter
            // 
            this.hOLDINGSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.iNDCODEDataGridViewTextBoxColumn,
            this.iNDNAMEDataGridViewTextBoxColumn,
            this.lONGNAMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.iNDUSTRYBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 274);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.sYMBOLDataGridViewTextBoxColumn1,
            this.cONAMEDataGridViewTextBoxColumn,
            this.eXCHANGEDataGridViewTextBoxColumn,
            this.cURPRICEDataGridViewTextBoxColumn,
            this.yRLHIGHDataGridViewTextBoxColumn,
            this.yRLLOWDataGridViewTextBoxColumn,
            this.pERATIODataGridViewTextBoxColumn,
            this.bETADataGridViewTextBoxColumn,
            this.gRTHGRTHDataGridViewTextBoxColumn,
            this.iNDUSTRYDataGridViewTextBoxColumn,
            this.pRICECHGDataGridViewTextBoxColumn,
            this.sAFETYDataGridViewTextBoxColumn,
            this.rATINGDataGridViewTextBoxColumn,
            this.rANKDataGridViewTextBoxColumn,
            this.oUTLOOKDataGridViewTextBoxColumn,
            this.rCMNDATIONDataGridViewTextBoxColumn,
            this.rISKDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.mASTERBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(756, 271);
            this.dataGridView3.TabIndex = 1;
            // 
            // iNDUSTRYBindingSource
            // 
            this.iNDUSTRYBindingSource.DataMember = "INDUSTRY";
            this.iNDUSTRYBindingSource.DataSource = this.database1DataSet;
            // 
            // iNDUSTRYTableAdapter
            // 
            this.iNDUSTRYTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iNDCODEDataGridViewTextBoxColumn
            // 
            this.iNDCODEDataGridViewTextBoxColumn.DataPropertyName = "IND_CODE";
            this.iNDCODEDataGridViewTextBoxColumn.HeaderText = "IND_CODE";
            this.iNDCODEDataGridViewTextBoxColumn.Name = "iNDCODEDataGridViewTextBoxColumn";
            // 
            // iNDNAMEDataGridViewTextBoxColumn
            // 
            this.iNDNAMEDataGridViewTextBoxColumn.DataPropertyName = "IND_NAME";
            this.iNDNAMEDataGridViewTextBoxColumn.HeaderText = "IND_NAME";
            this.iNDNAMEDataGridViewTextBoxColumn.Name = "iNDNAMEDataGridViewTextBoxColumn";
            // 
            // lONGNAMEDataGridViewTextBoxColumn
            // 
            this.lONGNAMEDataGridViewTextBoxColumn.DataPropertyName = "LONG_NAME";
            this.lONGNAMEDataGridViewTextBoxColumn.HeaderText = "LONG_NAME";
            this.lONGNAMEDataGridViewTextBoxColumn.Name = "lONGNAMEDataGridViewTextBoxColumn";
            // 
            // mASTERBindingSource
            // 
            this.mASTERBindingSource.DataMember = "MASTER";
            this.mASTERBindingSource.DataSource = this.database1DataSet;
            // 
            // mASTERTableAdapter
            // 
            this.mASTERTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sYMBOLDataGridViewTextBoxColumn1
            // 
            this.sYMBOLDataGridViewTextBoxColumn1.DataPropertyName = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn1.HeaderText = "SYMBOL";
            this.sYMBOLDataGridViewTextBoxColumn1.Name = "sYMBOLDataGridViewTextBoxColumn1";
            // 
            // cONAMEDataGridViewTextBoxColumn
            // 
            this.cONAMEDataGridViewTextBoxColumn.DataPropertyName = "CO_NAME";
            this.cONAMEDataGridViewTextBoxColumn.HeaderText = "CO_NAME";
            this.cONAMEDataGridViewTextBoxColumn.Name = "cONAMEDataGridViewTextBoxColumn";
            // 
            // eXCHANGEDataGridViewTextBoxColumn
            // 
            this.eXCHANGEDataGridViewTextBoxColumn.DataPropertyName = "EXCHANGE";
            this.eXCHANGEDataGridViewTextBoxColumn.HeaderText = "EXCHANGE";
            this.eXCHANGEDataGridViewTextBoxColumn.Name = "eXCHANGEDataGridViewTextBoxColumn";
            // 
            // cURPRICEDataGridViewTextBoxColumn
            // 
            this.cURPRICEDataGridViewTextBoxColumn.DataPropertyName = "CUR-PRICE";
            this.cURPRICEDataGridViewTextBoxColumn.HeaderText = "CUR-PRICE";
            this.cURPRICEDataGridViewTextBoxColumn.Name = "cURPRICEDataGridViewTextBoxColumn";
            // 
            // yRLHIGHDataGridViewTextBoxColumn
            // 
            this.yRLHIGHDataGridViewTextBoxColumn.DataPropertyName = "YRL_HIGH";
            this.yRLHIGHDataGridViewTextBoxColumn.HeaderText = "YRL_HIGH";
            this.yRLHIGHDataGridViewTextBoxColumn.Name = "yRLHIGHDataGridViewTextBoxColumn";
            // 
            // yRLLOWDataGridViewTextBoxColumn
            // 
            this.yRLLOWDataGridViewTextBoxColumn.DataPropertyName = "YRL_LOW";
            this.yRLLOWDataGridViewTextBoxColumn.HeaderText = "YRL_LOW";
            this.yRLLOWDataGridViewTextBoxColumn.Name = "yRLLOWDataGridViewTextBoxColumn";
            // 
            // pERATIODataGridViewTextBoxColumn
            // 
            this.pERATIODataGridViewTextBoxColumn.DataPropertyName = "P_E_RATIO";
            this.pERATIODataGridViewTextBoxColumn.HeaderText = "P_E_RATIO";
            this.pERATIODataGridViewTextBoxColumn.Name = "pERATIODataGridViewTextBoxColumn";
            // 
            // bETADataGridViewTextBoxColumn
            // 
            this.bETADataGridViewTextBoxColumn.DataPropertyName = "BETA";
            this.bETADataGridViewTextBoxColumn.HeaderText = "BETA";
            this.bETADataGridViewTextBoxColumn.Name = "bETADataGridViewTextBoxColumn";
            // 
            // gRTHGRTHDataGridViewTextBoxColumn
            // 
            this.gRTHGRTHDataGridViewTextBoxColumn.DataPropertyName = "GRTH_GRTH";
            this.gRTHGRTHDataGridViewTextBoxColumn.HeaderText = "GRTH_GRTH";
            this.gRTHGRTHDataGridViewTextBoxColumn.Name = "gRTHGRTHDataGridViewTextBoxColumn";
            // 
            // iNDUSTRYDataGridViewTextBoxColumn
            // 
            this.iNDUSTRYDataGridViewTextBoxColumn.DataPropertyName = "INDUSTRY";
            this.iNDUSTRYDataGridViewTextBoxColumn.HeaderText = "INDUSTRY";
            this.iNDUSTRYDataGridViewTextBoxColumn.Name = "iNDUSTRYDataGridViewTextBoxColumn";
            // 
            // pRICECHGDataGridViewTextBoxColumn
            // 
            this.pRICECHGDataGridViewTextBoxColumn.DataPropertyName = "PRICE_CHG";
            this.pRICECHGDataGridViewTextBoxColumn.HeaderText = "PRICE_CHG";
            this.pRICECHGDataGridViewTextBoxColumn.Name = "pRICECHGDataGridViewTextBoxColumn";
            // 
            // sAFETYDataGridViewTextBoxColumn
            // 
            this.sAFETYDataGridViewTextBoxColumn.DataPropertyName = "SAFETY";
            this.sAFETYDataGridViewTextBoxColumn.HeaderText = "SAFETY";
            this.sAFETYDataGridViewTextBoxColumn.Name = "sAFETYDataGridViewTextBoxColumn";
            // 
            // rATINGDataGridViewTextBoxColumn
            // 
            this.rATINGDataGridViewTextBoxColumn.DataPropertyName = "RATING";
            this.rATINGDataGridViewTextBoxColumn.HeaderText = "RATING";
            this.rATINGDataGridViewTextBoxColumn.Name = "rATINGDataGridViewTextBoxColumn";
            // 
            // rANKDataGridViewTextBoxColumn
            // 
            this.rANKDataGridViewTextBoxColumn.DataPropertyName = "RANK";
            this.rANKDataGridViewTextBoxColumn.HeaderText = "RANK";
            this.rANKDataGridViewTextBoxColumn.Name = "rANKDataGridViewTextBoxColumn";
            // 
            // oUTLOOKDataGridViewTextBoxColumn
            // 
            this.oUTLOOKDataGridViewTextBoxColumn.DataPropertyName = "OUTLOOK";
            this.oUTLOOKDataGridViewTextBoxColumn.HeaderText = "OUTLOOK";
            this.oUTLOOKDataGridViewTextBoxColumn.Name = "oUTLOOKDataGridViewTextBoxColumn";
            // 
            // rCMNDATIONDataGridViewTextBoxColumn
            // 
            this.rCMNDATIONDataGridViewTextBoxColumn.DataPropertyName = "RCMNDATION";
            this.rCMNDATIONDataGridViewTextBoxColumn.HeaderText = "RCMNDATION";
            this.rCMNDATIONDataGridViewTextBoxColumn.Name = "rCMNDATIONDataGridViewTextBoxColumn";
            // 
            // rISKDataGridViewTextBoxColumn
            // 
            this.rISKDataGridViewTextBoxColumn.DataPropertyName = "RISK";
            this.rISKDataGridViewTextBoxColumn.HeaderText = "RISK";
            this.rISKDataGridViewTextBoxColumn.Name = "rISKDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Лабораторная работа №1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOLDINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNDUSTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource hOLDINGSBindingSource;
        private Database1DataSetTableAdapters.HOLDINGSTableAdapter hOLDINGSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCTNBRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYMBOLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource iNDUSTRYBindingSource;
        private Database1DataSetTableAdapters.INDUSTRYTableAdapter iNDUSTRYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lONGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mASTERBindingSource;
        private Database1DataSetTableAdapters.MASTERTableAdapter mASTERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYMBOLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXCHANGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yRLHIGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yRLLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERATIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRTHGRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDUSTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICECHGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAFETYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTLOOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCMNDATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rISKDataGridViewTextBoxColumn;
    }
}