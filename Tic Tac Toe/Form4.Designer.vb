<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 121)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proceeding Will Exit The Game And You Will Lose All Your Game Progress And Scores" &
    "!! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do You Want To Continue? See You Again!"
        '
        'btnyes
        '
        Me.btnyes.BackColor = System.Drawing.Color.Blue
        Me.btnyes.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnyes.FlatAppearance.BorderSize = 3
        Me.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyes.Font = New System.Drawing.Font("Courgette", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyes.ForeColor = System.Drawing.Color.Black
        Me.btnyes.Location = New System.Drawing.Point(186, 133)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(117, 34)
        Me.btnyes.TabIndex = 1
        Me.btnyes.Text = "YES"
        Me.btnyes.UseVisualStyleBackColor = False
        '
        'btnno
        '
        Me.btnno.BackColor = System.Drawing.Color.Blue
        Me.btnno.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnno.FlatAppearance.BorderSize = 3
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Courgette", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnno.ForeColor = System.Drawing.Color.Black
        Me.btnno.Location = New System.Drawing.Point(12, 133)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(117, 34)
        Me.btnno.TabIndex = 2
        Me.btnno.Text = "NO"
        Me.btnno.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(315, 179)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnyes)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONFIRMATION"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnyes As Button
    Friend WithEvents btnno As Button
End Class
