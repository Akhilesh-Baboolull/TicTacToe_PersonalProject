<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnabt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(259, 451)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(23, 19)
        Me.CheckedListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Courgette", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(221, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START GAME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnabt
        '
        Me.btnabt.BackColor = System.Drawing.Color.Blue
        Me.btnabt.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnabt.FlatAppearance.BorderSize = 3
        Me.btnabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnabt.Font = New System.Drawing.Font("Courgette", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabt.ForeColor = System.Drawing.Color.Black
        Me.btnabt.Location = New System.Drawing.Point(221, 185)
        Me.btnabt.Name = "btnabt"
        Me.btnabt.Size = New System.Drawing.Size(205, 46)
        Me.btnabt.TabIndex = 3
        Me.btnabt.Text = "ABOUT"
        Me.btnabt.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Courgette", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(221, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 46)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Stencil", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIC TAC TOE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(438, 423)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnabt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "TIC TAC TOE MAIN MENU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnabt As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
