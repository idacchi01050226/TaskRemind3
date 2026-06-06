namespace TaskRemind3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            FInish_button = new Button();
            Remind_button = new Button();
            Edit_button = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Edit_button, 1, 0);
            tableLayoutPanel1.Controls.Add(Remind_button, 0, 0);
            tableLayoutPanel1.Controls.Add(FInish_button, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(466, 39);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FInish_button
            // 
            FInish_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FInish_button.Location = new Point(313, 3);
            FInish_button.Name = "FInish_button";
            FInish_button.Size = new Size(150, 33);
            FInish_button.TabIndex = 0;
            FInish_button.Text = "完了";
            FInish_button.UseVisualStyleBackColor = true;
            // 
            // Remind_button
            // 
            Remind_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Remind_button.Location = new Point(3, 3);
            Remind_button.Name = "Remind_button";
            Remind_button.Size = new Size(149, 33);
            Remind_button.TabIndex = 1;
            Remind_button.Text = "継続";
            Remind_button.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            Edit_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Edit_button.Location = new Point(158, 3);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(149, 33);
            Edit_button.TabIndex = 2;
            Edit_button.Text = "編集";
            Edit_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 156);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 201);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Edit_button;
        private Button Remind_button;
        private Button FInish_button;
        private TextBox textBox1;
    }
}
