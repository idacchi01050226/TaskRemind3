namespace TaskRemind3
{
    partial class AddTask
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
            Title_Label = new Label();
            Content_Label = new Label();
            textBox1 = new TextBox();
            ContentEnter = new TextBox();
            Add_Button = new Button();
            checkStartNow = new CheckBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            SelectDayCombox = new ComboBox();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox8 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Title_Label
            // 
            Title_Label.AutoSize = true;
            Title_Label.Location = new Point(22, 38);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(53, 20);
            Title_Label.TabIndex = 0;
            Title_Label.Text = "タイトル";
            // 
            // Content_Label
            // 
            Content_Label.AutoSize = true;
            Content_Label.Location = new Point(22, 89);
            Content_Label.Name = "Content_Label";
            Content_Label.Size = new Size(39, 20);
            Content_Label.TabIndex = 1;
            Content_Label.Text = "内容";
            Content_Label.Click += Discription_Label_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 2;
            // 
            // ContentEnter
            // 
            ContentEnter.Location = new Point(81, 89);
            ContentEnter.Multiline = true;
            ContentEnter.Name = "ContentEnter";
            ContentEnter.Size = new Size(349, 99);
            ContentEnter.TabIndex = 3;
            // 
            // Add_Button
            // 
            Add_Button.Location = new Point(-1, 357);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(481, 29);
            Add_Button.TabIndex = 4;
            Add_Button.Text = "追加";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // checkStartNow
            // 
            checkStartNow.AutoSize = true;
            checkStartNow.Location = new Point(22, 206);
            checkStartNow.Name = "checkStartNow";
            checkStartNow.Size = new Size(188, 24);
            checkStartNow.TabIndex = 5;
            checkStartNow.Text = "今からリマインドを開始する";
            checkStartNow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 238);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "時";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(39, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(39, 27);
            textBox4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 239);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 8;
            label2.Text = "分　からリマインドを開始する";
            // 
            // SelectDayCombox
            // 
            SelectDayCombox.FormattingEnabled = true;
            SelectDayCombox.Location = new Point(22, 235);
            SelectDayCombox.Name = "SelectDayCombox";
            SelectDayCombox.Size = new Size(68, 28);
            SelectDayCombox.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(186, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(39, 27);
            textBox5.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 289);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 13;
            label3.Text = "分　おきにリマインドする";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(96, 286);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(39, 27);
            textBox6.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 289);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 11;
            label4.Text = "時間";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(22, 289);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(39, 27);
            textBox8.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 291);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 15;
            label5.Text = "日";
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 385);
            Controls.Add(textBox8);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(SelectDayCombox);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(checkStartNow);
            Controls.Add(Add_Button);
            Controls.Add(ContentEnter);
            Controls.Add(textBox1);
            Controls.Add(Content_Label);
            Controls.Add(Title_Label);
            Name = "AddTask";
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Label;
        private Label Content_Label;
        private TextBox textBox1;
        private TextBox ContentEnter;
        private Button Add_Button;
        private CheckBox checkStartNow;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private ComboBox SelectDayCombox;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox8;
        private Label label5;
    }
}