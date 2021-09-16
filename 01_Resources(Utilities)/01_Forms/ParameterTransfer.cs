using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



///_03_Utilities._01_Resources_Utilities_._01_Forms

namespace UtilityForms
{
    public partial class ParameterTransfer : Form
    {
        public ParameterTransfer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyFrom = CopyFrom.Text;
            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyTo = CopyTo.Text;
            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.Groups = GroupElement.Text;
            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterType = ParameterType.Text;
            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.Save();
            Form.ActiveForm.Close();

        }

        private void ParameterTransfer_Load(object sender, EventArgs e)
        {
            CopyFrom.Text = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyFrom;
            CopyTo.Text= _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyTo;
            GroupElement.Text = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.Groups;
            ParameterType.Text = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterType;
        }
    }
}
