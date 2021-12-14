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
        Me.actorNameCB = New System.Windows.Forms.ComboBox()
        Me.actorLabel = New System.Windows.Forms.Label()
        Me.loadXMLBtn = New System.Windows.Forms.Button()
        Me.loadXMLDialog = New System.Windows.Forms.OpenFileDialog()
        Me.filmsListBox = New System.Windows.Forms.ListBox()
        Me.filmsLabel = New System.Windows.Forms.Label()
        Me.detalleGB = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CategoryLB = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idiomasLB = New System.Windows.Forms.ListBox()
        Me.RatingTxt = New System.Windows.Forms.TextBox()
        Me.durationTxt = New System.Windows.Forms.TextBox()
        Me.yearTxt = New System.Windows.Forms.TextBox()
        Me.descriptionTxt = New System.Windows.Forms.TextBox()
        Me.featuresTxt = New System.Windows.Forms.TextBox()
        Me.detalleGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'actorNameCB
        '
        Me.actorNameCB.FormattingEnabled = True
        Me.actorNameCB.Location = New System.Drawing.Point(61, 84)
        Me.actorNameCB.Name = "actorNameCB"
        Me.actorNameCB.Size = New System.Drawing.Size(154, 23)
        Me.actorNameCB.TabIndex = 0
        Me.actorNameCB.Text = "-- Seleccione un Actor --"
        Me.actorNameCB.Visible = False
        '
        'actorLabel
        '
        Me.actorLabel.AutoSize = True
        Me.actorLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.actorLabel.Location = New System.Drawing.Point(61, 57)
        Me.actorLabel.Name = "actorLabel"
        Me.actorLabel.Size = New System.Drawing.Size(38, 15)
        Me.actorLabel.TabIndex = 1
        Me.actorLabel.Text = "Actor"
        Me.actorLabel.Visible = False
        '
        'loadXMLBtn
        '
        Me.loadXMLBtn.Location = New System.Drawing.Point(61, 21)
        Me.loadXMLBtn.Name = "loadXMLBtn"
        Me.loadXMLBtn.Size = New System.Drawing.Size(149, 23)
        Me.loadXMLBtn.TabIndex = 2
        Me.loadXMLBtn.Text = "Cargar XML"
        Me.loadXMLBtn.UseVisualStyleBackColor = True
        '
        'filmsListBox
        '
        Me.filmsListBox.FormattingEnabled = True
        Me.filmsListBox.ItemHeight = 15
        Me.filmsListBox.Location = New System.Drawing.Point(61, 148)
        Me.filmsListBox.Name = "filmsListBox"
        Me.filmsListBox.Size = New System.Drawing.Size(154, 214)
        Me.filmsListBox.TabIndex = 3
        Me.filmsListBox.Visible = False
        '
        'filmsLabel
        '
        Me.filmsLabel.AutoSize = True
        Me.filmsLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.filmsLabel.Location = New System.Drawing.Point(61, 121)
        Me.filmsLabel.Name = "filmsLabel"
        Me.filmsLabel.Size = New System.Drawing.Size(96, 15)
        Me.filmsLabel.TabIndex = 4
        Me.filmsLabel.Text = "Filmes por actor"
        Me.filmsLabel.Visible = False
        '
        'detalleGB
        '
        Me.detalleGB.Controls.Add(Me.Label7)
        Me.detalleGB.Controls.Add(Me.Label6)
        Me.detalleGB.Controls.Add(Me.Label5)
        Me.detalleGB.Controls.Add(Me.Label4)
        Me.detalleGB.Controls.Add(Me.Label3)
        Me.detalleGB.Controls.Add(Me.Label2)
        Me.detalleGB.Controls.Add(Me.CategoryLB)
        Me.detalleGB.Controls.Add(Me.Label1)
        Me.detalleGB.Controls.Add(Me.idiomasLB)
        Me.detalleGB.Controls.Add(Me.RatingTxt)
        Me.detalleGB.Controls.Add(Me.durationTxt)
        Me.detalleGB.Controls.Add(Me.yearTxt)
        Me.detalleGB.Controls.Add(Me.descriptionTxt)
        Me.detalleGB.Controls.Add(Me.featuresTxt)
        Me.detalleGB.Location = New System.Drawing.Point(251, 21)
        Me.detalleGB.Name = "detalleGB"
        Me.detalleGB.Size = New System.Drawing.Size(502, 341)
        Me.detalleGB.TabIndex = 5
        Me.detalleGB.TabStop = False
        Me.detalleGB.Text = "Detalle Film"
        Me.detalleGB.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(22, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Características especiales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(167, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Puntuación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(22, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Duración"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(167, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Año de lanzamiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(22, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(416, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categorias"
        '
        'CategoryLB
        '
        Me.CategoryLB.FormattingEnabled = True
        Me.CategoryLB.ItemHeight = 15
        Me.CategoryLB.Location = New System.Drawing.Point(416, 74)
        Me.CategoryLB.Name = "CategoryLB"
        Me.CategoryLB.Size = New System.Drawing.Size(80, 244)
        Me.CategoryLB.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(316, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Idiomas"
        '
        'idiomasLB
        '
        Me.idiomasLB.FormattingEnabled = True
        Me.idiomasLB.ItemHeight = 15
        Me.idiomasLB.Location = New System.Drawing.Point(316, 74)
        Me.idiomasLB.Name = "idiomasLB"
        Me.idiomasLB.Size = New System.Drawing.Size(80, 244)
        Me.idiomasLB.TabIndex = 6
        '
        'RatingTxt
        '
        Me.RatingTxt.Location = New System.Drawing.Point(167, 92)
        Me.RatingTxt.Name = "RatingTxt"
        Me.RatingTxt.Size = New System.Drawing.Size(116, 23)
        Me.RatingTxt.TabIndex = 4
        '
        'durationTxt
        '
        Me.durationTxt.Location = New System.Drawing.Point(22, 92)
        Me.durationTxt.Name = "durationTxt"
        Me.durationTxt.Size = New System.Drawing.Size(128, 23)
        Me.durationTxt.TabIndex = 3
        '
        'yearTxt
        '
        Me.yearTxt.Location = New System.Drawing.Point(167, 40)
        Me.yearTxt.Name = "yearTxt"
        Me.yearTxt.Size = New System.Drawing.Size(116, 23)
        Me.yearTxt.TabIndex = 2
        '
        'descriptionTxt
        '
        Me.descriptionTxt.Location = New System.Drawing.Point(22, 40)
        Me.descriptionTxt.Name = "descriptionTxt"
        Me.descriptionTxt.Size = New System.Drawing.Size(128, 23)
        Me.descriptionTxt.TabIndex = 1
        '
        'featuresTxt
        '
        Me.featuresTxt.Location = New System.Drawing.Point(22, 160)
        Me.featuresTxt.Multiline = True
        Me.featuresTxt.Name = "featuresTxt"
        Me.featuresTxt.Size = New System.Drawing.Size(276, 158)
        Me.featuresTxt.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.detalleGB)
        Me.Controls.Add(Me.filmsLabel)
        Me.Controls.Add(Me.filmsListBox)
        Me.Controls.Add(Me.loadXMLBtn)
        Me.Controls.Add(Me.actorLabel)
        Me.Controls.Add(Me.actorNameCB)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadísticas Películas - Felipe Mancilla"
        Me.detalleGB.ResumeLayout(False)
        Me.detalleGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents actorNameCB As ComboBox
    Friend WithEvents actorLabel As Label
    Friend WithEvents loadXMLBtn As Button
    Friend WithEvents loadXMLDialog As OpenFileDialog
    Friend WithEvents filmsListBox As ListBox
    Friend WithEvents filmsLabel As Label
    Friend WithEvents detalleGB As GroupBox
    Friend WithEvents RatingTxt As TextBox
    Friend WithEvents durationTxt As TextBox
    Friend WithEvents yearTxt As TextBox
    Friend WithEvents descriptionTxt As TextBox
    Friend WithEvents featuresTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryLB As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents idiomasLB As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
End Class
