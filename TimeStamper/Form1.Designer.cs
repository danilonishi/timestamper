namespace TimeStamper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            created_checkbox = new CheckBox();
            modified_checkbox = new CheckBox();
            opened_checkbox = new CheckBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // created_checkbox
            // 
            created_checkbox.AutoSize = true;
            created_checkbox.Checked = true;
            created_checkbox.CheckState = CheckState.Checked;
            created_checkbox.Location = new Point(12, 41);
            created_checkbox.Name = "created_checkbox";
            created_checkbox.Size = new Size(67, 19);
            created_checkbox.TabIndex = 1;
            created_checkbox.Text = "Created";
            created_checkbox.UseVisualStyleBackColor = true;
            // 
            // modified_checkbox
            // 
            modified_checkbox.AutoSize = true;
            modified_checkbox.Checked = true;
            modified_checkbox.CheckState = CheckState.Checked;
            modified_checkbox.Location = new Point(12, 66);
            modified_checkbox.Name = "modified_checkbox";
            modified_checkbox.Size = new Size(74, 19);
            modified_checkbox.TabIndex = 2;
            modified_checkbox.Text = "Modified";
            modified_checkbox.UseVisualStyleBackColor = true;
            // 
            // opened_checkbox
            // 
            opened_checkbox.AutoSize = true;
            opened_checkbox.Location = new Point(12, 91);
            opened_checkbox.Name = "opened_checkbox";
            opened_checkbox.Size = new Size(68, 19);
            opened_checkbox.TabIndex = 3;
            opened_checkbox.Text = "Opened";
            opened_checkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drag files here to have them changed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 228);
            Controls.Add(groupBox1);
            Controls.Add(opened_checkbox);
            Controls.Add(modified_checkbox);
            Controls.Add(created_checkbox);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Time Stamper";
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private CheckBox created_checkbox;
        private CheckBox modified_checkbox;
        private CheckBox opened_checkbox;
        private GroupBox groupBox1;
    }
}
