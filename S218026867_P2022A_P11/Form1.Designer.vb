<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bwdestination
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
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_rating = New System.Windows.Forms.Button()
        Me.btn_highest = New System.Windows.Forms.Button()
        Me.btn_total = New System.Windows.Forms.Button()
        Me.grd_destination = New UJGrid.UJGrid()
        Me.btn_ratio = New System.Windows.Forms.Button()
        Me.btn_setup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(12, 61)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 23)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_rating
        '
        Me.btn_rating.Location = New System.Drawing.Point(12, 238)
        Me.btn_rating.Name = "btn_rating"
        Me.btn_rating.Size = New System.Drawing.Size(75, 23)
        Me.btn_rating.TabIndex = 1
        Me.btn_rating.Text = "Rating"
        Me.btn_rating.UseVisualStyleBackColor = True
        '
        'btn_highest
        '
        Me.btn_highest.Location = New System.Drawing.Point(12, 190)
        Me.btn_highest.Name = "btn_highest"
        Me.btn_highest.Size = New System.Drawing.Size(75, 23)
        Me.btn_highest.TabIndex = 2
        Me.btn_highest.Text = "Highest"
        Me.btn_highest.UseVisualStyleBackColor = True
        '
        'btn_total
        '
        Me.btn_total.Location = New System.Drawing.Point(12, 100)
        Me.btn_total.Name = "btn_total"
        Me.btn_total.Size = New System.Drawing.Size(75, 23)
        Me.btn_total.TabIndex = 3
        Me.btn_total.Text = "Total"
        Me.btn_total.UseVisualStyleBackColor = True
        '
        'grd_destination
        '
        Me.grd_destination.FixedCols = 1
        Me.grd_destination.FixedRows = 1
        Me.grd_destination.Location = New System.Drawing.Point(132, 21)
        Me.grd_destination.Name = "grd_destination"
        Me.grd_destination.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_destination.Size = New System.Drawing.Size(445, 240)
        Me.grd_destination.TabIndex = 4
        '
        'btn_ratio
        '
        Me.btn_ratio.Location = New System.Drawing.Point(12, 144)
        Me.btn_ratio.Name = "btn_ratio"
        Me.btn_ratio.Size = New System.Drawing.Size(75, 23)
        Me.btn_ratio.TabIndex = 5
        Me.btn_ratio.Text = "Ratio"
        Me.btn_ratio.UseVisualStyleBackColor = True
        '
        'btn_setup
        '
        Me.btn_setup.Location = New System.Drawing.Point(12, 21)
        Me.btn_setup.Name = "btn_setup"
        Me.btn_setup.Size = New System.Drawing.Size(75, 23)
        Me.btn_setup.TabIndex = 6
        Me.btn_setup.Text = "Set up"
        Me.btn_setup.UseVisualStyleBackColor = True
        '
        'frm_bwdestination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_setup)
        Me.Controls.Add(Me.btn_ratio)
        Me.Controls.Add(Me.grd_destination)
        Me.Controls.Add(Me.btn_total)
        Me.Controls.Add(Me.btn_highest)
        Me.Controls.Add(Me.btn_rating)
        Me.Controls.Add(Me.btn_input)
        Me.Name = "frm_bwdestination"
        Me.Text = "BWDESTINATION"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_input As Button
    Friend WithEvents btn_rating As Button
    Friend WithEvents btn_highest As Button
    Friend WithEvents btn_total As Button
    Friend WithEvents grd_destination As UJGrid.UJGrid
    Friend WithEvents btn_ratio As Button
    Friend WithEvents btn_setup As Button
End Class
