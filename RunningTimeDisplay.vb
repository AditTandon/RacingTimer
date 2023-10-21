Public Class RunningTimeDisplay
    Inherits TimeDisplay

    Private WithEvents Timer1 As Timer

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Timer1 = New Timer()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
    End Sub

    Public Function GetTimer1() As Timer
        Return Timer1
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IncrementTime()
        ShowTime()
    End Sub

    Public Sub StartTimer()
        Timer1.Start()
    End Sub

    Public Sub StopTimer()
        Timer1.Stop()
    End Sub

End Class
