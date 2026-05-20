namespace dad_ZamfirTamina.Forms
{
    partial class frmRulaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRulaje));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bsOperatie = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDoc = new System.Windows.Forms.DateTimePicker();
            this.txtAplicatie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsConturi = new System.Windows.Forms.BindingSource(this.components);
            this.sumaDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRulajeOperatie = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConturi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRulajeOperatie)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bsOperatie;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bsOperatie
            // 
            this.bsOperatie.DataSource = typeof(dad_ZamfirTamina.Operatie);
            this.bsOperatie.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // txtNumar
            // 
            this.txtNumar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOperatie, "Numar", true));
            this.txtNumar.Location = new System.Drawing.Point(81, 45);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(268, 22);
            this.txtNumar.TabIndex = 1;
            // 
            // txtDoc
            // 
            this.txtDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOperatie, "Doc", true));
            this.txtDoc.Location = new System.Drawing.Point(454, 45);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(287, 22);
            this.txtDoc.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOperatie, "Data", true));
            this.dtpData.Location = new System.Drawing.Point(81, 85);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(268, 22);
            this.dtpData.TabIndex = 3;
            // 
            // dtpDataDoc
            // 
            this.dtpDataDoc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOperatie, "DataDoc", true));
            this.dtpDataDoc.Location = new System.Drawing.Point(454, 85);
            this.dtpDataDoc.Name = "dtpDataDoc";
            this.dtpDataDoc.Size = new System.Drawing.Size(287, 22);
            this.dtpDataDoc.TabIndex = 4;
            // 
            // txtAplicatie
            // 
            this.txtAplicatie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOperatie, "Explicatie", true));
            this.txtAplicatie.Location = new System.Drawing.Point(81, 118);
            this.txtAplicatie.Name = "txtAplicatie";
            this.txtAplicatie.Size = new System.Drawing.Size(660, 22);
            this.txtAplicatie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Doc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Explicatie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idContDataGridViewTextBoxColumn,
            this.idOperatieDataGridViewTextBoxColumn,
            this.contDataGridViewTextBoxColumn,
            this.sumaDDataGridViewTextBoxColumn,
            this.sumaCDataGridViewTextBoxColumn,
            this.operatieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsRulajeOperatie;
            this.dataGridView1.Location = new System.Drawing.Point(10, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 240);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idContDataGridViewTextBoxColumn
            // 
            this.idContDataGridViewTextBoxColumn.DataPropertyName = "IdCont";
            this.idContDataGridViewTextBoxColumn.HeaderText = "IdCont";
            this.idContDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idContDataGridViewTextBoxColumn.Name = "idContDataGridViewTextBoxColumn";
            this.idContDataGridViewTextBoxColumn.Visible = false;
            this.idContDataGridViewTextBoxColumn.Width = 125;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.Visible = false;
            this.idOperatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // contDataGridViewTextBoxColumn
            // 
            this.contDataGridViewTextBoxColumn.DataPropertyName = "IdCont";
            this.contDataGridViewTextBoxColumn.DataSource = this.bsConturi;
            this.contDataGridViewTextBoxColumn.DisplayMember = "Simbol";
            this.contDataGridViewTextBoxColumn.HeaderText = "Cont";
            this.contDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contDataGridViewTextBoxColumn.Name = "contDataGridViewTextBoxColumn";
            this.contDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contDataGridViewTextBoxColumn.ValueMember = "Id";
            this.contDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsConturi
            // 
            this.bsConturi.DataSource = typeof(dad_ZamfirTamina.Cont);
            // 
            // sumaDDataGridViewTextBoxColumn
            // 
            this.sumaDDataGridViewTextBoxColumn.DataPropertyName = "SumaD";
            this.sumaDDataGridViewTextBoxColumn.HeaderText = "SumaD";
            this.sumaDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaDDataGridViewTextBoxColumn.Name = "sumaDDataGridViewTextBoxColumn";
            this.sumaDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaCDataGridViewTextBoxColumn
            // 
            this.sumaCDataGridViewTextBoxColumn.DataPropertyName = "SumaC";
            this.sumaCDataGridViewTextBoxColumn.HeaderText = "SumaC";
            this.sumaCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaCDataGridViewTextBoxColumn.Name = "sumaCDataGridViewTextBoxColumn";
            this.sumaCDataGridViewTextBoxColumn.Width = 125;
            // 
            // operatieDataGridViewTextBoxColumn
            // 
            this.operatieDataGridViewTextBoxColumn.DataPropertyName = "Operatie";
            this.operatieDataGridViewTextBoxColumn.HeaderText = "Operatie";
            this.operatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operatieDataGridViewTextBoxColumn.Name = "operatieDataGridViewTextBoxColumn";
            this.operatieDataGridViewTextBoxColumn.Visible = false;
            this.operatieDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsRulajeOperatie
            // 
            this.bsRulajeOperatie.DataMember = "Rulaje";
            this.bsRulajeOperatie.DataSource = this.bsOperatie;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conturi corespondente";
            // 
            // frmRulaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAplicatie);
            this.Controls.Add(this.dtpDataDoc);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmRulaje";
            this.Text = "frmRulaje";
            this.Load += new System.EventHandler(this.frmRulaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConturi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRulajeOperatie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpDataDoc;
        private System.Windows.Forms.TextBox txtAplicatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsOperatie;
        private System.Windows.Forms.BindingSource bsRulajeOperatie;
        private System.Windows.Forms.BindingSource bsConturi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatieDataGridViewTextBoxColumn;
    }
}