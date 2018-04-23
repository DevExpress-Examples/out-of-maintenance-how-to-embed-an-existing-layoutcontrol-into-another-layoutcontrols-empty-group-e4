Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout

Namespace radialMenu
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim item As New LayoutControlItem()
			item.SizeConstraintsType = SizeConstraintsType.Custom
			item.TextVisible = False
			item.Control = layoutControl1
			layoutControlGroup3.AddItem(item)
		End Sub
	End Class
End Namespace
