Imports System.Media

Public Class Result

    Private m_Position As Integer

    Dim AnimatedFlags(7) As Bitmap
    Dim Anthems(7) As SoundPlayer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AnimatedFlags(0) = My.Resources.Australia1
        AnimatedFlags(1) = My.Resources.Brazil1
        AnimatedFlags(2) = My.Resources.Canada1
        AnimatedFlags(3) = My.Resources.China1
        AnimatedFlags(4) = My.Resources.Jamaica1
        AnimatedFlags(5) = My.Resources.Japan1
        AnimatedFlags(6) = My.Resources.Laos1
        AnimatedFlags(7) = My.Resources.USA1

        Anthems(0) = New SoundPlayer(My.Resources.Australia2)
        Anthems(1) = New SoundPlayer(My.Resources.Brazil2)
        Anthems(2) = New SoundPlayer(My.Resources.Canada2)
        Anthems(3) = New SoundPlayer(My.Resources.China2)
        Anthems(4) = New SoundPlayer(My.Resources.Jamaica2)
        Anthems(5) = New SoundPlayer(My.Resources.Japan2)
        Anthems(6) = New SoundPlayer(My.Resources.Laos2)
        Anthems(7) = New SoundPlayer(My.Resources.USA2)
    End Sub

    Public Property Position() As Integer
        Get
            Return m_Position
        End Get
        Set(ByVal value As Integer)
            m_Position = value
            Place.Text = m_Position

            If m_Position > 3 Then
                Place.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
                Time.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
                AthleteName.Font = New Font("Segoe UI", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
            End If
        End Set
    End Property

    Public Sub HideResults()
        Me.Place.Text = ""
        Me.AthleteName.Text = ""
        Me.Time.Text = ""
        Me.Country.Image = Nothing
    End Sub

    Public Sub SetAnimFlag(index As Integer)
        Me.Country.Image = AnimatedFlags(index)
    End Sub

    Public Sub PlayAnthem(index As Integer)
        Me.Anthems(index).Stream.Position = 0
        Me.Anthems(index).Play()
    End Sub
End Class
