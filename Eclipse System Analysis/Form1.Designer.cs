namespace Eclipse_System_Analysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainDir5Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.jobFilesList = new System.Windows.Forms.ListBox();
            this.backupFolderList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eclipse System Analysis";
            // 
            // mainDir5Label
            // 
            this.mainDir5Label.AutoSize = true;
            this.mainDir5Label.Location = new System.Drawing.Point(12, 84);
            this.mainDir5Label.Name = "mainDir5Label";
            this.mainDir5Label.Size = new System.Drawing.Size(48, 13);
            this.mainDir5Label.TabIndex = 1;
            this.mainDir5Label.Text = "mainDir5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Main Directory:";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(316, 46);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(367, 134);
            this.userListBox.TabIndex = 3;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // jobFilesList
            // 
            this.jobFilesList.FormattingEnabled = true;
            this.jobFilesList.Location = new System.Drawing.Point(316, 214);
            this.jobFilesList.Name = "jobFilesList";
            this.jobFilesList.Size = new System.Drawing.Size(367, 134);
            this.jobFilesList.TabIndex = 4;
            // 
            // backupFolderList
            // 
            this.backupFolderList.FormattingEnabled = true;
            this.backupFolderList.Location = new System.Drawing.Point(689, 46);
            this.backupFolderList.Name = "backupFolderList";
            this.backupFolderList.Size = new System.Drawing.Size(367, 134);
            this.backupFolderList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Backup Folder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jobs / Other Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupFolderList);
            this.Controls.Add(this.jobFilesList);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainDir5Label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainDir5Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.ListBox jobFilesList;
        private System.Windows.Forms.ListBox backupFolderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

