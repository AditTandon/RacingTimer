<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RacingLane
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
        LaneNum = New Label()
        ColonLabel = New Label()
        AthleteName = New Label()
        CountryFlag = New PictureBox()
        CType(CountryFlag, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LaneLabel
        ' 
        LaneLabel.AutoSize = True
        LaneLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneLabel.Location = New Point(14, 25)
        LaneLabel.Name = "LaneLabel"
        LaneLabel.Size = New Size(94, 48)
        LaneLabel.TabIndex = 0
        LaneLabel.Text = "Lane"
        ' 
        ' LaneNum
        ' 
        LaneNum.AutoSize = True
        LaneNum.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneNum.Location = New Point(94, 27)
        LaneNum.Name = "LaneNum"
        LaneNum.Size = New Size(39, 48)
        LaneNum.TabIndex = 1
        LaneNum.Text = "1"
        ' 
        ' ColonLabel
        ' 
        ColonLabel.AutoSize = True
        ColonLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ColonLabel.Location = New Point(123, 27)
        ColonLabel.Name = "ColonLabel"
        ColonLabel.Size = New Size(28, 48)
        ColonLabel.TabIndex = 2
        ColonLabel.Text = ":"
        ' 
        ' AthleteName
        ' 
        AthleteName.AutoSize = True
        AthleteName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AthleteName.Location = New Point(157, 27)
        AthleteName.Name = "AthleteName"
        AthleteName.Size = New Size(123, 48)
        AthleteName.TabIndex = 3
        AthleteName.Text = "Label1"
        ' 
        ' CountryFlag
        ' 
        CountryFlag.Image = My.Resources.Resources.Australia
        CountryFlag.Location = New Point(485, 12)
        CountryFlag.Name = "CountryFlag"
        CountryFlag.Size = New Size(225, 112)
        CountryFlag.TabIndex = 4
        CountryFlag.TabStop = False
        ' 
        ' RacingLane
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CountryFlag)
        Controls.Add(AthleteName)
        Controls.Add(ColonLabel)
        Controls.Add(LaneNum)
        Controls.Add(LaneLabel)
        Name = "RacingLane"
        Size = New Size(733, 134)
        CType(CountryFlag, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LaneLabel As Label
    Friend WithEvents LaneNum As Label
    Friend WithEvents ColonLabel As Label
    Friend WithEvents AthleteName As Label
    Friend WithEvents CountryFlag As PictureBox
End Class
