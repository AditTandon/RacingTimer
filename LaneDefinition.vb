Imports System.Runtime.CompilerServices

Public Class LaneDefinition
    Inherits UserControl

    Private m_Position As Integer
    Private _RaceLane As RacingLane
    Private _ResultLane As Result

    Dim Flags(7) As Bitmap

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Flags(0) = My.Resources.Australia
        Flags(1) = My.Resources.Brazil
        Flags(2) = My.Resources.Canada
        Flags(3) = My.Resources.China
        Flags(4) = My.Resources.Jamaica
        Flags(5) = My.Resources.Japan
        Flags(6) = My.Resources.Laos
        Flags(7) = My.Resources.USA

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

    Public Property RaceLane() As RacingLane
        Get
            Return _RaceLane
        End Get
        Set(value As RacingLane)
            _RaceLane = value
        End Set
    End Property

    Public Property ResultLane() As Result
        Get
            Return _ResultLane
        End Get
        Set(value As Result)
            _ResultLane = value
        End Set
    End Property

    Public Sub OpenLane()
        Me.Show()
        RaceLane().Show()
    End Sub

    Public Sub CloseLane()
        Me.Hide()
        RaceLane().Hide()
    End Sub

    Private Function GetAthleteName() As String
        Return AthleteName.Text
    End Function

    Public Function GetCountry() As Integer
        Return Country.SelectedIndex
    End Function

    Private Sub AthleteName_TextChanged(sender As Object, e As EventArgs) Handles AthleteName.TextChanged
        _RaceLane.AthleteName.Text = GetAthleteName()
    End Sub

    Private Sub Country_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Country.SelectedValueChanged
        _RaceLane.SetAthleteCountry(Flags(Country.SelectedIndex))
    End Sub
End Class
