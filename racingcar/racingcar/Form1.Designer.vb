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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.roadmover = New System.Windows.Forms.Timer(Me.components)
        Me.left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_mover1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_mover2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_mover3 = New System.Windows.Forms.Timer(Me.components)
        Me.end_text = New System.Windows.Forms.Label()
        Me.score_text = New System.Windows.Forms.Label()
        Me.replay_button = New System.Windows.Forms.Button()
        Me.speed_text = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.enemycar1 = New System.Windows.Forms.PictureBox()
        Me.car1 = New System.Windows.Forms.PictureBox()
        Me.enemycar2 = New System.Windows.Forms.PictureBox()
        Me.enemycar3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemycar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemycar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemycar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(70, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(274, -44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(274, 86)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(70, 86)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(274, 209)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(70, 223)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Black
        Me.PictureBox7.Location = New System.Drawing.Point(274, 345)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(11, 102)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Black
        Me.PictureBox8.Location = New System.Drawing.Point(70, 345)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(11, 102)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'roadmover
        '
        Me.roadmover.Enabled = True
        Me.roadmover.Interval = 10
        '
        'left_mover
        '
        Me.left_mover.Interval = 10
        '
        'right_mover
        '
        Me.right_mover.Interval = 10
        '
        'enemy_mover1
        '
        Me.enemy_mover1.Enabled = True
        Me.enemy_mover1.Interval = 10
        '
        'enemy_mover2
        '
        Me.enemy_mover2.Enabled = True
        Me.enemy_mover2.Interval = 10
        '
        'enemy_mover3
        '
        Me.enemy_mover3.Enabled = True
        Me.enemy_mover3.Interval = 10
        '
        'end_text
        '
        Me.end_text.AutoSize = True
        Me.end_text.Font = New System.Drawing.Font("Mistral", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_text.ForeColor = System.Drawing.Color.Red
        Me.end_text.Location = New System.Drawing.Point(117, 86)
        Me.end_text.Name = "end_text"
        Me.end_text.Size = New System.Drawing.Size(128, 39)
        Me.end_text.TabIndex = 12
        Me.end_text.Text = "GameOver"
        Me.end_text.Visible = False
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.BackColor = System.Drawing.Color.Transparent
        Me.score_text.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.score_text.Location = New System.Drawing.Point(131, 154)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(114, 35)
        Me.score_text.TabIndex = 13
        Me.score_text.Text = "Score: 0"
        '
        'replay_button
        '
        Me.replay_button.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replay_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.replay_button.Location = New System.Drawing.Point(119, 209)
        Me.replay_button.Name = "replay_button"
        Me.replay_button.Size = New System.Drawing.Size(149, 42)
        Me.replay_button.TabIndex = 14
        Me.replay_button.Text = "Restart"
        Me.replay_button.UseVisualStyleBackColor = True
        Me.replay_button.Visible = False
        '
        'speed_text
        '
        Me.speed_text.AutoSize = True
        Me.speed_text.BackColor = System.Drawing.Color.Transparent
        Me.speed_text.Font = New System.Drawing.Font("Adobe Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed_text.Location = New System.Drawing.Point(300, 9)
        Me.speed_text.Name = "speed_text"
        Me.speed_text.Size = New System.Drawing.Size(90, 33)
        Me.speed_text.TabIndex = 15
        Me.speed_text.Text = "Speed: 0"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Black
        Me.PictureBox9.Location = New System.Drawing.Point(70, 499)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox9.TabIndex = 16
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Black
        Me.PictureBox10.Location = New System.Drawing.Point(274, 499)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(11, 90)
        Me.PictureBox10.TabIndex = 17
        Me.PictureBox10.TabStop = False
        '
        'enemycar1
        '
        Me.enemycar1.Image = CType(resources.GetObject("enemycar1.Image"), System.Drawing.Image)
        Me.enemycar1.Location = New System.Drawing.Point(12, 319)
        Me.enemycar1.Name = "enemycar1"
        Me.enemycar1.Size = New System.Drawing.Size(60, 99)
        Me.enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemycar1.TabIndex = 18
        Me.enemycar1.TabStop = False
        '
        'car1
        '
        Me.car1.Image = CType(resources.GetObject("car1.Image"), System.Drawing.Image)
        Me.car1.Location = New System.Drawing.Point(150, 434)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(65, 117)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car1.TabIndex = 19
        Me.car1.TabStop = False
        '
        'enemycar2
        '
        Me.enemycar2.Image = CType(resources.GetObject("enemycar2.Image"), System.Drawing.Image)
        Me.enemycar2.Location = New System.Drawing.Point(150, -44)
        Me.enemycar2.Name = "enemycar2"
        Me.enemycar2.Size = New System.Drawing.Size(56, 113)
        Me.enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemycar2.TabIndex = 20
        Me.enemycar2.TabStop = False
        '
        'enemycar3
        '
        Me.enemycar3.Image = CType(resources.GetObject("enemycar3.Image"), System.Drawing.Image)
        Me.enemycar3.Location = New System.Drawing.Point(306, 192)
        Me.enemycar3.Name = "enemycar3"
        Me.enemycar3.Size = New System.Drawing.Size(53, 90)
        Me.enemycar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemycar3.TabIndex = 21
        Me.enemycar3.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(143, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Main menu"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(400, 600)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.enemycar3)
        Me.Controls.Add(Me.enemycar2)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.enemycar1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.speed_text)
        Me.Controls.Add(Me.replay_button)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.end_text)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(400, 600)
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Racing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemycar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemycar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemycar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents roadmover As Timer
    Friend WithEvents left_mover As Timer
    Friend WithEvents right_mover As Timer
    Friend WithEvents enemy_mover1 As Timer
    Friend WithEvents enemy_mover2 As Timer
    Friend WithEvents enemy_mover3 As Timer
    Friend WithEvents end_text As Label
    Friend WithEvents score_text As Label
    Friend WithEvents replay_button As Button
    Friend WithEvents speed_text As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents enemycar1 As PictureBox
    Friend WithEvents car1 As PictureBox
    Friend WithEvents enemycar2 As PictureBox
    Friend WithEvents enemycar3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
