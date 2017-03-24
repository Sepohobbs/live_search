Class MainWindow 
    Dim inventory As New List(Of ITEM_CLASS)


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged
        Dim search_results As New List(Of ITEM_CLASS)

        For x As Integer = 0 To inventory.Count - 1
            If inventory(x).item_number.StartsWith(TextBox1.Text) Then
                search_results.Add(inventory(x))

            End If

        Next
        ListBox1.ItemsSource = search_results
        ListBox1.Items.Refresh()

    End Sub



    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        For x As Integer = 0 To 4
            Dim currect_item As New ITEM_CLASS(x.ToString, x + 1, x + 3)

            inventory.Add(currect_item)

        Next
        ListBox1.ItemsSource = inventory

    End Sub


End Class

Public Class ITEM_CLASS

    Public item_number As String
    Public price As Double
    Public stock As Integer

    Public Sub New(ByVal item_number As String, ByVal price As Double, ByVal stock As Integer)
        Me.item_number = item_number
        Me.price = price
        Me.stock = stock
    End Sub

    'overrides .tostring for this class only
    Public Overrides Function ToString() As String
        Dim item_string As String = ("item number = " & item_number & " | price = " & price & " | stock = " & stock)

        Return item_string
    End Function
End Class