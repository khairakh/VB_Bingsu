<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.user_cboCategory = New System.Windows.Forms.ComboBox()
        Me.user_btnSearch = New System.Windows.Forms.Button()
        Me.user_lblCategory = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 157)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(564, 344)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(229, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 38)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "List of Stocks"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox3.Controls.Add(Me.user_cboCategory)
        Me.GroupBox3.Controls.Add(Me.user_btnSearch)
        Me.GroupBox3.Controls.Add(Me.user_lblCategory)
        Me.GroupBox3.Location = New System.Drawing.Point(189, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 59)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'user_cboCategory
        '
        Me.user_cboCategory.FormattingEnabled = True
        Me.user_cboCategory.Items.AddRange(New Object() {"All", "Ingredient", "Flavour", "Toppings", "Ice Cream Base", "Handpacked"})
        Me.user_cboCategory.Location = New System.Drawing.Point(69, 26)
        Me.user_cboCategory.Name = "user_cboCategory"
        Me.user_cboCategory.Size = New System.Drawing.Size(131, 21)
        Me.user_cboCategory.TabIndex = 10
        '
        'user_btnSearch
        '
        Me.user_btnSearch.BackColor = System.Drawing.Color.White
        Me.user_btnSearch.Location = New System.Drawing.Point(228, 19)
        Me.user_btnSearch.Name = "user_btnSearch"
        Me.user_btnSearch.Size = New System.Drawing.Size(74, 23)
        Me.user_btnSearch.TabIndex = 9
        Me.user_btnSearch.Text = "Search"
        Me.user_btnSearch.UseVisualStyleBackColor = False
        '
        'user_lblCategory
        '
        Me.user_lblCategory.AutoSize = True
        Me.user_lblCategory.Location = New System.Drawing.Point(10, 29)
        Me.user_lblCategory.Name = "user_lblCategory"
        Me.user_lblCategory.Size = New System.Drawing.Size(52, 13)
        Me.user_lblCategory.TabIndex = 9
        Me.user_lblCategory.Text = "Category:"
        '
        'StockList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BingsuSystem.My.Resources.Resources.WhatsApp_Image_2021_11_03_at_9_50_20_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 542)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "StockList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents user_cboCategory As ComboBox
    Friend WithEvents user_btnSearch As Button
    Friend WithEvents user_lblCategory As Label
End Class
