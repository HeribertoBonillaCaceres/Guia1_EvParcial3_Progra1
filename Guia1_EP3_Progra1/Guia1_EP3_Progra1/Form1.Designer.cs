/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 19/04/2019
 * Time: 12:59 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Guia1_EP3_Progra1
{
	partial class Ex1Gui1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "SUMA DE DOS NUMEROS ENTEROS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label2.Location = new System.Drawing.Point(41, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "NUMERO 1";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label3.Location = new System.Drawing.Point(41, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NUMERO 2";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumber1
			// 
			this.txtNumber1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber1.Location = new System.Drawing.Point(163, 51);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(92, 23);
			this.txtNumber1.TabIndex = 3;
			// 
			// txtNumber2
			// 
			this.txtNumber2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber2.Location = new System.Drawing.Point(163, 93);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(92, 23);
			this.txtNumber2.TabIndex = 4;
			// 
			// txtResultado
			// 
			this.txtResultado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResultado.Location = new System.Drawing.Point(163, 140);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(92, 23);
			this.txtResultado.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label4.Location = new System.Drawing.Point(41, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "RESULTADO";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(41, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Sumar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(163, 191);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(94, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "Limpiar";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Ex1Gui1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Ex1Gui1";
			this.Text = "Ejercicio 1 Guia 1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.TextBox txtNumber2;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
