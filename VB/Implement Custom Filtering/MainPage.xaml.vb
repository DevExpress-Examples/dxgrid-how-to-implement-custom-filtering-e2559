Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Implement_Custom_Filtering
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New Object() { "A", "B", "C", "D", "E", "F", "G", "H" }
		End Sub
		Private Sub grid_CustomRowFilter(ByVal sender As Object, ByVal e As RowFilterEventArgs)
			If chkHideOdd.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 1 Then
				e.Visible = False
			End If
			If chkHideEven.IsChecked.Value AndAlso e.ListSourceRowIndex Mod 2 = 0 Then
				e.Visible = False
			End If
			e.Handled = If((Not e.Visible), True, False)
		End Sub

		Private Sub chk_CheckedOrUnchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			grid.RefreshData()
		End Sub
	End Class
End Namespace
