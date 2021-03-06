﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleInterface
{

    //MIS 220-001 Thomas Fisher

    public partial class frmMain : Form
    {
        private List<Pokemon> pokemon;
        private List<Pokemon> pokedex;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if (pokedex == null)
            {
                pokedex = new List<Pokemon>();
            }

            Pokemon selected = (Pokemon)dgvPokemon.SelectedRows[0].DataBoundItem;

            for (int i = 0; i < udClones.Value; i++)
            {
                Pokemon p = selected.Clone();
                pokedex.Add(p);
            }

            dgvPokedex.DataSource = typeof(Pokemon);
            dgvPokedex.DataSource = pokedex;

            udClones.Value = 1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataFill();
        }

        private void DataFill()
        {
            pokemon = new List<Pokemon>();
            Pokemon p = new Pokemon("Dratini", 18, "Dragon");
            pokemon.Add(p);
            p = new Pokemon("Bulbasaur", 35, "Poison");
            pokemon.Add(p);
            p = new Pokemon("Poliwag", 18, "Water");
            pokemon.Add(p);

            dgvPokemon.DataSource = typeof(Pokemon);
            dgvPokemon.DataSource = pokemon;
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.SelectedRows.Count > 0)
            {
                btnClone.Enabled = true;
                udClones.Enabled = true;
            }
            else
            {
                btnClone.Enabled = false;
                udClones.Enabled = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pokedex");
            String[] pokemonData = new String[3];
            int pokemonCount =0;
            if (pokedex != null && pokedex.Count > 0)
            {
                foreach (Pokemon p in pokedex)
                {
                    pokemonData = p.GetDisplay(" ").Split(' ');
                    pokemonCount++;
                    sb.AppendLine("Pokemon[" + pokemonCount.ToString() + "]");
                    sb.AppendLine("Name: " + pokemonData[0]);
                    sb.AppendLine("HP: " + pokemonData[1]);
                    sb.AppendLine("Type: " + pokemonData[2]);
                }
            }
            else
            {
                sb.AppendLine("Sorry, but your Pokedex is currently Empty!");
            }
            frmReport r = new frmReport();
            r.ReportData = sb.ToString();
            r.ShowDialog();
        }
    }
}
