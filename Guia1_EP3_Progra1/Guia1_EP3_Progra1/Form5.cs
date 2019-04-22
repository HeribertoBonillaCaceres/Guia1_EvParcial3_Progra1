/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 08:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Guia1_EP3_Progra1
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Ex5Gui1 : Form
	{
		private int tiempo;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0xF170;
        Timer timer1 = new Timer();
        
        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        [DllImport("winmm")]
        public static extern void mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, long hwndCallback);
		
		public Ex5Gui1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void ApagarMonitor()
		{
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
			//El 2 es para apagar
		}
		
		private void EncenderMonitor()
		{
			SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
			//El -1 es para encender
		}

		private void Button1Click(object sender, EventArgs e)
		{
			ApagarMonitor();
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			tiempo = 5;
			ApagarMonitor();
			timer1.Start();
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (tiempo != 0)
			{
				tiempo--;
			}
			else
			{
				timer1.Stop();
				EncenderMonitor();
			}
		}
				
		private void Button3Click(object sender, EventArgs e)
		{
			mciSendString("set CDaudio door open", "", 127, 0);
		}
				
		private void Button4Click(object sender, EventArgs e)
		{
			mciSendString("set CDaudio door close", "", 127, 0);
		}
	}
}
