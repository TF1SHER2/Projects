using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonStatConverter
{
    public partial class frmMain : Form
    {
        const double heightConversion = 39.3701;
        const double weightConversion = 35.274;
        public frmMain()
        {
            InitializeComponent();
        }

        private void convertB_Click(object sender, EventArgs e)
        {
            ConvertPokemon();
        }

        private void ConvertPokemon()
        {
            ClearControls();
            double weightKG = 0;
            double heightM = 0;
            try
            {
                double weightOZ;
                double heightIN;


                weightKG = Double.Parse(tWeight.Text.ToString());
                heightM = Double.Parse(tHeight.Text.ToString());

                if (weightKG < .01 || weightKG > 9000)
                {
                    tWeight.Focus();
                    throw new NullReferenceException();
                }
                else if (heightM < .001 || heightM > 1000 )
                {
                    tHeight.Focus();
                    throw new NullReferenceException();
                }

                weightOZ = Math.Round(weightKG * weightConversion, 1);
                heightIN = Math.Round(heightM * heightConversion, 2);

                tWeightOut.Text += weightOZ;
                tHeightOut.Text += heightIN;

                this.tWclass.Text += WeightClassLookup(weightOZ);
                this.tHclass.Text += HeightClassLookup(heightIN);
            } catch (FormatException notE)
            {
                string name = "";
                double number = 0;

                //these if statements check to see if the name or the weight is throwing the error
                if (!Double.TryParse(tWeight.Text, out number))
                {
                    tWeight.Focus();
                    name = "weight (kg)";
                }
                if (!Double.TryParse(tHeight.Text, out number))
                {
                    tHeight.Focus();
                    name = "height (m)";
                }
                MessageBox.Show("The " + name + " field is not valid. The error is: " + notE.GetType().ToString(), "Format Error");
            }
            catch (NullReferenceException stillNotE)
            {
                string name = "";
                if (weightKG < .01 || weightKG > 9000)
                {
                    name = "Weight";
                }
                else if (heightM < .001 || heightM > 1000)
                {
                    name = "Height";
                }
                MessageBox.Show("The values entered in the " + name + " field is not within the accaptable range for this program \nThe range for Height is between .001 and 1000 \nThe range for weight is between .01 and 9000");
            }
        }

        private void ClearControls()
        {
            this.tWeightOut.Text = "";
            this.tHeightOut.Text = "";
            this.tWclass.Text = "";
            this.tHclass.Text = "";
        }

        private string HeightClassLookup(double heightIN)
        {
            if (heightIN < 30 && heightIN > 0 )
            {
                return "Short";
            }
            else if (heightIN >=30 && heightIN <= 50)
            {
                return "Normal";
            }
            else if (heightIN >50) 
            {
                return "Tall";
            }
            else
            {
                return "Unknown";
            }
        }

        private string WeightClassLookup(double weightOZ)
        {
            if (weightOZ < 100 && weightOZ >0)
            {
                return "Extra Small";
            }
            else if (weightOZ >= 100 && weightOZ <= 500)
            {
                return "Normal";
            }
            else if (weightOZ > 500)
            {
                return "Extra Large";
            }
            else
            {
                return "Unknown";
            }
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isValid(this.tName.Text))
                {
                    throw new Exception();
                }
                else
                {
                    convertB.Enabled = true;
                    tWeight.Enabled = true;
                    tHeight.Enabled = true;
                }
            }catch (Exception ex)
            {
                tHeight.Text = "";
                tWeight.Text = "";
                tWeightOut.Text = "";
                tHeightOut.Text = "";
                convertB.Enabled = false;
                tWeight.Enabled = false;
                tHeight.Enabled = false;
            }
            finally
            {
                ClearControls();
            }
        }

        private bool isValid(string text)
        {
            if (text.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void closeB_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void LabelInput_Click(object sender, EventArgs e)
        {

        }
    }
}
