using System;

namespace ConnectDB_Article03_
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAdd = new System.Windows.Forms.Button();
            this.tbEdit = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.Button();
            this.tbExit = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName});
            this.dgvCustomer.Location = new System.Drawing.Point(96, 47);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(308, 150);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(132, 325);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(75, 23);
            this.tbAdd.TabIndex = 1;
            this.tbAdd.Text = "Add";
            this.tbAdd.UseVisualStyleBackColor = true;
            this.tbAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(223, 325);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(75, 23);
            this.tbEdit.TabIndex = 2;
            this.tbEdit.Text = "Edit";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(320, 325);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(75, 23);
            this.tbDelete.TabIndex = 3;
            this.tbDelete.Text = "Delete";
            this.tbDelete.UseVisualStyleBackColor = true;
            this.tbDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbExit
            // 
            this.tbExit.Location = new System.Drawing.Point(413, 325);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(75, 23);
            this.tbExit.TabIndex = 4;
            this.tbExit.Text = "Exit";
            this.tbExit.UseVisualStyleBackColor = true;
            this.tbExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(152, 218);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(146, 20);
            this.tbId.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(152, 258);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
       
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbExit);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button tbAdd;
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.Button tbDelete;
        private System.Windows.Forms.Button tbExit;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}

