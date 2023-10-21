<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        AthletesTab = New TabPage()
        Label1 = New Label()
        LaneDefinition8 = New LaneDefinition()
        LaneDefinition7 = New LaneDefinition()
        LaneDefinition6 = New LaneDefinition()
        LaneDefinition5 = New LaneDefinition()
        LaneDefinition4 = New LaneDefinition()
        LaneDefinition3 = New LaneDefinition()
        LaneDefinition2 = New LaneDefinition()
        LaneDefinition1 = New LaneDefinition()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        RaceTab = New TabPage()
        TimeDisplay8 = New TimeDisplay()
        TimeDisplay7 = New TimeDisplay()
        TimeDisplay6 = New TimeDisplay()
        TimeDisplay5 = New TimeDisplay()
        TimeDisplay4 = New TimeDisplay()
        TimeDisplay3 = New TimeDisplay()
        TimeDisplay2 = New TimeDisplay()
        TimeDisplay1 = New TimeDisplay()
        RunningTimeDisplay1 = New RunningTimeDisplay()
        Reset = New Button()
        StartStop = New Button()
        RacingLane8 = New RacingLane()
        RacingLane7 = New RacingLane()
        RacingLane6 = New RacingLane()
        RacingLane5 = New RacingLane()
        RacingLane4 = New RacingLane()
        RacingLane3 = New RacingLane()
        RacingLane2 = New RacingLane()
        RacingLane1 = New RacingLane()
        ResultsTab = New TabPage()
        Result8 = New Result()
        Result7 = New Result()
        Result6 = New Result()
        Result5 = New Result()
        Result4 = New Result()
        Result3 = New Result()
        Result2 = New Result()
        Result1 = New Result()
        DisplayTimer = New Timer(components)
        TabControl1.SuspendLayout()
        AthletesTab.SuspendLayout()
        RaceTab.SuspendLayout()
        ResultsTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(AthletesTab)
        TabControl1.Controls.Add(RaceTab)
        TabControl1.Controls.Add(ResultsTab)
        TabControl1.Cursor = Cursors.IBeam
        TabControl1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(30, 5)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1471, 1109)
        TabControl1.TabIndex = 0
        ' 
        ' AthletesTab
        ' 
        AthletesTab.BackColor = Color.Moccasin
        AthletesTab.Controls.Add(Label1)
        AthletesTab.Controls.Add(LaneDefinition8)
        AthletesTab.Controls.Add(LaneDefinition7)
        AthletesTab.Controls.Add(LaneDefinition6)
        AthletesTab.Controls.Add(LaneDefinition5)
        AthletesTab.Controls.Add(LaneDefinition4)
        AthletesTab.Controls.Add(LaneDefinition3)
        AthletesTab.Controls.Add(LaneDefinition2)
        AthletesTab.Controls.Add(LaneDefinition1)
        AthletesTab.Controls.Add(RadioButton8)
        AthletesTab.Controls.Add(RadioButton7)
        AthletesTab.Controls.Add(RadioButton6)
        AthletesTab.Controls.Add(RadioButton5)
        AthletesTab.Controls.Add(RadioButton4)
        AthletesTab.Controls.Add(RadioButton3)
        AthletesTab.Controls.Add(RadioButton2)
        AthletesTab.Controls.Add(RadioButton1)
        AthletesTab.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        AthletesTab.Location = New Point(10, 66)
        AthletesTab.Name = "AthletesTab"
        AthletesTab.Padding = New Padding(3)
        AthletesTab.Size = New Size(1451, 1033)
        AthletesTab.TabIndex = 0
        AthletesTab.Text = "Athletes"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(230, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 48)
        Label1.TabIndex = 16
        Label1.Text = "Lanes Open:"
        ' 
        ' LaneDefinition8
        ' 
        LaneDefinition8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition8.Location = New Point(116, 790)
        LaneDefinition8.Margin = New Padding(4)
        LaneDefinition8.Name = "LaneDefinition8"
        LaneDefinition8.Position = 8
        LaneDefinition8.RaceLane = Nothing
        LaneDefinition8.ResultLane = Nothing
        LaneDefinition8.Size = New Size(939, 100)
        LaneDefinition8.TabIndex = 15
        ' 
        ' LaneDefinition7
        ' 
        LaneDefinition7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition7.Location = New Point(116, 715)
        LaneDefinition7.Margin = New Padding(4)
        LaneDefinition7.Name = "LaneDefinition7"
        LaneDefinition7.Position = 7
        LaneDefinition7.RaceLane = Nothing
        LaneDefinition7.ResultLane = Nothing
        LaneDefinition7.Size = New Size(939, 125)
        LaneDefinition7.TabIndex = 14
        ' 
        ' LaneDefinition6
        ' 
        LaneDefinition6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition6.Location = New Point(116, 623)
        LaneDefinition6.Margin = New Padding(4)
        LaneDefinition6.Name = "LaneDefinition6"
        LaneDefinition6.Position = 6
        LaneDefinition6.RaceLane = Nothing
        LaneDefinition6.ResultLane = Nothing
        LaneDefinition6.Size = New Size(939, 125)
        LaneDefinition6.TabIndex = 13
        ' 
        ' LaneDefinition5
        ' 
        LaneDefinition5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition5.Location = New Point(116, 541)
        LaneDefinition5.Margin = New Padding(4)
        LaneDefinition5.Name = "LaneDefinition5"
        LaneDefinition5.Position = 5
        LaneDefinition5.RaceLane = Nothing
        LaneDefinition5.ResultLane = Nothing
        LaneDefinition5.Size = New Size(939, 125)
        LaneDefinition5.TabIndex = 12
        ' 
        ' LaneDefinition4
        ' 
        LaneDefinition4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition4.Location = New Point(116, 454)
        LaneDefinition4.Margin = New Padding(4)
        LaneDefinition4.Name = "LaneDefinition4"
        LaneDefinition4.Position = 4
        LaneDefinition4.RaceLane = Nothing
        LaneDefinition4.ResultLane = Nothing
        LaneDefinition4.Size = New Size(939, 125)
        LaneDefinition4.TabIndex = 11
        ' 
        ' LaneDefinition3
        ' 
        LaneDefinition3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition3.Location = New Point(116, 374)
        LaneDefinition3.Margin = New Padding(4)
        LaneDefinition3.Name = "LaneDefinition3"
        LaneDefinition3.Position = 3
        LaneDefinition3.RaceLane = Nothing
        LaneDefinition3.ResultLane = Nothing
        LaneDefinition3.Size = New Size(939, 91)
        LaneDefinition3.TabIndex = 10
        ' 
        ' LaneDefinition2
        ' 
        LaneDefinition2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition2.Location = New Point(116, 300)
        LaneDefinition2.Margin = New Padding(4)
        LaneDefinition2.Name = "LaneDefinition2"
        LaneDefinition2.Position = 2
        LaneDefinition2.RaceLane = Nothing
        LaneDefinition2.ResultLane = Nothing
        LaneDefinition2.Size = New Size(939, 125)
        LaneDefinition2.TabIndex = 9
        ' 
        ' LaneDefinition1
        ' 
        LaneDefinition1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LaneDefinition1.Location = New Point(116, 223)
        LaneDefinition1.Margin = New Padding(4)
        LaneDefinition1.Name = "LaneDefinition1"
        LaneDefinition1.Position = 1
        LaneDefinition1.RaceLane = Nothing
        LaneDefinition1.ResultLane = Nothing
        LaneDefinition1.Size = New Size(939, 125)
        LaneDefinition1.TabIndex = 8
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(886, 127)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(72, 52)
        RadioButton8.TabIndex = 7
        RadioButton8.Text = "8"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(794, 127)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(72, 52)
        RadioButton7.TabIndex = 6
        RadioButton7.Text = "7"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(679, 127)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(72, 52)
        RadioButton6.TabIndex = 5
        RadioButton6.Text = "6"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(553, 127)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(72, 52)
        RadioButton5.TabIndex = 4
        RadioButton5.Text = "5"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(886, 40)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(72, 52)
        RadioButton4.TabIndex = 3
        RadioButton4.Text = "4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(794, 40)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(72, 52)
        RadioButton3.TabIndex = 2
        RadioButton3.Text = "3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(679, 40)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 52)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(553, 40)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(72, 52)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RaceTab
        ' 
        RaceTab.BackColor = Color.LightSteelBlue
        RaceTab.Controls.Add(TimeDisplay8)
        RaceTab.Controls.Add(TimeDisplay7)
        RaceTab.Controls.Add(TimeDisplay6)
        RaceTab.Controls.Add(TimeDisplay5)
        RaceTab.Controls.Add(TimeDisplay4)
        RaceTab.Controls.Add(TimeDisplay3)
        RaceTab.Controls.Add(TimeDisplay2)
        RaceTab.Controls.Add(TimeDisplay1)
        RaceTab.Controls.Add(RunningTimeDisplay1)
        RaceTab.Controls.Add(Reset)
        RaceTab.Controls.Add(StartStop)
        RaceTab.Controls.Add(RacingLane8)
        RaceTab.Controls.Add(RacingLane7)
        RaceTab.Controls.Add(RacingLane6)
        RaceTab.Controls.Add(RacingLane5)
        RaceTab.Controls.Add(RacingLane4)
        RaceTab.Controls.Add(RacingLane3)
        RaceTab.Controls.Add(RacingLane2)
        RaceTab.Controls.Add(RacingLane1)
        RaceTab.Location = New Point(10, 66)
        RaceTab.Name = "RaceTab"
        RaceTab.Padding = New Padding(3)
        RaceTab.Size = New Size(180, 24)
        RaceTab.TabIndex = 1
        RaceTab.Text = "Race"
        ' 
        ' TimeDisplay8
        ' 
        TimeDisplay8.AutoSize = True
        TimeDisplay8.FormattedTime = Nothing
        TimeDisplay8.Location = New Point(1073, 914)
        TimeDisplay8.Name = "TimeDisplay8"
        TimeDisplay8.Size = New Size(268, 48)
        TimeDisplay8.TabIndex = 19
        TimeDisplay8.Text = "TimeDisplay8"
        ' 
        ' TimeDisplay7
        ' 
        TimeDisplay7.AutoSize = True
        TimeDisplay7.FormattedTime = Nothing
        TimeDisplay7.Location = New Point(1073, 833)
        TimeDisplay7.Name = "TimeDisplay7"
        TimeDisplay7.Size = New Size(268, 48)
        TimeDisplay7.TabIndex = 18
        TimeDisplay7.Text = "TimeDisplay7"
        ' 
        ' TimeDisplay6
        ' 
        TimeDisplay6.AutoSize = True
        TimeDisplay6.FormattedTime = Nothing
        TimeDisplay6.Location = New Point(1073, 726)
        TimeDisplay6.Name = "TimeDisplay6"
        TimeDisplay6.Size = New Size(268, 48)
        TimeDisplay6.TabIndex = 17
        TimeDisplay6.Text = "TimeDisplay6"
        ' 
        ' TimeDisplay5
        ' 
        TimeDisplay5.AutoSize = True
        TimeDisplay5.FormattedTime = Nothing
        TimeDisplay5.Location = New Point(1072, 616)
        TimeDisplay5.Name = "TimeDisplay5"
        TimeDisplay5.Size = New Size(268, 48)
        TimeDisplay5.TabIndex = 16
        TimeDisplay5.Text = "TimeDisplay5"
        ' 
        ' TimeDisplay4
        ' 
        TimeDisplay4.AutoSize = True
        TimeDisplay4.FormattedTime = Nothing
        TimeDisplay4.Location = New Point(1072, 518)
        TimeDisplay4.Name = "TimeDisplay4"
        TimeDisplay4.Size = New Size(268, 48)
        TimeDisplay4.TabIndex = 15
        TimeDisplay4.Text = "TimeDisplay4"
        ' 
        ' TimeDisplay3
        ' 
        TimeDisplay3.AutoSize = True
        TimeDisplay3.FormattedTime = Nothing
        TimeDisplay3.Location = New Point(1072, 427)
        TimeDisplay3.Name = "TimeDisplay3"
        TimeDisplay3.Size = New Size(268, 48)
        TimeDisplay3.TabIndex = 14
        TimeDisplay3.Text = "TimeDisplay3"
        ' 
        ' TimeDisplay2
        ' 
        TimeDisplay2.AutoSize = True
        TimeDisplay2.FormattedTime = Nothing
        TimeDisplay2.Location = New Point(1072, 332)
        TimeDisplay2.Name = "TimeDisplay2"
        TimeDisplay2.Size = New Size(268, 48)
        TimeDisplay2.TabIndex = 13
        TimeDisplay2.Text = "TimeDisplay2"
        ' 
        ' TimeDisplay1
        ' 
        TimeDisplay1.AutoSize = True
        TimeDisplay1.FormattedTime = Nothing
        TimeDisplay1.Location = New Point(1072, 232)
        TimeDisplay1.Name = "TimeDisplay1"
        TimeDisplay1.Size = New Size(268, 48)
        TimeDisplay1.TabIndex = 12
        TimeDisplay1.Text = "TimeDisplay1"
        ' 
        ' RunningTimeDisplay1
        ' 
        RunningTimeDisplay1.AutoSize = True
        RunningTimeDisplay1.Font = New Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point)
        RunningTimeDisplay1.FormattedTime = Nothing
        RunningTimeDisplay1.Location = New Point(603, 53)
        RunningTimeDisplay1.Name = "RunningTimeDisplay1"
        RunningTimeDisplay1.Size = New Size(186, 95)
        RunningTimeDisplay1.TabIndex = 11
        RunningTimeDisplay1.Text = "Test"
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(937, 16)
        Reset.Name = "Reset"
        Reset.Size = New Size(230, 169)
        Reset.TabIndex = 10
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' StartStop
        ' 
        StartStop.Location = New Point(275, 16)
        StartStop.Name = "StartStop"
        StartStop.Size = New Size(230, 169)
        StartStop.TabIndex = 9
        StartStop.Text = "Start"
        StartStop.UseVisualStyleBackColor = True
        ' 
        ' RacingLane8
        ' 
        RacingLane8.Location = New Point(32, 871)
        RacingLane8.Margin = New Padding(172, 22, 172, 22)
        RacingLane8.Name = "RacingLane8"
        RacingLane8.Position = 8
        RacingLane8.RightToLeft = RightToLeft.No
        RacingLane8.Size = New Size(976, 123)
        RacingLane8.TabIndex = 7
        RacingLane8.TimeDisp = Nothing
        ' 
        ' RacingLane7
        ' 
        RacingLane7.Location = New Point(32, 792)
        RacingLane7.Margin = New Padding(103, 17, 103, 17)
        RacingLane7.Name = "RacingLane7"
        RacingLane7.Position = 7
        RacingLane7.Size = New Size(982, 122)
        RacingLane7.TabIndex = 6
        RacingLane7.TimeDisp = Nothing
        ' 
        ' RacingLane6
        ' 
        RacingLane6.Location = New Point(32, 692)
        RacingLane6.Margin = New Padding(62, 13, 62, 13)
        RacingLane6.Name = "RacingLane6"
        RacingLane6.Position = 6
        RacingLane6.Size = New Size(976, 120)
        RacingLane6.TabIndex = 5
        RacingLane6.TimeDisp = Nothing
        ' 
        ' RacingLane5
        ' 
        RacingLane5.Location = New Point(32, 578)
        RacingLane5.Margin = New Padding(37, 10, 37, 10)
        RacingLane5.Name = "RacingLane5"
        RacingLane5.Position = 5
        RacingLane5.Size = New Size(982, 119)
        RacingLane5.TabIndex = 4
        RacingLane5.TimeDisp = Nothing
        ' 
        ' RacingLane4
        ' 
        RacingLane4.Location = New Point(32, 482)
        RacingLane4.Margin = New Padding(22, 8, 22, 8)
        RacingLane4.Name = "RacingLane4"
        RacingLane4.Position = 4
        RacingLane4.Size = New Size(976, 124)
        RacingLane4.TabIndex = 3
        RacingLane4.TimeDisp = Nothing
        ' 
        ' RacingLane3
        ' 
        RacingLane3.Location = New Point(32, 393)
        RacingLane3.Margin = New Padding(13, 6, 13, 6)
        RacingLane3.Name = "RacingLane3"
        RacingLane3.Position = 3
        RacingLane3.Size = New Size(982, 114)
        RacingLane3.TabIndex = 2
        RacingLane3.TimeDisp = Nothing
        ' 
        ' RacingLane2
        ' 
        RacingLane2.Location = New Point(32, 295)
        RacingLane2.Margin = New Padding(8, 5, 8, 5)
        RacingLane2.Name = "RacingLane2"
        RacingLane2.Position = 2
        RacingLane2.Size = New Size(982, 119)
        RacingLane2.TabIndex = 1
        RacingLane2.TimeDisp = Nothing
        ' 
        ' RacingLane1
        ' 
        RacingLane1.Location = New Point(32, 192)
        RacingLane1.Margin = New Padding(5, 4, 5, 4)
        RacingLane1.Name = "RacingLane1"
        RacingLane1.Position = 1
        RacingLane1.Size = New Size(976, 117)
        RacingLane1.TabIndex = 0
        RacingLane1.TimeDisp = Nothing
        ' 
        ' ResultsTab
        ' 
        ResultsTab.BackColor = Color.Aquamarine
        ResultsTab.Controls.Add(Result8)
        ResultsTab.Controls.Add(Result7)
        ResultsTab.Controls.Add(Result6)
        ResultsTab.Controls.Add(Result5)
        ResultsTab.Controls.Add(Result4)
        ResultsTab.Controls.Add(Result3)
        ResultsTab.Controls.Add(Result2)
        ResultsTab.Controls.Add(Result1)
        ResultsTab.Location = New Point(10, 66)
        ResultsTab.Name = "ResultsTab"
        ResultsTab.Padding = New Padding(3)
        ResultsTab.Size = New Size(1451, 1033)
        ResultsTab.TabIndex = 2
        ResultsTab.Text = "Results"
        ' 
        ' Result8
        ' 
        Result8.Location = New Point(4, 743)
        Result8.Margin = New Padding(62, 13, 62, 13)
        Result8.Name = "Result8"
        Result8.Position = 8
        Result8.Size = New Size(1438, 121)
        Result8.TabIndex = 7
        ' 
        ' Result7
        ' 
        Result7.Location = New Point(3, 637)
        Result7.Margin = New Padding(37, 10, 37, 10)
        Result7.Name = "Result7"
        Result7.Position = 7
        Result7.Size = New Size(1462, 135)
        Result7.TabIndex = 6
        ' 
        ' Result6
        ' 
        Result6.Location = New Point(3, 532)
        Result6.Margin = New Padding(22, 8, 22, 8)
        Result6.Name = "Result6"
        Result6.Position = 6
        Result6.Size = New Size(1439, 122)
        Result6.TabIndex = 5
        ' 
        ' Result5
        ' 
        Result5.Location = New Point(3, 428)
        Result5.Margin = New Padding(13, 6, 13, 6)
        Result5.Name = "Result5"
        Result5.Position = 5
        Result5.Size = New Size(1441, 131)
        Result5.TabIndex = 4
        ' 
        ' Result4
        ' 
        Result4.Location = New Point(3, 320)
        Result4.Margin = New Padding(8, 5, 8, 5)
        Result4.Name = "Result4"
        Result4.Position = 4
        Result4.Size = New Size(1458, 135)
        Result4.TabIndex = 3
        ' 
        ' Result3
        ' 
        Result3.Location = New Point(2, 209)
        Result3.Margin = New Padding(5, 4, 5, 4)
        Result3.Name = "Result3"
        Result3.Position = 3
        Result3.Size = New Size(1438, 138)
        Result3.TabIndex = 2
        ' 
        ' Result2
        ' 
        Result2.Location = New Point(2, 109)
        Result2.Margin = New Padding(8, 5, 8, 5)
        Result2.Name = "Result2"
        Result2.Position = 2
        Result2.Size = New Size(1438, 128)
        Result2.TabIndex = 1
        ' 
        ' Result1
        ' 
        Result1.Location = New Point(0, 0)
        Result1.Margin = New Padding(5, 4, 5, 4)
        Result1.Name = "Result1"
        Result1.Position = 1
        Result1.Size = New Size(1430, 145)
        Result1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(15F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1495, 1133)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        AthletesTab.ResumeLayout(False)
        AthletesTab.PerformLayout()
        RaceTab.ResumeLayout(False)
        RaceTab.PerformLayout()
        ResultsTab.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AthletesTab As TabPage
    Friend WithEvents RaceTab As TabPage
    Friend WithEvents ResultsTab As TabPage
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents LaneDefinition2 As LaneDefinition
    Friend WithEvents LaneDefinition1 As LaneDefinition
    Friend WithEvents LaneDefinition3 As LaneDefinition
    Friend WithEvents LaneDefinition5 As LaneDefinition
    Friend WithEvents LaneDefinition4 As LaneDefinition
    Friend WithEvents LaneDefinition7 As LaneDefinition
    Friend WithEvents LaneDefinition6 As LaneDefinition
    Friend WithEvents LaneDefinition8 As LaneDefinition
    Friend WithEvents Label1 As Label
    Friend WithEvents RacingLane1 As RacingLane
    Friend WithEvents RacingLane2 As RacingLane
    Friend WithEvents RacingLane3 As RacingLane
    Friend WithEvents RacingLane4 As RacingLane
    Friend WithEvents RacingLane5 As RacingLane
    Friend WithEvents RacingLane7 As RacingLane
    Friend WithEvents RacingLane6 As RacingLane
    Friend WithEvents RacingLane8 As RacingLane
    Friend WithEvents DisplayTimer As Timer
    Friend WithEvents StartStop As Button
    Friend WithEvents Reset As Button
    Friend WithEvents RunningTimeDisplay1 As RunningTimeDisplay
    Friend WithEvents TimeDisplay1 As TimeDisplay
    Friend WithEvents TimeDisplay4 As TimeDisplay
    Friend WithEvents TimeDisplay3 As TimeDisplay
    Friend WithEvents TimeDisplay2 As TimeDisplay
    Friend WithEvents TimeDisplay8 As TimeDisplay
    Friend WithEvents TimeDisplay7 As TimeDisplay
    Friend WithEvents TimeDisplay6 As TimeDisplay
    Friend WithEvents TimeDisplay5 As TimeDisplay
    Friend WithEvents Result1 As Result
    Friend WithEvents Result2 As Result
    Friend WithEvents Result3 As Result
    Friend WithEvents Result4 As Result
    Friend WithEvents Result5 As Result
    Friend WithEvents Result6 As Result
    Friend WithEvents Result7 As Result
    Friend WithEvents Result8 As Result
End Class
