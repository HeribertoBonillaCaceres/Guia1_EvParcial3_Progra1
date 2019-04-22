/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 08:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Guia1_EP3_Progra1
{
	partial class Ex4Gui1
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtN = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calcular suma desde 1 hasta:";
			
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(207, 21);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(100, 22);
			this.txtN.TabIndex = 1;
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(27, 51);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(157, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Ver resultados parciales";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(27, 82);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(280, 260);
			this.listBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(132, 363);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "CALCULAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Ex4Gui1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 415);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Ex4Gui1";
			this.Text = "Sumatoria de 1 hasta N";
			
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Label label1;
	}
}
