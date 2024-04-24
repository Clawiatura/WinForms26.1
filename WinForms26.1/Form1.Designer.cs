namespace WinForms26._1
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
            cbmark1 = new CheckBox();
            cbmark2 = new CheckBox();
            cbmark3 = new CheckBox();
            btres = new Button();
            SuspendLayout();
            // 
            // cbmark1
            // 
            cbmark1.AutoSize = true;
            cbmark1.Location = new Point(12, 12);
            cbmark1.Name = "cbmark1";
            cbmark1.Size = new Size(93, 19);
            cbmark1.TabIndex = 0;
            cbmark1.Text = "Галочка №1";
            cbmark1.UseVisualStyleBackColor = true;
            cbmark1.CheckedChanged += cbmark1_CheckedChanged;
            // 
            // cbmark2
            // 
            cbmark2.AutoSize = true;
            cbmark2.Location = new Point(12, 46);
            cbmark2.Name = "cbmark2";
            cbmark2.Size = new Size(93, 19);
            cbmark2.TabIndex = 1;
            cbmark2.Text = "Галочка №2";
            cbmark2.UseVisualStyleBackColor = true;
            cbmark2.CheckedChanged += cbmark2_CheckedChanged;
            // 
            // cbmark3
            // 
            cbmark3.AutoSize = true;
            cbmark3.Location = new Point(12, 80);
            cbmark3.Name = "cbmark3";
            cbmark3.Size = new Size(93, 19);
            cbmark3.TabIndex = 2;
            cbmark3.Text = "Галочка №3";
            cbmark3.UseVisualStyleBackColor = true;
            cbmark3.CheckedChanged += cbmark3_CheckedChanged;
            // 
            // btres
            // 
            btres.Location = new Point(12, 134);
            btres.Name = "btres";
            btres.Size = new Size(163, 91);
            btres.TabIndex = 3;
            btres.Text = "Проверить флажок";
            btres.UseVisualStyleBackColor = true;
            btres.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 450);
            Controls.Add(btres);
            Controls.Add(cbmark3);
            Controls.Add(cbmark2);
            Controls.Add(cbmark1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbmark1;
        private CheckBox cbmark2;
        private CheckBox cbmark3;
        private Button btres;
    }
}
