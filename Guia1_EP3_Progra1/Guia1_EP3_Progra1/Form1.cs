/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 12:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1_EP3_Progra1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Ex1Gui1 : Form
	{
		public Ex1Gui1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			int n1, n2, suma;
			n1=int.Parse(txtNumber1.Text);
			n2=int.Parse(txtNumber2.Text);
			suma=n1+n2;
			txtResultado.Text=suma.ToString();
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			txtNumber1.Clear();
			txtNumber2.Clear();
			txtResultado.Clear();
		}
	}
}
