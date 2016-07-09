Public Class DemoObject
    Implements System.ComponentModel.INotifyPropertyChanged
    'Public Property Name As String
    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Name"))
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
    'Public Property Width As Double
    Private _Width As Double
    Public Property Width As Double
        Get
            Return _Width
        End Get
        Set(value As Double)
            _Width = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Width"))
        End Set
    End Property
    'Public Property Height As Double
    Private _Height As Double
    Public Property Height As Double
        Get
            Return _Height
        End Get
        Set(value As Double)
            _Height = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Height"))
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged
End Class
