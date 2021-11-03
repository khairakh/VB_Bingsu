<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.user_btnAbout = New System.Windows.Forms.Button()
        Me.manageStockBtn = New System.Windows.Forms.Button()
        Me.displayStockListBtn = New System.Windows.Forms.Button()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'user_btnAbout
        '
        Me.user_btnAbout.BackColor = System.Drawing.Color.Lavender
        Me.user_btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.user_btnAbout.Location = New System.Drawing.Point(339, 174)
        Me.user_btnAbout.Name = "user_btnAbout"
        Me.user_btnAbout.Size = New System.Drawing.Size(99, 42)
        Me.user_btnAbout.TabIndex = 58
        Me.user_btnAbout.Text = "About Us"
        Me.user_btnAbout.UseVisualStyleBackColor = False
        '
        'manageStockBtn
        '
        Me.manageStockBtn.BackColor = System.Drawing.Color.Lavender
        Me.manageStockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.manageStockBtn.Location = New System.Drawing.Point(339, 97)
        Me.manageStockBtn.Name = "manageStockBtn"
        Me.manageStockBtn.Size = New System.Drawing.Size(99, 42)
        Me.manageStockBtn.TabIndex = 59
        Me.manageStockBtn.Text = "Manage Stock"
        Me.manageStockBtn.UseVisualStyleBackColor = False
        '
        'displayStockListBtn
        '
        Me.displayStockListBtn.BackColor = System.Drawing.Color.Lavender
        Me.displayStockListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.displayStockListBtn.Location = New System.Drawing.Point(475, 97)
        Me.displayStockListBtn.Name = "displayStockListBtn"
        Me.displayStockListBtn.Size = New System.Drawing.Size(99, 42)
        Me.displayStockListBtn.TabIndex = 60
        Me.displayStockListBtn.Text = "Display Stock List"
        Me.displayStockListBtn.UseVisualStyleBackColor = False
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.Lavender
        Me.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.logoutBtn.Location = New System.Drawing.Point(475, 174)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(99, 42)
        Me.logoutBtn.TabIndex = 61
        Me.logoutBtn.Text = "Logout"
        Me.logoutBtn.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BingsuSystem.My.Resources.Resources.WhatsApp_Image_2021_11_03_at_9_50_19_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(621, 335)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.displayStockListBtn)
        Me.Controls.Add(Me.manageStockBtn)
        Me.Controls.Add(Me.user_btnAbout)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents user_btnAbout As Button
    Friend WithEvents manageStockBtn As Button
    Friend WithEvents displayStockListBtn As Button
    Friend WithEvents logoutBtn As Button
End Class
