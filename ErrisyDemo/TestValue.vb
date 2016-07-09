Public Class TestValue
    Implements System.ComponentModel.INotifyPropertyChanged
    'Public Property Test As Boolean
    Private _Test As Boolean = False
    Public Property Test As Boolean
        Get
            Return _Test
        End Get
        Set(value As Boolean)
            _Test = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Test"))
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged
End Class
