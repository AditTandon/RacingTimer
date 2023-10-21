<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaneDefinition
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
        LaneLabel = New Label()
        ColonLbl = New Label()
        LaneNum = New Label()
        AthleteName = New TextBox()
        Country = New ComboBox()
        SuspendLayout()
        ' 
        ' LaneLabel
        ' 
        LaneLabel.AutoSize = True
        LaneLabel.Location = New Point(42, 23)
        LaneLabel.Name = "LaneLabel"
        LaneLabel.Size = New Size(94, 48)
        LaneLabel.TabIndex = 0
        LaneLabel.Text = "Lane"
        ' 
        ' ColonLbl
        ' 
        ColonLbl.AutoSize = True
        ColonLbl.Location = New Point(168, 23)
        ColonLbl.Name = "ColonLbl"
        ColonLbl.Size = New Size(28, 48)
        ColonLbl.TabIndex = 1
        ColonLbl.Text = ":"
        ' 
        ' LaneNum
        ' 
        LaneNum.AutoSize = True
        LaneNum.Location = New Point(127, 25)
        LaneNum.Name = "LaneNum"
        LaneNum.Size = New Size(39, 48)
        LaneNum.TabIndex = 2
        LaneNum.Text = "1"
        ' 
        ' AthleteName
        ' 
        AthleteName.Location = New Point(215, 22)
        AthleteName.Name = "AthleteName"
        AthleteName.Size = New Size(350, 55)
        AthleteName.TabIndex = 3
        ' 
        ' Country
        ' 
        Country.FormattingEnabled = True
        Country.Items.AddRange(New Object() {"Australia", "Brazil", "Canada", "China", "Jamaica", "Japan", "Laos", "USA"})
        Country.Location = New Point(612, 22)
        Country.Name = "Country"
        Country.Size = New Size(272, 56)
        Country.TabIndex = 4
        ' 
        ' LaneDefinition
        ' 
        AutoScaleDimensions = New SizeF(20F, 48F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Country)
        Controls.Add(AthleteName)
        Controls.Add(LaneNum)
        Controls.Add(ColonLbl)
        Controls.Add(LaneLabel)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "LaneDefinition"
        Size = New Size(945, 112)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LaneLabel As Label
    Friend WithEvents ColonLbl As Label
    Friend WithEvents LaneNum As Label
    Friend WithEvents AthleteName As TextBox
    Friend WithEvents Country As ComboBox
End Class
