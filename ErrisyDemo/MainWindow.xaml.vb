Class MainWindow 

    'Private TestObjects As New System.Collections.ObjectModel.ObservableCollection(Of TestObject)
    'Private DemoObjects As New System.Collections.ObjectModel.ObservableCollection(Of DemoObject)
    'Private M As New MultipleDemo
    'Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
    '    Me.DataContext = M

    '    'DirectCast(dicMain.Panel, Errisy.CanvasEditor).Zoom = 0.5#
    '    M.Tests.Add(New TestObject With {.Value = "Test 0", .X = 500, .Y = 120})
    '    M.Tests.Add(New TestObject With {.Value = "Test 1", .X = 200, .Y = 324})
    '    M.Demos.Add(New DemoObject With {.X = 500, .Y = 50, .Width = 100, .Height = 80})

    'End Sub

    Private t As New TestValue
    Private ts As New System.Collections.ObjectModel.ObservableCollection(Of TestValue)
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        DataContext = t
        ts.Add(New TestValue)
        ts.Add(New TestValue)
        icMain.ItemsSource = ts


    End Sub

    Private Sub ttt(sender As Object, e As RoutedEventArgs)
        t.Test = Not t.Test
        ts.Add(New TestValue)
        For Each tv In ts
            tv.Test = Not tv.Test
        Next
    End Sub
End Class
