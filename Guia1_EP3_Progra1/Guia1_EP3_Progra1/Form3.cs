/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 06:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1_EP3_Progra1
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Ex3Gui1 : Form
	{
		public Ex3Gui1()
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
			int total = 0;
		if (radioButton1.Checked == true)
		{
			total = total + 50;
		}
		if (radioButton2.Checked == true)
		{
			total = total + 100;
		}
		if (radioButton3.Checked == true)
		{
			total = total + 150;
		}
		if (this.checkBox1.Checked == true)
		{
			total = total + 5;
		}
		if (this.checkBox2.Checked == true)
		{
			total = total + 15;
		}
		if (this.checkBox3.Checked == true)
		{
			total = total + 20;
		}
		MessageBox.Show("El total de gastos de envío es: US$ "+total.ToString("c2"));	
		}
	}
}
