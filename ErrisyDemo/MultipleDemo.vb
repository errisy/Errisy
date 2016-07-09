Public Class MultipleDemo
    Implements System.ComponentModel.INotifyPropertyChanged
    'Public Property Tests As System.Collections.ObjectModel.ObservableCollection(Of TestObject)
    Private _Tests As New System.Collections.ObjectModel.ObservableCollection(Of TestObject)
    Public Property Tests As System.Collections.ObjectModel.ObservableCollection(Of TestObject)
        Get
            Return _Tests
        End Get
        Set(value As System.Collections.ObjectModel.ObservableCollection(Of TestObject))
            _Tests = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Tests"))
        End Set
    End Property
    'Public Property Demos As System.Collections.ObjectModel.ObservableCollection(Of DemoObject)
    Private _Demos As New System.Collections.ObjectModel.ObservableCollection(Of DemoObject)
    Public Property Demos As System.Collections.ObjectModel.ObservableCollection(Of DemoObject)
        Get
            Return _Demos
        End Get
        Set(value As System.Collections.ObjectModel.ObservableCollection(Of DemoObject))
            _Demos = value
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs("Demos"))
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged
End Class
