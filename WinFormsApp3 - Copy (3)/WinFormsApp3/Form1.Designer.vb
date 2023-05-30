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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Button1 = New Button()
        input_password = New TextBox()
        input_username = New TextBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 15)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(461, 729)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(100), CByte(143), CByte(141))
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = SystemColors.ControlLight
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1065, 96)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(82), CByte(82), CByte(82))
        Label1.Location = New Point(342, 36)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 29)
        Label1.TabIndex = 0
        Label1.Text = "BAROKAH FUTSAL CENTER"' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(251), CByte(190), CByte(58))
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(input_password)
        Panel2.Controls.Add(input_username)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(456, 96)
        Panel2.Margin = New Padding(4, 4, 4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(609, 636)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(100), CByte(143), CByte(141))
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.DialogResult = DialogResult.Continue
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(100), CByte(143), CByte(141))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(212, 461)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(165, 56)
        Button1.TabIndex = 3
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' input_password
        ' 
        input_password.BorderStyle = BorderStyle.FixedSingle
        input_password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        input_password.Location = New Point(140, 369)
        input_password.Margin = New Padding(4, 4, 4, 4)
        input_password.Name = "input_password"
        input_password.PlaceholderText = "               Password"
        input_password.Size = New Size(310, 39)
        input_password.TabIndex = 2
        ' 
        ' input_username
        ' 
        input_username.BackColor = Color.White
        input_username.BorderStyle = BorderStyle.FixedSingle
        input_username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        input_username.ForeColor = SystemColors.MenuText
        input_username.Location = New Point(140, 294)
        input_username.Margin = New Padding(4, 4, 4, 4)
        input_username.Name = "input_username"
        input_username.PlaceholderText = "               Username"
        input_username.Size = New Size(310, 39)
        input_username.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(185, 44)
        PictureBox2.Margin = New Padding(4, 4, 4, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(232, 210)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1065, 732)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        MaximumSize = New Size(1087, 788)
        MinimizeBox = False
        MinimumSize = New Size(1087, 788)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents input_password As TextBox
    Friend WithEvents input_username As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
