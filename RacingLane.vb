Public Class RacingLane
    Inherits UserControl

    Private m_Position As Integer
    Private _TimeDisp As TimeDisplay

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.AthleteName.Text = String.Empty
        Me.CountryFlag.Image = Nothing
    End Sub

    Public Property Position() As Integer
        Get
            Return m_Position
        End Get
        Set(ByVal value As Integer)
            m_Position = value
            LaneNum.Text = value
        End Set
    End Property

    Public Property TimeDisp() As TimeDisplay
        Get
            Return _TimeDisp
        End Get
        Set(value As TimeDisplay)
            _TimeDisp = value
        End Set
    End Property

    Public Sub SetAthleteCountry(Flag As Bitmap)
        Me.CountryFlag.Image = Flag
    End Sub

    Public Sub EmptyTimeDisplay()
        Me._TimeDisp.Text = ""
    End Sub
End Class
