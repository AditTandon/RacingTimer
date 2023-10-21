Public Class Form1
    Dim LaneDefs(7) As LaneDefinition
    Dim RaceLanes(7) As RacingLane
    Dim RaceResults(7) As Result

    Dim NumOfRacers As Integer

    Dim RandomGen As New Random()
    Dim RandomRacers As New List(Of Integer)()

    Dim Counter As Integer = 1

    Dim RaceFinishers As New List(Of Integer)()

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click, RadioButton5.Click, RadioButton6.Click, RadioButton7.Click, RadioButton8.Click

        Dim radButton As RadioButton = sender

        Dim selectedRadio = CInt(radButton.Text)

        NumOfRacers = selectedRadio

        ChooseRandomWinners()

        For i As Integer = 0 To selectedRadio - 1
            LaneDefs(i).OpenLane()
        Next

        For i As Integer = selectedRadio To (LaneDefs.Length - 1)
            LaneDefs(i).CloseLane()
        Next

        ResetRaceLines()

        For i As Integer = 0 To NumOfRacers - 1
            RaceLanes(i).EmptyTimeDisplay()
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LaneDefs(0) = LaneDefinition1
        RaceLanes(0) = RacingLane1
        RaceLanes(0).TimeDisp = TimeDisplay1
        LaneDefs(0).RaceLane = RaceLanes(0)
        RaceResults(0) = Result1

        LaneDefs(1) = LaneDefinition2
        RaceLanes(1) = RacingLane2
        RaceLanes(1).TimeDisp = TimeDisplay2
        LaneDefs(1).RaceLane = RaceLanes(1)
        RaceResults(1) = Result2

        LaneDefs(2) = LaneDefinition3
        RaceLanes(2) = RacingLane3
        RaceLanes(2).TimeDisp = TimeDisplay3
        LaneDefs(2).RaceLane = RaceLanes(2)
        RaceResults(2) = Result3

        LaneDefs(3) = LaneDefinition4
        RaceLanes(3) = RacingLane4
        RaceLanes(3).TimeDisp = TimeDisplay4
        LaneDefs(3).RaceLane = RaceLanes(3)
        RaceResults(3) = Result4

        LaneDefs(4) = LaneDefinition5
        RaceLanes(4) = RacingLane5
        RaceLanes(4).TimeDisp = TimeDisplay5
        LaneDefs(4).RaceLane = RaceLanes(4)
        RaceResults(4) = Result5

        LaneDefs(5) = LaneDefinition6
        RaceLanes(5) = RacingLane6
        RaceLanes(5).TimeDisp = TimeDisplay6
        LaneDefs(5).RaceLane = RaceLanes(5)
        RaceResults(5) = Result6

        LaneDefs(6) = LaneDefinition7
        RaceLanes(6) = RacingLane7
        RaceLanes(6).TimeDisp = TimeDisplay7
        LaneDefs(6).RaceLane = RaceLanes(6)
        RaceResults(6) = Result7

        LaneDefs(7) = LaneDefinition8
        RaceLanes(7) = RacingLane8
        RaceLanes(7).TimeDisp = TimeDisplay8
        LaneDefs(7).RaceLane = RaceLanes(7)
        RaceResults(7) = Result8

        RadioButton8.PerformClick()

        RunningTimeDisplay1.ResetTime()
        Dim DisplayTimer As Timer = RunningTimeDisplay1.GetTimer1()

        ' For loop to hide all the time display text and all race results lines
        For i As Integer = 0 To 7
            RaceLanes(i).EmptyTimeDisplay()
            RaceResults(i).HideResults()
        Next
    End Sub

    Private Sub StartStop_Click(sender As Object, e As EventArgs) Handles StartStop.Click
        If StartStop.Text = "Stop" Then
            If Counter = NumOfRacers Then
                RaceLanes(RandomRacers(Counter - 1)).TimeDisp.FormattedTime = RunningTimeDisplay1.FormattedTime()
                RaceLanes(RandomRacers(Counter - 1)).TimeDisp.ShowTime()

                RaceResults(Counter - 1).Position = Counter.ToString
                RaceResults(Counter - 1).AthleteName.Text = RaceLanes(RandomRacers(Counter - 1)).AthleteName.Text
                RaceResults(Counter - 1).Country.Image = RaceLanes(RandomRacers(Counter - 1)).CountryFlag.Image
                RaceResults(Counter - 1).Time.Text = RaceLanes(RandomRacers(Counter - 1)).TimeDisp.FormattedTime

                RunningTimeDisplay1.StopTimer()
                Counter = 1
                RandomRacers.Clear()
                StartStop.Text = "Start"
                StartStop.Enabled = False
            Else
                RaceLanes(RandomRacers(Counter - 1)).TimeDisp.FormattedTime = RunningTimeDisplay1.FormattedTime()
                RaceLanes(RandomRacers(Counter - 1)).TimeDisp.ShowTime()

                RaceResults(Counter - 1).Position = Counter.ToString
                RaceResults(Counter - 1).AthleteName.Text = RaceLanes(RandomRacers(Counter - 1)).AthleteName.Text
                RaceResults(Counter - 1).Country.Image = RaceLanes(RandomRacers(Counter - 1)).CountryFlag.Image
                RaceResults(Counter - 1).Time.Text = RaceLanes(RandomRacers(Counter - 1)).TimeDisp.FormattedTime

                If Counter = 1 Then
                    RaceResults(Counter - 1).SetAnimFlag(LaneDefs(RandomRacers(Counter - 1)).GetCountry())
                    RaceResults(Counter - 1).PlayAnthem(LaneDefs(RandomRacers(Counter - 1)).GetCountry())
                End If

                Counter += 1
            End If
        Else
            ResetRaceLines()
            RunningTimeDisplay1.StartTimer()
            StartStop.Text = "Stop"
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        If StartStop.Text = "Stop" Then
            StartStop.Text = "Start"
        End If
        RandomRacers.Clear()
        Counter = 1
        RunningTimeDisplay1.StopTimer()
        RunningTimeDisplay1.ResetTime()

        For i As Integer = 0 To NumOfRacers - 1
            RaceLanes(i).EmptyTimeDisplay()
        Next

        StartStop.Enabled = True
        ResetRaceLines()
        ChooseRandomWinners()
    End Sub

    Private Sub ChooseRandomWinners()
        RandomRacers.Clear()
        While RandomRacers.Count < NumOfRacers
            Dim RandNum As Integer = RandomGen.Next(0, NumOfRacers)
            If Not RandomRacers.Contains(RandNum) Then
                RandomRacers.Add(RandNum)
            End If
        End While
    End Sub

    Private Sub ResetRaceLines()
        For i As Integer = 0 To NumOfRacers - 1
            RaceResults(i).HideResults()
        Next
    End Sub
End Class
