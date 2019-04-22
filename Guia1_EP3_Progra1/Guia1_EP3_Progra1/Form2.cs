/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 05:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1_EP3_Progra1
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Ex2Gui1 : Form
	{
		public Ex2Gui1()
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
			String usuario, password;
			usuario = txtLogin.Text.TrimEnd();
			password = txtPassword.Text.TrimEnd();
			if ((usuario == "UTEC") && (password == "programacion1")) 
			     {
			     	MessageBox.Show("Bienvenidos al Sistema");
			     }
			else
				{
				MessageBox.Show("Verifique Usuario y Contraseña");
				}
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();			
		}
	}
}
