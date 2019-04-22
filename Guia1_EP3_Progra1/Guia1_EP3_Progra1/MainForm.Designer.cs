/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 12:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Guia1_EP3_Progra1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ejercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejercicio5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejercicio5ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ejercicio5ToolStripMenuItem
			// 
			this.ejercicio5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejercicio1ToolStripMenuItem,
									this.ejercicio2ToolStripMenuItem,
									this.ejercicio3ToolStripMenuItem,
									this.ejercicio4ToolStripMenuItem,
									this.ejercicio5ToolStripMenuItem1,
									this.salirToolStripMenuItem});
			this.ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
			this.ejercicio5ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.ejercicio5ToolStripMenuItem.Text = "Ejercicio_6";
			// 
			// ejercicio1ToolStripMenuItem
			// 
			this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
			this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ejercicio1ToolStripMenuItem.Text = "Ejercicio_1";
			this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio1ToolStripMenuItemClick);
			// 
			// ejercicio2ToolStripMenuItem
			// 
			this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
			this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ejercicio2ToolStripMenuItem.Text = "Ejercicio_2";
			this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio2ToolStripMenuItemClick);
			// 
			// ejercicio3ToolStripMenuItem
			// 
			this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
			this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ejercicio3ToolStripMenuItem.Text = "Ejercicio_3";
			this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio3ToolStripMenuItemClick);
			// 
			// ejercicio4ToolStripMenuItem
			// 
			this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
			this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ejercicio4ToolStripMenuItem.Text = "Ejercicio_4";
			this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.Ejercicio4ToolStripMenuItemClick);
			// 
			// ejercicio5ToolStripMenuItem1
			// 
			this.ejercicio5ToolStripMenuItem1.Name = "ejercicio5ToolStripMenuItem1";
			this.ejercicio5ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.ejercicio5ToolStripMenuItem1.Text = "Ejercicio_5";
			this.ejercicio5ToolStripMenuItem1.Click += new System.EventHandler(this.Ejercicio5ToolStripMenuItem1Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Guia1_EP3_Progra1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
