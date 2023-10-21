<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Place = New Label()
        Time = New Label()
        AthleteName = New Label()
        Country = New PictureBox()
        CType(Country, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Place
        ' 
        Place.AutoSize = True
        Place.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Place.Location = New Point(3, 22)
        Place.Name = "Place"
        Place.Size = New Size(61, 72)
        Place.TabIndex = 0
        Place.Text = "1"
        ' 
        ' Time
        ' 
        Time.AutoSize = True
        Time.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Time.Location = New Point(61, 22)
        Time.Name = "Time"
        Time.Size = New Size(289, 72)
        Time.TabIndex = 1
        Time.Text = "TimeLabel"
        ' 
        ' AthleteName
        ' 
        AthleteName.AutoSize = True
        AthleteName.Font = New Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point)
        AthleteName.Location = New Point(371, 22)
        AthleteName.Name = "AthleteName"
        AthleteName.Size = New Size(336, 72)
        AthleteName.TabIndex = 2
        AthleteName.Text = "AthleteName"
        ' 
        ' Country
        ' 
        Country.Image = My.Resources.Resources.Australia
        Country.Location = New Point(759, 22)
        Country.Name = "Country"
        Country.Size = New Size(225, 112)
        Country.TabIndex = 3
        Country.TabStop = False
        ' 
        ' Result
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Country)
        Controls.Add(AthleteName)
        Controls.Add(Time)
        Controls.Add(Place)
        Name = "Result"
        Size = New Size(1024, 153)
        CType(Country, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Place As Label
    Friend WithEvents Time As Label
    Friend WithEvents AthleteName As Label
    Friend WithEvents Country As PictureBox
End Class
