/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 02/03/2011
 * Time: 14:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace pdfinjector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPDFInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenPDF = new System.Windows.Forms.Button();
			this.openPDFDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnSavePDF = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPDFOutput = new System.Windows.Forms.TextBox();
			this.savePDFDialog = new System.Windows.Forms.SaveFileDialog();
			this.btnOpenJS = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtJS = new System.Windows.Forms.TextBox();
			this.openJSDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnInject = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPDFInput
			// 
			this.txtPDFInput.Location = new System.Drawing.Point(17, 82);
			this.txtPDFInput.Margin = new System.Windows.Forms.Padding(4);
			this.txtPDFInput.Name = "txtPDFInput";
			this.txtPDFInput.Size = new System.Drawing.Size(423, 22);
			this.txtPDFInput.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 66);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "PDF Input File";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// btnOpenPDF
			// 
			this.btnOpenPDF.Location = new System.Drawing.Point(449, 79);
			this.btnOpenPDF.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenPDF.Name = "btnOpenPDF";
			this.btnOpenPDF.Size = new System.Drawing.Size(100, 28);
			this.btnOpenPDF.TabIndex = 2;
			this.btnOpenPDF.Text = "Open PDF";
			this.btnOpenPDF.UseVisualStyleBackColor = true;
			this.btnOpenPDF.Click += new System.EventHandler(this.BtnOpenPDFClick);
			// 
			// openPDFDialog
			// 
			this.openPDFDialog.Filter = "PDF files|*.pdf";
			this.openPDFDialog.Title = "Open PDF File";
			this.openPDFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenPDFDialogFileOk);
			// 
			// btnSavePDF
			// 
			this.btnSavePDF.Location = new System.Drawing.Point(448, 147);
			this.btnSavePDF.Margin = new System.Windows.Forms.Padding(4);
			this.btnSavePDF.Name = "btnSavePDF";
			this.btnSavePDF.Size = new System.Drawing.Size(100, 28);
			this.btnSavePDF.TabIndex = 5;
			this.btnSavePDF.Text = "Save PDF";
			this.btnSavePDF.UseVisualStyleBackColor = true;
			this.btnSavePDF.Click += new System.EventHandler(this.BtnSavePDFClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 134);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "PDF Output File";
			// 
			// txtPDFOutput
			// 
			this.txtPDFOutput.Location = new System.Drawing.Point(16, 150);
			this.txtPDFOutput.Margin = new System.Windows.Forms.Padding(4);
			this.txtPDFOutput.Name = "txtPDFOutput";
			this.txtPDFOutput.Size = new System.Drawing.Size(423, 22);
			this.txtPDFOutput.TabIndex = 3;
			// 
			// savePDFDialog
			// 
			this.savePDFDialog.DefaultExt = "pdf";
			this.savePDFDialog.Filter = "PDF file|*.pdf";
			// 
			// btnOpenJS
			// 
			this.btnOpenJS.Location = new System.Drawing.Point(448, 217);
			this.btnOpenJS.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenJS.Name = "btnOpenJS";
			this.btnOpenJS.Size = new System.Drawing.Size(100, 28);
			this.btnOpenJS.TabIndex = 8;
			this.btnOpenJS.Text = "Open JS";
			this.btnOpenJS.UseVisualStyleBackColor = true;
			this.btnOpenJS.Click += new System.EventHandler(this.BtnOpenJSClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 204);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Javascript file";
			// 
			// txtJS
			// 
			this.txtJS.Location = new System.Drawing.Point(16, 220);
			this.txtJS.Margin = new System.Windows.Forms.Padding(4);
			this.txtJS.Name = "txtJS";
			this.txtJS.Size = new System.Drawing.Size(423, 22);
			this.txtJS.TabIndex = 6;
			// 
			// openJSDialog
			// 
			this.openJSDialog.DefaultExt = "js";
			this.openJSDialog.Filter = "JS File|*.js";
			// 
			// btnInject
			// 
			this.btnInject.Location = new System.Drawing.Point(221, 276);
			this.btnInject.Margin = new System.Windows.Forms.Padding(4);
			this.btnInject.Name = "btnInject";
			this.btnInject.Size = new System.Drawing.Size(108, 39);
			this.btnInject.TabIndex = 11;
			this.btnInject.Text = "Inject code";
			this.btnInject.UseVisualStyleBackColor = true;
			this.btnInject.Click += new System.EventHandler(this.BtnInjectClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 16);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(537, 41);
			this.label5.TabIndex = 13;
			this.label5.Text = "This application inject autoexecutable javascript code into a PDF document ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 342);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnInject);
			this.Controls.Add(this.btnOpenJS);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtJS);
			this.Controls.Add(this.btnSavePDF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPDFOutput);
			this.Controls.Add(this.btnOpenPDF);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPDFInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(573, 417);
			this.MinimumSize = new System.Drawing.Size(573, 375);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PDF injector";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.OpenFileDialog openJSDialog;
		private System.Windows.Forms.Button btnInject;
		private System.Windows.Forms.TextBox txtJS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOpenJS;
		private System.Windows.Forms.SaveFileDialog savePDFDialog;
		private System.Windows.Forms.Button btnSavePDF;
		private System.Windows.Forms.TextBox txtPDFOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPDFInput;
		private System.Windows.Forms.OpenFileDialog openPDFDialog;
		private System.Windows.Forms.Button btnOpenPDF;
		private System.Windows.Forms.Label label1;
	}
}
