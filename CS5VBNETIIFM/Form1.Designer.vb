﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loadXMLBtn = New System.Windows.Forms.Button()
        Me.loadXMLDialog = New System.Windows.Forms.OpenFileDialog()
        Me.filmsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'actorNameCB
        '
        Me.actorNameCB.FormattingEnabled = True
        Me.actorNameCB.Location = New System.Drawing.Point(235, 57)
        Me.actorNameCB.Name = "actorNameCB"
        Me.actorNameCB.Size = New System.Drawing.Size(154, 23)
        Me.actorNameCB.TabIndex = 0
        Me.actorNameCB.Text = "-- Seleccione un Arctor --"
        Me.actorNameCB.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(235, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actor"
        '
        'loadXMLBtn
        '
        Me.loadXMLBtn.Location = New System.Drawing.Point(66, 56)
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
        Me.filmsListBox.Location = New System.Drawing.Point(235, 106)
        Me.filmsListBox.Name = "filmsListBox"
        Me.filmsListBox.Size = New System.Drawing.Size(154, 214)
        Me.filmsListBox.TabIndex = 3
        Me.filmsListBox.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.filmsListBox)
        Me.Controls.Add(Me.loadXMLBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.actorNameCB)
        Me.Name = "Form1"
        Me.Text = "Estadísticas Películas - Felipe Mancilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents actorNameCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents loadXMLBtn As Button
    Friend WithEvents loadXMLDialog As OpenFileDialog
    Friend WithEvents filmsListBox As ListBox
End Class
