/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 08:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1_EP3_Progra1
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Ex4Gui1 : Form
	{
		public Ex4Gui1()
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
			int x, N, suma=0;
			listBox1.Items.Clear();
			N = int.Parse(txtN.Text);
			for (x=1;x<=N;x++)
			{
				suma = suma+x;
				if (checkBox1.Checked == true)
				{
					listBox1.Items.Add("sumando: "+x+", Suma Parcial: "+suma);
				}
			}
			listBox1.Items.Add("La suma TOTAL es: "+suma);
		}
	}
}
