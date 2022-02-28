Imports System.ComponentModel

Public Class clBase
    Implements INotifyPropertyChanged

    Private Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal sProperty As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(sProperty))
    End Sub
End Class
