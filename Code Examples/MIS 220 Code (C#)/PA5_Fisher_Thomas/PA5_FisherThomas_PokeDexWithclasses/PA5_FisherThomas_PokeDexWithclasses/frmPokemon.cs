using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_FisherThomas_PokeDexWithclasses
{
    public partial class frmPokemon : Form
    {
        public frmPokemon()
        {
            InitializeComponent();
        }
        private const double weightConversion = 35.274;
        private const double heightConversion = 39.3701;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.ToString();
                double hp = Math.Round(Double.Parse(txtHP.Text.ToString()), 2);
                string type = cbType.Text.ToString();
                double weight = Math.Round(Double.Parse(txtWeight.Text.ToString()), 2);
                double height = Math.Round(Double.Parse(txtHeight.Text.ToString()), 2);

                if (cbWeightUnit.Text == "kg")
                {
                    weight *= weightConversion;
                }

                if (cbHeightUnit.Text == "m")
                {
                    height *= heightConversion;
                }


                Pokemon p = new global::PA5_FisherThomas_PokeDexWithclasses.Pokemon(name, hp, type, weight, height);

                this.Tag = p;

                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (FormatException)
            {
                string errorLine = "";
                double number = 0;
                if (!(Double.TryParse(txtHP.Text, out number)))
                {
                    errorLine = "HP";
                    txtHP.Focus();
                }
                else if (!(Double.TryParse(txtWeight.Text, out number)))
                {
                    errorLine = "Weight";
                    txtWeight.Focus();
                }
                else if (!(Double.TryParse(txtHeight.Text, out number)))
                {
                    errorLine = "Height";
                    txtHeight.Focus();
                }
                else
                {
                    MessageBox.Show("Please enter correct values");
                }

                MessageBox.Show("Please enter only numbers for the " + errorLine + " field");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
