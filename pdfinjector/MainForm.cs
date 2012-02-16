/*
 * Created by SharpDevelop.
 * User: Juan Lago D.
 * Date: 02/03/2011
 * Time: 14:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Advanced;

namespace pdfinjector
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void OpenPDFDialogFileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		void BtnOpenPDFClick(object sender, EventArgs e)
		{
			if (openPDFDialog.ShowDialog() == DialogResult.OK)
			{
				txtPDFInput.Text = openPDFDialog.FileName;
			}
				
			
		}
		
		void BtnSavePDFClick(object sender, EventArgs e)
		{
			if (savePDFDialog.ShowDialog() == DialogResult.OK)
			{
				txtPDFOutput.Text = savePDFDialog.FileName;
			}
			
		}
		
		void BtnOpenJSClick(object sender, EventArgs e)
		{
			if (openJSDialog.ShowDialog() == DialogResult.OK)
			{
				txtJS.Text = openJSDialog.FileName;
			}
			
		}
		
		void BtnInjectClick(object sender, EventArgs e)
		{
			
			// Check PDF input file
			if (!File.Exists(txtPDFInput.Text))
			{
				MessageBox.Show("PDF input file do not exists", "File check");				
				return;
			}
			
			// Check PDF output
			if (txtPDFOutput.Text == "")
			{
				MessageBox.Show("You must assign an output file", "File check");
				return;			
			}
			
			
			// Check JS input file			
			if (!File.Exists(txtJS.Text))
			{
				MessageBox.Show("JS input file do not exists", "File check");				
				return;
			}

			// Read Javascript file
			StreamReader js = new StreamReader(txtJS.Text);
			
			// Read PDF document
			PdfDocument document = PdfReader.Open(txtPDFInput.Text);
			
			// Insert javascript
			PdfDictionary dictJS = new PdfDictionary();
			
			dictJS.Elements["/S"] = new PdfName("/JavaScript");
			dictJS.Elements["/JS"] = new PdfStringObject(document, js.ReadToEnd());
			
			// Close Javascript file
			js.Close();
			
			document.Internals.AddObject(dictJS);

			PdfDictionary dict = new PdfDictionary();
			PdfArray array = new PdfArray();
			dict.Elements["/Names"] = array;
			array.Elements.Add(new PdfString("EmbeddedJS"));
			array.Elements.Add(PdfInternals.GetReference(dictJS));
									
			document.Internals.AddObject(dict);

			PdfDictionary group = new PdfDictionary();
			group.Elements["/JavaScript"] = PdfInternals.GetReference(dict);
			
			document.Internals.Catalog.Elements["/Names"] = group;
			
			// Insert OpenAction
			// See: http://www.pdfsharp.net/wiki/WorkOnPdfObjects-sample.ashx
			// Insert javascript						
			
											
			// Save ouput file
			document.Save(txtPDFOutput.Text);
			
			MessageBox.Show("Code have been injected!", "Finish!");
						
		}
		
		
	}
}
