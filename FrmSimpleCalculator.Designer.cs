namespace cSharpSimpleCalculator
{
    partial class FrmSimpleCalculator
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtSecondNum = new System.Windows.Forms.TextBox();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.TxtFirstNum = new System.Windows.Forms.TextBox();
            this.GbxCalc = new System.Windows.Forms.GroupBox();
            this.RbMult = new System.Windows.Forms.RadioButton();
            this.RbSub = new System.Windows.Forms.RadioButton();
            this.RbAdd = new System.Windows.Forms.RadioButton();
            this.RbHidden = new System.Windows.Forms.RadioButton();
            this.GbxCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(48, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(374, 53);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "My First Simple Calculator";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSecondNum
            // 
            this.TxtSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSecondNum.Location = new System.Drawing.Point(178, 135);
            this.TxtSecondNum.Name = "TxtSecondNum";
            this.TxtSecondNum.Size = new System.Drawing.Size(115, 29);
            this.TxtSecondNum.TabIndex = 2;
            this.TxtSecondNum.Text = "123456789";
            this.TxtSecondNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSecondNum.TextChanged += new System.EventHandler(this.TxtSecondNum_TextChanged);
            // 
            // LblAnswer
            // 
            this.LblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnswer.Location = new System.Drawing.Point(178, 197);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(115, 29);
            this.LblAnswer.TabIndex = 3;
            this.LblAnswer.Text = "123456789";
            this.LblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(48, 348);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 37);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(178, 348);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(114, 37);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "Sub";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(308, 348);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(114, 37);
            this.BtnMult.TabIndex = 6;
            this.BtnMult.Text = "Mult";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // TxtFirstNum
            // 
            this.TxtFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstNum.Location = new System.Drawing.Point(178, 87);
            this.TxtFirstNum.Name = "TxtFirstNum";
            this.TxtFirstNum.Size = new System.Drawing.Size(115, 29);
            this.TxtFirstNum.TabIndex = 1;
            this.TxtFirstNum.Text = "123456789";
            this.TxtFirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFirstNum.TextChanged += new System.EventHandler(this.TxtFirstNum_TextChanged);
            // 
            // GbxCalc
            // 
            this.GbxCalc.Controls.Add(this.RbHidden);
            this.GbxCalc.Controls.Add(this.RbMult);
            this.GbxCalc.Controls.Add(this.RbSub);
            this.GbxCalc.Controls.Add(this.RbAdd);
            this.GbxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCalc.Location = new System.Drawing.Point(113, 264);
            this.GbxCalc.Name = "GbxCalc";
            this.GbxCalc.Size = new System.Drawing.Size(244, 68);
            this.GbxCalc.TabIndex = 7;
            this.GbxCalc.TabStop = false;
            this.GbxCalc.Text = "Math OP";
            // 
            // RbMult
            // 
            this.RbMult.AutoSize = true;
            this.RbMult.Location = new System.Drawing.Point(169, 28);
            this.RbMult.Name = "RbMult";
            this.RbMult.Size = new System.Drawing.Size(63, 28);
            this.RbMult.TabIndex = 2;
            this.RbMult.TabStop = true;
            this.RbMult.Text = "Mult";
            this.RbMult.UseVisualStyleBackColor = true;
            this.RbMult.CheckedChanged += new System.EventHandler(this.RbMult_CheckedChanged);
            // 
            // RbSub
            // 
            this.RbSub.AutoSize = true;
            this.RbSub.Location = new System.Drawing.Point(91, 28);
            this.RbSub.Name = "RbSub";
            this.RbSub.Size = new System.Drawing.Size(62, 28);
            this.RbSub.TabIndex = 1;
            this.RbSub.TabStop = true;
            this.RbSub.Text = "Sub";
            this.RbSub.UseVisualStyleBackColor = true;
            this.RbSub.CheckedChanged += new System.EventHandler(this.RbSub_CheckedChanged);
            // 
            // RbAdd
            // 
            this.RbAdd.AutoSize = true;
            this.RbAdd.Location = new System.Drawing.Point(12, 28);
            this.RbAdd.Name = "RbAdd";
            this.RbAdd.Size = new System.Drawing.Size(63, 28);
            this.RbAdd.TabIndex = 0;
            this.RbAdd.TabStop = true;
            this.RbAdd.Text = "Add";
            this.RbAdd.UseVisualStyleBackColor = true;
            this.RbAdd.CheckedChanged += new System.EventHandler(this.RbAdd_CheckedChanged);
            // 
            // RbHidden
            // 
            this.RbHidden.AutoSize = true;
            this.RbHidden.Location = new System.Drawing.Point(266, 36);
            this.RbHidden.Name = "RbHidden";
            this.RbHidden.Size = new System.Drawing.Size(14, 13);
            this.RbHidden.TabIndex = 3;
            this.RbHidden.TabStop = true;
            this.RbHidden.UseVisualStyleBackColor = true;
            this.RbHidden.Visible = false;
            // 
            // FrmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 412);
            this.Controls.Add(this.GbxCalc);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.TxtSecondNum);
            this.Controls.Add(this.TxtFirstNum);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmSimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator by Vivek";
            this.Load += new System.EventHandler(this.FrmSimpleCalculator_Load);
            this.GbxCalc.ResumeLayout(false);
            this.GbxCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtSecondNum;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.TextBox TxtFirstNum;
        private System.Windows.Forms.GroupBox GbxCalc;
        private System.Windows.Forms.RadioButton RbMult;
        private System.Windows.Forms.RadioButton RbSub;
        private System.Windows.Forms.RadioButton RbAdd;
        private System.Windows.Forms.RadioButton RbHidden;
    }
}

