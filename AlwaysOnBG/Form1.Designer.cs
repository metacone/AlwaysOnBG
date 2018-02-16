namespace AlwaysOnBG
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BG_Start = new System.Windows.Forms.Button();
            this.BG_End = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BG_Start
            // 
            this.BG_Start.Location = new System.Drawing.Point(12, 12);
            this.BG_Start.Name = "BG_Start";
            this.BG_Start.Size = new System.Drawing.Size(75, 23);
            this.BG_Start.TabIndex = 0;
            this.BG_Start.Text = "Start";
            this.BG_Start.UseVisualStyleBackColor = true;
            this.BG_Start.Click += new System.EventHandler(this.BG_Start_Click);
            // 
            // BG_End
            // 
            this.BG_End.Location = new System.Drawing.Point(105, 12);
            this.BG_End.Name = "BG_End";
            this.BG_End.Size = new System.Drawing.Size(75, 23);
            this.BG_End.TabIndex = 1;
            this.BG_End.Text = "End";
            this.BG_End.UseVisualStyleBackColor = true;
            this.BG_End.Click += new System.EventHandler(this.BG_End_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(12, 67);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(168, 21);
            this.KeyBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 132);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.BG_End);
            this.Controls.Add(this.BG_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BG_Start;
        private System.Windows.Forms.Button BG_End;
        private System.Windows.Forms.TextBox KeyBox;
    }
}

