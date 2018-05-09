Public Class Form1
    Dim time As System.DateTime = Date.Parse("00:00:30")
    Dim starttime As System.DateTime = Date.Parse("00:00:00")
    Dim wave As Integer = 0
    Dim spawn As Integer = 0
    Dim kills As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        timer_box.Text = "0030"
        dataLabel_CurrentWave.Text = "0"
        dataLabel_MinionsSpawned.Text = "0"
        dataLabel_PerfectCS.Text = "0"        
        Timer1.Stop()
        wavetimer.Stop()
        perfectcounter.Stop()
        time = Date.Parse("00:00:30")
        wave = 0
        spawn = 0
        kills = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time.AddSeconds(1)
        timer_box.Text = time.ToString("mmss")
        Dim gametime As Integer = (time - starttime).TotalSeconds
        If gametime = 65 Then
            wave += 1
            updateMinionCount()
            wavetimer.Start()
        End If
        
    End Sub

    Dim prevWave As Integer
    Private Sub updateMinionCount()
        Dim iscanon As Byte = 0
        If time.Minute < 20 Then
            If (wave Mod 3.0 = 0) Then
                iscanon = 1
            End If
        ElseIf time.Minute > 20 And time.Minute < 35 Then
            If (wave Mod 2.0 = 0) Then
                iscanon = 1
            End If
        Else
            iscanon = 1
        End If

        spawn = spawn + 6 + iscanon
        dataLabel_CurrentWave.Text = wave.ToString
        dataLabel_MinionsSpawned.Text = spawn.ToString


        If (spawn - kills) > 7 Then
            perfectcounter.Interval = (1.0 / (spawn - kills - prevWave)) * 30000
            perfectcounter.Start()
        End If
        prevWave = 6 + iscanon
    End Sub

    Private Sub wavetimer_Tick(sender As Object, e As EventArgs) Handles wavetimer.Tick
        wave += 1
        updateMinionCount()
    End Sub

    Private Sub perfectcounter_Tick(sender As Object, e As EventArgs) Handles perfectcounter.Tick
        kills += 1
        dataLabel_PerfectCS.Text = kills.ToString
    End Sub
End Class
