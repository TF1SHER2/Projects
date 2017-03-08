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
    public partial class frmMain : Form
    {
        List<Pokemon> _pokeDex = new List<Pokemon>();
        public frmMain()
        {
            MessageBox.Show("Beware, the scaling on this application is terrible. \nI did the best I could to make it useable \nIf it is still bad, try changing the font to microsoft sans-serif");
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPokemon form = new frmPokemon();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Pokemon p = (Pokemon)form.Tag;
                _pokeDex.Add(p);
                bindGrid();
                updateCount();
            }

            if (_pokeDex.Count == 1)
            {
                updateDetails();
            }
        }

        private void bindGrid()
        {
            dgvPokeDex.DataSource = typeof(Pokemon);
            dgvPokeDex.DataSource = _pokeDex;
        }

        private void updateCount()
        {
            lblCount.Text = "The Pokedex Contains " + _pokeDex.Count + " Pokemon";
        }

        private void updateDetails()
        {
            tbName.Text = dgvPokeDex.SelectedRows[0].Cells["Name"].Value.ToString();
            tbHP.Text = dgvPokeDex.SelectedRows[0].Cells["HP"].Value.ToString();
            tbType.Text = dgvPokeDex.SelectedRows[0].Cells["Type"].Value.ToString();
            tbWeight.Text = dgvPokeDex.SelectedRows[0].Cells["Weight"].Value.ToString();
            tbHeight.Text = dgvPokeDex.SelectedRows[0].Cells["Height"].Value.ToString();
        }

        private void sortMethod()
        {
            if (rbName.Checked == true)
            {
                _pokeDex = _pokeDex.OrderBy(o => o.Name).ToList();
            }
            else if (rbHeight.Checked == true)
            {
                _pokeDex = _pokeDex.OrderBy(o => o.Height).ToList();
            }
            else if (rbWeight.Checked == true)
            {
                _pokeDex = _pokeDex.OrderBy(o => o.Weight).ToList();
            }
            else if (rbType.Checked == true)
            {
                _pokeDex = _pokeDex.OrderBy(o => o.Type).ToList();
            }
            else if (rbHP.Checked == true)
            {
                _pokeDex = _pokeDex.OrderBy(o => o.HP).ToList();
            }
            else
            {
                MessageBox.Show("Please choose a sort method");
            }
            bindGrid();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            rbName.Checked = true;
            sortMethod();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            rbWeight.Checked = true;
            sortMethod();
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            rbHP.Checked = true;
            sortMethod();
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            rbHeight.Checked = true;
            sortMethod();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            rbType.Checked = true;
            sortMethod();
        }

        private void dgvPokeDex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateDetails();
        }

        private void btnDataFill_Click(object sender, EventArgs e)
        {
            Pokemon p1 = new Pokemon("Charizard", 1000, "Fire", 1001, 500);
            _pokeDex.Add(p1);
            Pokemon p2 = new Pokemon("Bulbasaur", 35, "Poison", 288.89, 31.5);
            _pokeDex.Add(p2);
            Pokemon p3 = new Pokemon("Charmander", 53, "Fire", 400.36, 25.59);
            _pokeDex.Add(p3);
            Pokemon p4 = new Pokemon("Dratini", 18, "Dragon", 157.67, 87.01);
            _pokeDex.Add(p4);
            Pokemon p5 = new Pokemon("Poliwag", 14, "Poison", 301.42, 29.13);
            _pokeDex.Add(p5);
            bindGrid();
            updateCount();
            updateDetails();
            btnDataFill.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

    public class Pokemon
    {
        private string name;
        private double HP1;
        private double weight;
        private double height;
        private string type;

        public Pokemon()
        {
        }

        public Pokemon(string name, double HP1, string type, double weight, double height)
        {
            this.name = name;
            this.HP1 = HP1;
            this.weight = weight;
            this.height = height;
            this.type = type;
        }

        public string Name
        {
            get { return name; }
        }

        public double HP
        {
            get { return HP1; }
        }

        public string Type
        {
            get { return type; }
        }

        public double Weight
        {
           get { return weight; }
        }

        public double Height
        {
            get { return height; }
        }
    }
}
