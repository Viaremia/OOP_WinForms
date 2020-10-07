namespace OOP5_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadData1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadData2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_grid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_grid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDatabaseToolStripMenuItem,
            this.disconnectDatabaseToolStripMenuItem,
            this.finishWorkToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectDatabaseToolStripMenuItem
            // 
            this.connectDatabaseToolStripMenuItem.Name = "connectDatabaseToolStripMenuItem";
            this.connectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.connectDatabaseToolStripMenuItem.Text = "Connect database";
            this.connectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // disconnectDatabaseToolStripMenuItem
            // 
            this.disconnectDatabaseToolStripMenuItem.Name = "disconnectDatabaseToolStripMenuItem";
            this.disconnectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.disconnectDatabaseToolStripMenuItem.Text = "Disconnect database";
            this.disconnectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.DisconnectDB_Click);
            // 
            // finishWorkToolStripMenuItem
            // 
            this.finishWorkToolStripMenuItem.Name = "finishWorkToolStripMenuItem";
            this.finishWorkToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.finishWorkToolStripMenuItem.Text = "Finish work";
            this.finishWorkToolStripMenuItem.Click += new System.EventHandler(this.Finish_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadData1ToolStripMenuItem,
            this.downloadData2ToolStripMenuItem,
            this.queryExecuteToolStripMenuItem,
            this.modificationQueryToolStripMenuItem,
            this.deleteQueryToolStripMenuItem,
            this.insertQueryToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // downloadData1ToolStripMenuItem
            // 
            this.downloadData1ToolStripMenuItem.Name = "downloadData1ToolStripMenuItem";
            this.downloadData1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadData1ToolStripMenuItem.Text = "Download data1";
            this.downloadData1ToolStripMenuItem.Click += new System.EventHandler(this.DownloadDB1_Click);
            // 
            // downloadData2ToolStripMenuItem
            // 
            this.downloadData2ToolStripMenuItem.Name = "downloadData2ToolStripMenuItem";
            this.downloadData2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadData2ToolStripMenuItem.Text = "Download data2";
            this.downloadData2ToolStripMenuItem.Click += new System.EventHandler(this.DownloadDB2_Click);
            // 
            // queryExecuteToolStripMenuItem
            // 
            this.queryExecuteToolStripMenuItem.Name = "queryExecuteToolStripMenuItem";
            this.queryExecuteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.queryExecuteToolStripMenuItem.Text = "Sample query";
            this.queryExecuteToolStripMenuItem.Click += new System.EventHandler(this.SampleQ_Click);
            // 
            // modificationQueryToolStripMenuItem
            // 
            this.modificationQueryToolStripMenuItem.Name = "modificationQueryToolStripMenuItem";
            this.modificationQueryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificationQueryToolStripMenuItem.Text = "Modification query";
            this.modificationQueryToolStripMenuItem.Click += new System.EventHandler(this.InrtQ_DltQ_UpdtQ_Click);
            // 
            // deleteQueryToolStripMenuItem
            // 
            this.deleteQueryToolStripMenuItem.Name = "deleteQueryToolStripMenuItem";
            this.deleteQueryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteQueryToolStripMenuItem.Text = "Delete query";
            this.deleteQueryToolStripMenuItem.Click += new System.EventHandler(this.InrtQ_DltQ_UpdtQ_Click);
            // 
            // insertQueryToolStripMenuItem
            // 
            this.insertQueryToolStripMenuItem.Name = "insertQueryToolStripMenuItem";
            this.insertQueryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertQueryToolStripMenuItem.Text = "Insert query";
            this.insertQueryToolStripMenuItem.Click += new System.EventHandler(this.InrtQ_DltQ_UpdtQ_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPathToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // setPathToolStripMenuItem
            // 
            this.setPathToolStripMenuItem.Name = "setPathToolStripMenuItem";
            this.setPathToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.setPathToolStripMenuItem.Text = "Set path";
            this.setPathToolStripMenuItem.Click += new System.EventHandler(this.SetPath_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grid1,
            this.group_grid1,
            this.surname_grid1,
            this.subject_grid1,
            this.mark_grid1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // id_grid1
            // 
            this.id_grid1.HeaderText = "ID";
            this.id_grid1.Name = "id_grid1";
            // 
            // group_grid1
            // 
            this.group_grid1.HeaderText = "Group";
            this.group_grid1.Name = "group_grid1";
            // 
            // surname_grid1
            // 
            this.surname_grid1.HeaderText = "Surname";
            this.surname_grid1.Name = "surname_grid1";
            // 
            // subject_grid1
            // 
            this.subject_grid1.HeaderText = "Subject";
            this.subject_grid1.Name = "subject_grid1";
            // 
            // mark_grid1
            // 
            this.mark_grid1.HeaderText = "Mark";
            this.mark_grid1.Name = "mark_grid1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grid2,
            this.group_grid2,
            this.surname_grid2,
            this.subject_grid2,
            this.mark_grid2});
            this.dataGridView2.Location = new System.Drawing.Point(503, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(486, 282);
            this.dataGridView2.TabIndex = 2;
            // 
            // id_grid2
            // 
            this.id_grid2.HeaderText = "ID";
            this.id_grid2.Name = "id_grid2";
            // 
            // group_grid2
            // 
            this.group_grid2.HeaderText = "Group";
            this.group_grid2.Name = "group_grid2";
            // 
            // surname_grid2
            // 
            this.surname_grid2.HeaderText = "Surname";
            this.surname_grid2.Name = "surname_grid2";
            // 
            // subject_grid2
            // 
            this.subject_grid2.HeaderText = "Subject";
            this.subject_grid2.Name = "subject_grid2";
            // 
            // mark_grid2
            // 
            this.mark_grid2.HeaderText = "Mark";
            this.mark_grid2.Name = "mark_grid2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data grid №1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(533, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data grid №2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(40, 353);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Connection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoCheck = false;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(882, 353);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Connection";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(376, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Query";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(433, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClckBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadData1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadData2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryExecuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark_grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname_grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark_grid2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem modificationQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertQueryToolStripMenuItem;
    }
}

