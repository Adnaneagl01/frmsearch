<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ville = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.viller = New System.Windows.Forms.RadioButton()
        Me.prenomr = New System.Windows.Forms.RadioButton()
        Me.nomr = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ville)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "creation de recherche"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ville"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nom"
        '
        'ville
        '
        Me.ville.Location = New System.Drawing.Point(559, 32)
        Me.ville.Name = "ville"
        Me.ville.Size = New System.Drawing.Size(149, 20)
        Me.ville.TabIndex = 2
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(329, 32)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(149, 20)
        Me.prenom.TabIndex = 3
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(90, 32)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(149, 20)
        Me.nom.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.viller)
        Me.GroupBox2.Controls.Add(Me.prenomr)
        Me.GroupBox2.Controls.Add(Me.nomr)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 86)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trier par"
        '
        'viller
        '
        Me.viller.AutoSize = True
        Me.viller.Location = New System.Drawing.Point(549, 38)
        Me.viller.Name = "viller"
        Me.viller.Size = New System.Drawing.Size(44, 17)
        Me.viller.TabIndex = 11
        Me.viller.TabStop = True
        Me.viller.Text = "Ville"
        Me.viller.UseVisualStyleBackColor = True
        '
        'prenomr
        '
        Me.prenomr.AutoSize = True
        Me.prenomr.Location = New System.Drawing.Point(316, 38)
        Me.prenomr.Name = "prenomr"
        Me.prenomr.Size = New System.Drawing.Size(61, 17)
        Me.prenomr.TabIndex = 10
        Me.prenomr.TabStop = True
        Me.prenomr.Text = "Prenom"
        Me.prenomr.UseVisualStyleBackColor = True
        '
        'nomr
        '
        Me.nomr.AutoSize = True
        Me.nomr.Location = New System.Drawing.Point(122, 38)
        Me.nomr.Name = "nomr"
        Me.nomr.Size = New System.Drawing.Size(47, 17)
        Me.nomr.TabIndex = 9
        Me.nomr.TabStop = True
        Me.nomr.Text = "Nom"
        Me.nomr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(777, 209)
        Me.DataGridView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 526)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ville As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents viller As RadioButton
    Friend WithEvents prenomr As RadioButton
    Friend WithEvents nomr As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
