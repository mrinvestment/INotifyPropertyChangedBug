Public Class clMain
    Inherits clBase

    Private Property _sFirstname As String
    Private Property _iRandomNumber As Integer

    Private Property _dRandomNumber As Double

    ''' <summary>
    ''' firstname field with manually enter
    ''' </summary>
    ''' <returns></returns>
    Public Property sFirstname As String
        Get
            Return _sFirstname
        End Get
        Set(value As String)
            _sFirstname = value
            OnPropertyChanged("sFirstname")
        End Set
    End Property

    ''' <summary>
    ''' Random number whos changing with timer event
    ''' </summary>
    ''' <returns></returns>
    Public Property iRandomNumber As Integer
        Get
            Return _iRandomNumber
        End Get
        Set(value As Integer)
            _iRandomNumber = value
            OnPropertyChanged("iRandomNumber")
        End Set
    End Property

    ''' <summary>
    ''' Double Test Value
    ''' </summary>
    ''' <returns></returns>
    Public Property dRandomNumber As Decimal
        Get
            Return _dRandomNumber
        End Get
        Set(value As Decimal)
            _dRandomNumber = value
            OnPropertyChanged("dRandomNumber")
        End Set
    End Property
End Class
