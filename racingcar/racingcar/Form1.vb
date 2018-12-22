Public Class Form1
    Dim Speed As Integer
    Dim road(10) As PictureBox
    Dim Score As Integer = 0




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load








        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9
        road(9) = PictureBox10


    End Sub



    Private Sub roadmover_Tick(sender As Object, e As EventArgs) Handles roadmover.Tick
        For x As Integer = 0 To 9
            road(x).Top += 2

            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height

            End If
        Next
        If score > 10 And score < 20 Then
            speed = 4
        End If
        If score > 20 And score < 40 Then
            speed = 5
        End If
        If score > 40 Then
            speed = 6
        End If
        If score > 50 Then
            speed = 7
        End If
        If score > 60 Then
            speed = 8
        End If
        speed_text.Text = "Speed :" & Speed


        If (car1.Bounds.IntersectsWith(enemycar1.Bounds)) Then
            gameover()
        End If
        If (car1.Bounds.IntersectsWith(enemycar2.Bounds)) Then
            gameover()
        End If
        If (car1.Bounds.IntersectsWith(enemycar3.Bounds)) Then
            gameover()
        End If





    End Sub
    Private Sub gameover()
        replay_button.Visible = True


        end_text.Visible = True
        Button1.Visible = True



        roadmover.Stop()
        left_mover.Stop()
        right_mover.Stop()
        enemy_mover1.Stop()
        enemy_mover2.Stop()
        enemy_mover3.Stop()







    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            right_mover.Start()



        End If
        If e.KeyCode = Keys.Left Then
            left_mover.Start()



        End If
    End Sub

    Private Sub right_mover_Tick(sender As Object, e As EventArgs) Handles right_mover.Tick
        If (car1.Location.X < 232) Then

            car1.Left += 5
        End If

    End Sub

    Private Sub left_mover_Tick(sender As Object, e As EventArgs) Handles left_mover.Tick
        If (car1.Location.X > 4) Then
            car1.Left -= 5
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        right_mover.Stop()
        left_mover.Stop()



    End Sub

    Private Sub enemy_mover1_Tick(sender As Object, e As EventArgs) Handles enemy_mover1.Tick
        enemycar1.Top += speed + speed
        If enemycar1.Top >= Me.Height Then
            Score += 1
            score_text.Text = "Score :" & Score

            enemycar1.Top = -(CInt(Math.Ceiling(Rnd() * 120)) + enemycar1.Height)
            enemycar1.Left = CInt(Math.Ceiling(Rnd() * 30)) + 0



        End If
    End Sub

    Private Sub enemy_mover2_Tick(sender As Object, e As EventArgs) Handles enemy_mover2.Tick
        enemycar2.Top += speed * 2
        If enemycar2.Top >= Me.Height Then
            Score += 1
            score_text.Text = "Score :" & Score
            enemycar2.Top = -(CInt(Math.Ceiling(Rnd() * 120)) + enemycar2.Height)
            enemycar2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100





        End If
    End Sub

    Private Sub enemy_mover3_Tick(sender As Object, e As EventArgs) Handles enemy_mover3.Tick
        enemycar3.Top += speed * 3 / 2
        If enemycar3.Top >= Me.Height Then
            Score += 1
            score_text.Text = "Score :" & Score
            enemycar3.Top = -(CInt(Math.Ceiling(Rnd() * 110)) + enemycar3.Height)
            enemycar3.Left = CInt(Math.Ceiling(Rnd() * 100)) + 150



        End If
    End Sub

    Private Sub replay_button_Click(sender As Object, e As EventArgs) Handles replay_button.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Visible = True
        Me.Dispose()






    End Sub



End Class
