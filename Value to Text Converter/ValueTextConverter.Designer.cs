namespace Value_to_Text_Converter
{
    partial class ValueTextConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValueTextConverter));
            this.BTN_Validation = new System.Windows.Forms.Button();
            this.TXT_NumericValue = new System.Windows.Forms.TextBox();
            this.TXT_lang = new System.Windows.Forms.TextBox();
            this.TXT_cur = new System.Windows.Forms.TextBox();
            this.LBL_NV_Validation = new System.Windows.Forms.Label();
            this.LBL_Lang_Validation = new System.Windows.Forms.Label();
            this.LBL_Result = new System.Windows.Forms.Label();
            this.BTN_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Validation
            // 
            this.BTN_Validation.Location = new System.Drawing.Point(427, 12);
            this.BTN_Validation.Name = "BTN_Validation";
            this.BTN_Validation.Size = new System.Drawing.Size(100, 29);
            this.BTN_Validation.TabIndex = 0;
            this.BTN_Validation.Text = "Validation ";
            this.BTN_Validation.UseVisualStyleBackColor = true;
            this.BTN_Validation.Click += new System.EventHandler(this.BTN_Validation_Click);
            // 
            // TXT_NumericValue
            // 
            this.TXT_NumericValue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_NumericValue.Location = new System.Drawing.Point(12, 12);
            this.TXT_NumericValue.Name = "TXT_NumericValue";
            this.TXT_NumericValue.Size = new System.Drawing.Size(198, 29);
            this.TXT_NumericValue.TabIndex = 1;
            this.TXT_NumericValue.Text = "Numeric Value";
            this.TXT_NumericValue.TextChanged += new System.EventHandler(this.TXT_NumericValue_TextChanged);
            this.TXT_NumericValue.Enter += new System.EventHandler(this.TXT_NumericValue_Enter);
            this.TXT_NumericValue.Leave += new System.EventHandler(this.TXT_NumericValue_Leave);
            // 
            // TXT_lang
            // 
            this.TXT_lang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_lang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_lang.Location = new System.Drawing.Point(216, 12);
            this.TXT_lang.Name = "TXT_lang";
            this.TXT_lang.Size = new System.Drawing.Size(86, 26);
            this.TXT_lang.TabIndex = 2;
            this.TXT_lang.Text = "Language";
            this.TXT_lang.TextChanged += new System.EventHandler(this.TXT_lang_TextChanged);
            this.TXT_lang.Enter += new System.EventHandler(this.TXT_lang_Enter);
            this.TXT_lang.Leave += new System.EventHandler(this.TXT_lang_Leave);
            // 
            // TXT_cur
            // 
            this.TXT_cur.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_cur.Location = new System.Drawing.Point(308, 12);
            this.TXT_cur.Name = "TXT_cur";
            this.TXT_cur.Size = new System.Drawing.Size(103, 29);
            this.TXT_cur.TabIndex = 3;
            this.TXT_cur.Text = "Currency";
            this.TXT_cur.Enter += new System.EventHandler(this.TXT_cur_Enter);
            this.TXT_cur.Leave += new System.EventHandler(this.TXT_cur_Leave);
            // 
            // LBL_NV_Validation
            // 
            this.LBL_NV_Validation.AutoSize = true;
            this.LBL_NV_Validation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NV_Validation.Location = new System.Drawing.Point(8, 44);
            this.LBL_NV_Validation.Name = "LBL_NV_Validation";
            this.LBL_NV_Validation.Size = new System.Drawing.Size(198, 19);
            this.LBL_NV_Validation.TabIndex = 4;
            this.LBL_NV_Validation.Text = "Numeric Value Validation";
            // 
            // LBL_Lang_Validation
            // 
            this.LBL_Lang_Validation.AutoSize = true;
            this.LBL_Lang_Validation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Lang_Validation.Location = new System.Drawing.Point(384, 44);
            this.LBL_Lang_Validation.Name = "LBL_Lang_Validation";
            this.LBL_Lang_Validation.Size = new System.Drawing.Size(160, 19);
            this.LBL_Lang_Validation.TabIndex = 5;
            this.LBL_Lang_Validation.Text = "Language Validation";
            // 
            // LBL_Result
            // 
            this.LBL_Result.AutoSize = true;
            this.LBL_Result.Location = new System.Drawing.Point(12, 123);
            this.LBL_Result.Name = "LBL_Result";
            this.LBL_Result.Size = new System.Drawing.Size(62, 22);
            this.LBL_Result.TabIndex = 7;
            this.LBL_Result.Text = "Result";
            // 
            // BTN_Convert
            // 
            this.BTN_Convert.Enabled = false;
            this.BTN_Convert.Location = new System.Drawing.Point(550, 12);
            this.BTN_Convert.Name = "BTN_Convert";
            this.BTN_Convert.Size = new System.Drawing.Size(84, 51);
            this.BTN_Convert.TabIndex = 8;
            this.BTN_Convert.Text = "Convert";
            this.BTN_Convert.UseVisualStyleBackColor = true;
            this.BTN_Convert.Click += new System.EventHandler(this.BTN_Convert_Click);
            // 
            // ValueTextConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(643, 182);
            this.Controls.Add(this.BTN_Convert);
            this.Controls.Add(this.LBL_Result);
            this.Controls.Add(this.LBL_Lang_Validation);
            this.Controls.Add(this.LBL_NV_Validation);
            this.Controls.Add(this.TXT_cur);
            this.Controls.Add(this.TXT_lang);
            this.Controls.Add(this.TXT_NumericValue);
            this.Controls.Add(this.BTN_Validation);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ValueTextConverter";
            this.Text = "Value->Text Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Validation;
        private System.Windows.Forms.TextBox TXT_NumericValue;
        private System.Windows.Forms.TextBox TXT_lang;
        private System.Windows.Forms.TextBox TXT_cur;
        private System.Windows.Forms.Label LBL_NV_Validation;
        private System.Windows.Forms.Label LBL_Lang_Validation;
        private System.Windows.Forms.Label LBL_Result;
        private System.Windows.Forms.Button BTN_Convert;
    }
}

