/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 12:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1_EP3_Progra1
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
		
		private void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void Ejercicio1ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ex1Gui1 hijo1 = new Ex1Gui1();
			hijo1.MdiParent = this;
			hijo1.Show();
		}
		
		private void Ejercicio2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ex2Gui1 hijo2 = new Ex2Gui1();
			hijo2.MdiParent = this;
			hijo2.Show();			
		}
		
		private void Ejercicio3ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ex3Gui1 hijo3 = new Ex3Gui1();
			hijo3.MdiParent = this;
			hijo3.Show();
		}
		
		private void Ejercicio4ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Ex4Gui1 hijo4 = new Ex4Gui1();
			hijo4.MdiParent = this;
			hijo4.Show();
		}
		
		private void Ejercicio5ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Ex5Gui1 hijo5 = new Ex5Gui1();
            hijo5.MdiParent = this;
            hijo5.Show();
		}
	}
}
