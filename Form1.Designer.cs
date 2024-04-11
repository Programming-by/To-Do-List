namespace Login
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteAllItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteLastItem = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 36);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(68, 67);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(574, 123);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(415, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(68, 241);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(306, 34);
            this.txtBox.TabIndex = 3;
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(68, 303);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(145, 44);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Delete First item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteFirstItem_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.White;
            this.btnCheckAll.Location = new System.Drawing.Point(415, 303);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(120, 44);
            this.btnCheckAll.TabIndex = 5;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.Location = new System.Drawing.Point(415, 366);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(120, 44);
            this.btnUncheck.TabIndex = 6;
            this.btnUncheck.Text = "UnCheck All";
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.Location = new System.Drawing.Point(64, 205);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(93, 20);
            this.lblAddTask.TabIndex = 7;
            this.lblAddTask.Text = "Add Task:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDeleteAllItems
            // 
            this.btnDeleteAllItems.Location = new System.Drawing.Point(229, 366);
            this.btnDeleteAllItems.Name = "btnDeleteAllItems";
            this.btnDeleteAllItems.Size = new System.Drawing.Size(145, 44);
            this.btnDeleteAllItems.TabIndex = 8;
            this.btnDeleteAllItems.Text = "Delete All items";
            this.btnDeleteAllItems.UseVisualStyleBackColor = true;
            this.btnDeleteAllItems.Click += new System.EventHandler(this.btnDeleteAllItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Items: ";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.Location = new System.Drawing.Point(152, 27);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(19, 20);
            this.lblItemsCount.TabIndex = 10;
            this.lblItemsCount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete Checked item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnDeleteLastItem
            // 
            this.btnDeleteLastItem.Location = new System.Drawing.Point(229, 303);
            this.btnDeleteLastItem.Name = "btnDeleteLastItem";
            this.btnDeleteLastItem.Size = new System.Drawing.Size(145, 44);
            this.btnDeleteLastItem.TabIndex = 12;
            this.btnDeleteLastItem.Text = "Delete Last item";
            this.btnDeleteLastItem.UseVisualStyleBackColor = true;
            this.btnDeleteLastItem.Click += new System.EventHandler(this.btnDeleteLastItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btnDeleteLastItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAllItems);
            this.Controls.Add(this.lblAddTask);
            this.Controls.Add(this.btnUncheck);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheck;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDeleteAllItems;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteLastItem;
    }
}

