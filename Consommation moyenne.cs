/*
 * Crée par SharpDevelop.
 * Utilisateur: Asus
 * Date: 15/02/2021
 * Heure: 9:06 PM
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tp2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CalculerClick(object sender, EventArgs e)
		{
			float s;
			if(float.TryParse(consommation.Text,out s)==false || consommation.Text.Length==0 || float.Parse(consommation.Text)<0){
			//if(consommation.Text.Length==0 || float.Parse(consommation.Text)<0){
				MessageBox.Show("entrer la consommation","Cout Trajet",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
				consommation.Focus();
				consommation.BackColor=Color.LightCyan; 

			}
			float x=(float.Parse(distance.Text)/100)*float.Parse(consommation.Text);
			nb_litre.Text=x.ToString();	
			float y=x*(float.Parse(prix.Text));
			tarif.Text=y.ToString();
	
		}
		void FermerClick(object sender, EventArgs e)
		{
			DialogResult r;
			r=MessageBox.Show("Tu Veut Quitter","Quitter",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(r==DialogResult.Yes){
				Application.Exit();
			}
		}

	}
}
