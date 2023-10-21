Public Class TimeDisplay
    Inherits Label

    Private Time As Integer
    Private _FormattedTime As String

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Function GetTime() As Integer
        Return Time
    End Function

    Public Property FormattedTime As String
        Get
            Return _FormattedTime
        End Get
        Set(value As String)
            _FormattedTime = value
        End Set
    End Property

    Public Sub SetTime()
        ' Convert time to min
        Dim TimeMin = Time \ 600
        ' Convert to leftover seconds
        Dim TimeSeconds = (Time \ 10) Mod 60
        ' Get final tenth of seconds
        Dim TimeTenths = Time Mod 10

        Dim FTime = TimeFormat(TimeMin, TimeSeconds, TimeTenths)
        _FormattedTime = FTime
    End Sub

    Public Function TimeFormat(TimeMin As Integer, TimeSeconds As Integer, TimeTenths As Integer) As String
        Dim FTime = String.Format("{0:D2}:{1:D2}.{2}", TimeMin, TimeSeconds, TimeTenths)
        Return FTime
    End Function

    Public Sub IncrementTime()
        Time += 1
        SetTime()
    End Sub

    Public Sub ResetTime()
        Time = 0
        SetTime()
        ShowTime()
    End Sub

    Public Sub ShowTime()
        Me.Text = _FormattedTime
    End Sub
End Class
