using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralKarateWorkoutScheduler.Forms
{
    public partial class ChangeValue : Form
    {
        private string value = null;

        public string Value
        {
            get { return value; }
        }

        public ChangeValue()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        public void SetDataDescription(string desc)
        {
            labelDataDesc.Text = desc;
        }

        public void SetDataValue(string value)
        {
            textBoxValue.Text = value;
            this.value = value;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            value = textBoxValue.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
