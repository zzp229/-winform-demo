namespace 大文件拷贝
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
            t_score = new TextBox();
            label1 = new Label();
            t_sort = new TextBox();
            label2 = new Label();
            btn_Read = new Button();
            btn_Sort = new Button();
            SuspendLayout();
            // 
            // t_score
            // 
            t_score.Location = new Point(21, 34);
            t_score.Multiline = true;
            t_score.Name = "t_score";
            t_score.Size = new Size(360, 310);
            t_score.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 1;
            label1.Text = "成绩";
            // 
            // t_sort
            // 
            t_sort.Location = new Point(434, 37);
            t_sort.Multiline = true;
            t_sort.Name = "t_sort";
            t_sort.Size = new Size(354, 307);
            t_sort.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 14);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "统计";
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(21, 378);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(75, 23);
            btn_Read.TabIndex = 3;
            btn_Read.Text = "读入";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Sort
            // 
            btn_Sort.Location = new Point(125, 378);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(75, 23);
            btn_Sort.TabIndex = 4;
            btn_Sort.Text = "排序";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Sort);
            Controls.Add(btn_Read);
            Controls.Add(t_sort);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(t_score);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox t_score;
        private Label label1;
        private TextBox t_sort;
        private Label label2;
        private Button btn_Read;
        private Button btn_Sort;
    }
}