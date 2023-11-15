namespace Project
{
    partial class CheckForm
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
            btn_Yes = new System.Windows.Forms.Button();
            btn_No = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_Yes
            // 
            btn_Yes.Location = new System.Drawing.Point(47, 67);
            btn_Yes.Name = "btn_Yes";
            btn_Yes.Size = new System.Drawing.Size(75, 23);
            btn_Yes.TabIndex = 0;
            btn_Yes.Text = "Yes";
            btn_Yes.UseVisualStyleBackColor = true;
            btn_Yes.Click += btn_Yes_Click;
            // 
            // btn_No
            // 
            btn_No.Location = new System.Drawing.Point(264, 67);
            btn_No.Name = "btn_No";
            btn_No.Size = new System.Drawing.Size(75, 23);
            btn_No.TabIndex = 1;
            btn_No.Text = "No";
            btn_No.UseVisualStyleBackColor = true;
            btn_No.Click += btn_No_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(99, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 60);
            label1.TabIndex = 2;
            label1.Text = "포지션에 맞지 않는 선수 입니다.\r\n\r\n그대로 진행하시겠습니까?(Yes)\r\n선수를 바꾸시겠습니까?(No)\r\n";
            // 
            // CheckForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(390, 106);
            Controls.Add(label1);
            Controls.Add(btn_No);
            Controls.Add(btn_Yes);
            Name = "CheckForm";
            Text = "CheckForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Label label1;
    }
}