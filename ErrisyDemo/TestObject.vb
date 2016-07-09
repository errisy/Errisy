Public Class TestObject
    Implements System.ComponentModel.INotifyPropertyChanged
    'Public Property Value As String
    Private _Value As String
    Public Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Value"))
        End Set
    End Property
    'Public Property X As Double
    Private _X As Double
    Public Property X As Double
        Get
            Return _X
        End Get
        Set(value As Double)
            _X = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("X"))
        End Set
    End Property
    'Public Property Y As Double
    Private _Y As Double
    Public Property Y As Double
        Get
            Return _Y
        End Get
        Set(value As Double)
            _Y = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Y"))
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged
End Class
