Public Class TickBoxBase
    Inherits Button
    Public Property IsChecked As Boolean
        Get
            Return GetValue(IsCheckedProperty)
        End Get
        Set(ByVal value As Boolean)
            SetValue(IsCheckedProperty, value)
        End Set
    End Property
    Public Shared ReadOnly IsCheckedProperty As DependencyProperty =
                             DependencyProperty.Register("IsChecked",
                             GetType(Boolean), GetType(TickBoxBase),
                             New FrameworkPropertyMetadata(False, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault))
    Protected Overrides Sub OnClick()
        SetValue(IsCheckedProperty, Not IsChecked)
        Dim IsCheckedBinding = GetBindingExpression(IsCheckedProperty)
        IsCheckedBinding.UpdateSource()
    End Sub
    Public ReadOnly Property TickWidth As GridLength
        Get
            Return GetValue(TickBoxBase.TickWidthProperty)
        End Get
    End Property
    Private Shared ReadOnly TickWidthPropertyKey As DependencyPropertyKey =
                                  DependencyProperty.RegisterReadOnly("TickWidth",
                                  GetType(GridLength), GetType(TickBoxBase),
                                  New PropertyMetadata(New GridLength(20.0#, GridUnitType.Pixel)))
    Public Shared ReadOnly TickWidthProperty As DependencyProperty =
                                 TickWidthPropertyKey.DependencyProperty
    Protected Overrides Sub OnRenderSizeChanged(sizeInfo As SizeChangedInfo)
        Dim aw = ActualHeight
        If Double.IsNaN(aw) Then aw = 0#
        SetValue(TickWidthPropertyKey, New GridLength(aw, GridUnitType.Pixel))
        MyBase.OnRenderSizeChanged(sizeInfo)
    End Sub
End Class
