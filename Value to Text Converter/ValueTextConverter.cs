using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Value_to_Text_Converter
{
    public partial class ValueTextConverter : Form
    {
        public ValueTextConverter()
        {
            InitializeComponent();
        }

        Value_To_Text_Methodes Value_To_Text_Methodes_obj = new Value_To_Text_Methodes();

        private void TXT_NumericValue_Enter(object sender, EventArgs e)
        {
            if(TXT_NumericValue.Text == "Numeric Value")
            {
                TXT_NumericValue.Text = "" ;
                TXT_NumericValue.ForeColor = Color.Black ; 
            }
        }

        private void TXT_NumericValue_Leave(object sender, EventArgs e)
        {
            if (TXT_NumericValue.Text == "")
            {
                TXT_NumericValue.Text = "Numeric Value";
                TXT_NumericValue.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void TXT_lang_Enter(object sender, EventArgs e)
        {
            if (TXT_lang.Text == "Language")
            {
                TXT_lang.Text = "";
                TXT_lang.ForeColor = Color.Black;
            }
        }

        private void TXT_lang_Leave(object sender, EventArgs e)
        {
            if (TXT_lang.Text == "")
            {
                TXT_lang.Text = "Language";
                TXT_lang.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void TXT_cur_Enter(object sender, EventArgs e)
        {
            if (TXT_cur.Text == "Currency")
            {
                TXT_cur.Text = "";
                TXT_cur.ForeColor = Color.Black;
            }
        }

        private void TXT_cur_Leave(object sender, EventArgs e)
        {
            if (TXT_cur.Text == "")
            {
                TXT_cur.Text = "Currency";
                TXT_cur.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void BTN_Validation_Click(object sender, EventArgs e)
        {
            int number_err_id, lang_err_id;
            string number_err_message, lang_err_message;
            if (TXT_NumericValue.Text == "Numeric Value" && TXT_NumericValue.ForeColor == SystemColors.InactiveCaption)
                TXT_NumericValue.Text = "";
            if (TXT_lang.Text == "Language" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
                TXT_lang.Text = "";
            bool number_val = Value_To_Text_Methodes_obj.Value_Validation(TXT_NumericValue.Text,out number_err_id,out number_err_message) , lang_val = Value_To_Text_Methodes_obj.Language_Validation(TXT_lang.Text, out lang_err_id, out lang_err_message);
            LBL_NV_Validation.Text = (number_val ? "Valid" : "Invalid") + "\n" + number_err_id.ToString() + " : " + number_err_message;
            LBL_Lang_Validation.Text = (lang_val ? "Valid" : "Invalid") + "\n" + lang_err_id.ToString() + " : " + lang_err_message;
            if (TXT_NumericValue.Text == "" )
                TXT_NumericValue.Text = "Numeric Value";
            if (TXT_lang.Text == "")
                TXT_lang.Text = "Language";
            if (number_val && lang_val)
                BTN_Convert.Enabled = true;
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            if (TXT_cur.Text == "Currency" && TXT_cur.ForeColor == SystemColors.InactiveCaption)
                TXT_cur.Text = "";
            LBL_Result.Text = Value_To_Text_Methodes_obj.Numeric_To_Text(TXT_NumericValue.Text, TXT_lang.Text, TXT_cur.Text);
            if (TXT_cur.Text == "")
                TXT_cur.Text = "Currency";
        }

        private void TXT_NumericValue_TextChanged(object sender, EventArgs e)
        {
            LBL_NV_Validation.Text = "Numeric Value Validation";
            LBL_Result.Text = "Result";
            BTN_Convert.Enabled = false;
        }

        private void TXT_lang_TextChanged(object sender, EventArgs e)
        {
            LBL_Lang_Validation.Text = "Language Validation";
            LBL_Result.Text = "Result";
            BTN_Convert.Enabled = false;
        }
    }
}
