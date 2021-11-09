<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStock))
        Me.user_btnCancel = New System.Windows.Forms.Button()
        Me.user_lblMaxRec = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.user_btnUpdate = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.user_lblOf = New System.Windows.Forms.Label()
        Me.user_lblNumRec = New System.Windows.Forms.Label()
        Me.user_lblRecords = New System.Windows.Forms.Label()
        Me.user_lblRefresh = New System.Windows.Forms.Label()
        Me.user_txtQuantity = New System.Windows.Forms.TextBox()
        Me.user_txtName = New System.Windows.Forms.TextBox()
        Me.user_txtID = New System.Windows.Forms.TextBox()
        Me.user_btnRefresh = New System.Windows.Forms.Button()
        Me.user_btnDelete = New System.Windows.Forms.Button()
        Me.user_btnEdit = New System.Windows.Forms.Button()
        Me.user_btnSave = New System.Windows.Forms.Button()
        Me.user_btnAddNew = New System.Windows.Forms.Button()
        Me.user_lblQuantity = New System.Windows.Forms.Label()
        Me.user_lblName = New System.Windows.Forms.Label()
        Me.user_lblID = New System.Windows.Forms.Label()
        Me.user_btnPrevious = New System.Windows.Forms.Button()
        Me.user_btnLast = New System.Windows.Forms.Button()
        Me.user_btnNext = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.user_btnFirst = New System.Windows.Forms.Button()
        Me.user_cboCategory = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.user_btnSearch = New System.Windows.Forms.Button()
        Me.user_lblCategory = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.user_btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'user_btnCancel
        '
        Me.user_btnCancel.BackColor = System.Drawing.Color.White
        Me.user_btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnCancel.Location = New System.Drawing.Point(298, 167)
        Me.user_btnCancel.Name = "user_btnCancel"
        Me.user_btnCancel.Size = New System.Drawing.Size(66, 55)
        Me.user_btnCancel.TabIndex = 21
        Me.user_btnCancel.Text = "Cancel"
        Me.user_btnCancel.UseVisualStyleBackColor = False
        '
        'user_lblMaxRec
        '
        Me.user_lblMaxRec.BackColor = System.Drawing.Color.Lavender
        Me.user_lblMaxRec.Location = New System.Drawing.Point(149, 194)
        Me.user_lblMaxRec.Name = "user_lblMaxRec"
        Me.user_lblMaxRec.Size = New System.Drawing.Size(24, 14)
        Me.user_lblMaxRec.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.user_btnCancel)
        Me.GroupBox1.Controls.Add(Me.user_lblMaxRec)
        Me.GroupBox1.Controls.Add(Me.user_btnUpdate)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.user_lblOf)
        Me.GroupBox1.Controls.Add(Me.user_lblNumRec)
        Me.GroupBox1.Controls.Add(Me.user_lblRecords)
        Me.GroupBox1.Controls.Add(Me.user_lblRefresh)
        Me.GroupBox1.Controls.Add(Me.user_txtQuantity)
        Me.GroupBox1.Controls.Add(Me.user_txtName)
        Me.GroupBox1.Controls.Add(Me.user_txtID)
        Me.GroupBox1.Controls.Add(Me.user_btnRefresh)
        Me.GroupBox1.Controls.Add(Me.user_btnDelete)
        Me.GroupBox1.Controls.Add(Me.user_btnEdit)
        Me.GroupBox1.Controls.Add(Me.user_btnSave)
        Me.GroupBox1.Controls.Add(Me.user_btnAddNew)
        Me.GroupBox1.Controls.Add(Me.user_lblQuantity)
        Me.GroupBox1.Controls.Add(Me.user_lblName)
        Me.GroupBox1.Controls.Add(Me.user_lblID)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 280)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Information"
        '
        'user_btnUpdate
        '
        Me.user_btnUpdate.BackColor = System.Drawing.Color.White
        Me.user_btnUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnUpdate.Location = New System.Drawing.Point(298, 97)
        Me.user_btnUpdate.Name = "user_btnUpdate"
        Me.user_btnUpdate.Size = New System.Drawing.Size(66, 65)
        Me.user_btnUpdate.TabIndex = 19
        Me.user_btnUpdate.Text = "Update Stock Details"
        Me.user_btnUpdate.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 211)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'user_lblOf
        '
        Me.user_lblOf.AutoSize = True
        Me.user_lblOf.Location = New System.Drawing.Point(127, 194)
        Me.user_lblOf.Name = "user_lblOf"
        Me.user_lblOf.Size = New System.Drawing.Size(18, 16)
        Me.user_lblOf.TabIndex = 15
        Me.user_lblOf.Text = "of"
        '
        'user_lblNumRec
        '
        Me.user_lblNumRec.AutoSize = True
        Me.user_lblNumRec.Location = New System.Drawing.Point(108, 194)
        Me.user_lblNumRec.Name = "user_lblNumRec"
        Me.user_lblNumRec.Size = New System.Drawing.Size(14, 16)
        Me.user_lblNumRec.TabIndex = 14
        Me.user_lblNumRec.Text = "1"
        '
        'user_lblRecords
        '
        Me.user_lblRecords.AutoSize = True
        Me.user_lblRecords.Location = New System.Drawing.Point(56, 194)
        Me.user_lblRecords.Name = "user_lblRecords"
        Me.user_lblRecords.Size = New System.Drawing.Size(54, 16)
        Me.user_lblRecords.TabIndex = 13
        Me.user_lblRecords.Text = "Records:"
        '
        'user_lblRefresh
        '
        Me.user_lblRefresh.AutoSize = True
        Me.user_lblRefresh.Location = New System.Drawing.Point(84, 162)
        Me.user_lblRefresh.Name = "user_lblRefresh"
        Me.user_lblRefresh.Size = New System.Drawing.Size(71, 16)
        Me.user_lblRefresh.TabIndex = 11
        Me.user_lblRefresh.Text = "Refreshing..."
        '
        'user_txtQuantity
        '
        Me.user_txtQuantity.Location = New System.Drawing.Point(81, 110)
        Me.user_txtQuantity.Name = "user_txtQuantity"
        Me.user_txtQuantity.Size = New System.Drawing.Size(119, 21)
        Me.user_txtQuantity.TabIndex = 11
        '
        'user_txtName
        '
        Me.user_txtName.Location = New System.Drawing.Point(81, 84)
        Me.user_txtName.Name = "user_txtName"
        Me.user_txtName.Size = New System.Drawing.Size(119, 21)
        Me.user_txtName.TabIndex = 10
        '
        'user_txtID
        '
        Me.user_txtID.Location = New System.Drawing.Point(81, 60)
        Me.user_txtID.Name = "user_txtID"
        Me.user_txtID.Size = New System.Drawing.Size(119, 21)
        Me.user_txtID.TabIndex = 9
        '
        'user_btnRefresh
        '
        Me.user_btnRefresh.BackColor = System.Drawing.Color.White
        Me.user_btnRefresh.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnRefresh.Location = New System.Drawing.Point(226, 225)
        Me.user_btnRefresh.Name = "user_btnRefresh"
        Me.user_btnRefresh.Size = New System.Drawing.Size(66, 49)
        Me.user_btnRefresh.TabIndex = 8
        Me.user_btnRefresh.Text = "Refresh Records"
        Me.user_btnRefresh.UseVisualStyleBackColor = False
        '
        'user_btnDelete
        '
        Me.user_btnDelete.BackColor = System.Drawing.Color.White
        Me.user_btnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnDelete.Location = New System.Drawing.Point(226, 97)
        Me.user_btnDelete.Name = "user_btnDelete"
        Me.user_btnDelete.Size = New System.Drawing.Size(66, 64)
        Me.user_btnDelete.TabIndex = 7
        Me.user_btnDelete.Text = "Delete"
        Me.user_btnDelete.UseVisualStyleBackColor = False
        '
        'user_btnEdit
        '
        Me.user_btnEdit.BackColor = System.Drawing.Color.White
        Me.user_btnEdit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnEdit.Location = New System.Drawing.Point(226, 167)
        Me.user_btnEdit.Name = "user_btnEdit"
        Me.user_btnEdit.Size = New System.Drawing.Size(66, 55)
        Me.user_btnEdit.TabIndex = 6
        Me.user_btnEdit.Text = "Edit"
        Me.user_btnEdit.UseVisualStyleBackColor = False
        '
        'user_btnSave
        '
        Me.user_btnSave.BackColor = System.Drawing.Color.White
        Me.user_btnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnSave.Location = New System.Drawing.Point(298, 26)
        Me.user_btnSave.Name = "user_btnSave"
        Me.user_btnSave.Size = New System.Drawing.Size(66, 66)
        Me.user_btnSave.TabIndex = 5
        Me.user_btnSave.Text = "Add New Stock"
        Me.user_btnSave.UseVisualStyleBackColor = False
        '
        'user_btnAddNew
        '
        Me.user_btnAddNew.BackColor = System.Drawing.Color.White
        Me.user_btnAddNew.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnAddNew.Location = New System.Drawing.Point(226, 26)
        Me.user_btnAddNew.Name = "user_btnAddNew"
        Me.user_btnAddNew.Size = New System.Drawing.Size(66, 65)
        Me.user_btnAddNew.TabIndex = 4
        Me.user_btnAddNew.Text = "Clear"
        Me.user_btnAddNew.UseVisualStyleBackColor = False
        '
        'user_lblQuantity
        '
        Me.user_lblQuantity.AutoSize = True
        Me.user_lblQuantity.Location = New System.Drawing.Point(14, 111)
        Me.user_lblQuantity.Name = "user_lblQuantity"
        Me.user_lblQuantity.Size = New System.Drawing.Size(59, 16)
        Me.user_lblQuantity.TabIndex = 2
        Me.user_lblQuantity.Text = "Quantity:"
        '
        'user_lblName
        '
        Me.user_lblName.AutoSize = True
        Me.user_lblName.Location = New System.Drawing.Point(25, 86)
        Me.user_lblName.Name = "user_lblName"
        Me.user_lblName.Size = New System.Drawing.Size(44, 16)
        Me.user_lblName.TabIndex = 1
        Me.user_lblName.Text = "Name:"
        '
        'user_lblID
        '
        Me.user_lblID.AutoSize = True
        Me.user_lblID.Location = New System.Drawing.Point(43, 60)
        Me.user_lblID.Name = "user_lblID"
        Me.user_lblID.Size = New System.Drawing.Size(22, 16)
        Me.user_lblID.TabIndex = 0
        Me.user_lblID.Text = "ID:"
        '
        'user_btnPrevious
        '
        Me.user_btnPrevious.BackColor = System.Drawing.Color.White
        Me.user_btnPrevious.Location = New System.Drawing.Point(125, 19)
        Me.user_btnPrevious.Name = "user_btnPrevious"
        Me.user_btnPrevious.Size = New System.Drawing.Size(40, 30)
        Me.user_btnPrevious.TabIndex = 11
        Me.user_btnPrevious.Text = "<"
        Me.user_btnPrevious.UseVisualStyleBackColor = False
        '
        'user_btnLast
        '
        Me.user_btnLast.BackColor = System.Drawing.Color.White
        Me.user_btnLast.Location = New System.Drawing.Point(217, 19)
        Me.user_btnLast.Name = "user_btnLast"
        Me.user_btnLast.Size = New System.Drawing.Size(40, 30)
        Me.user_btnLast.TabIndex = 13
        Me.user_btnLast.Text = ">|"
        Me.user_btnLast.UseVisualStyleBackColor = False
        '
        'user_btnNext
        '
        Me.user_btnNext.BackColor = System.Drawing.Color.White
        Me.user_btnNext.Location = New System.Drawing.Point(171, 19)
        Me.user_btnNext.Name = "user_btnNext"
        Me.user_btnNext.Size = New System.Drawing.Size(40, 30)
        Me.user_btnNext.TabIndex = 12
        Me.user_btnNext.Text = ">"
        Me.user_btnNext.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox2.Controls.Add(Me.user_btnLast)
        Me.GroupBox2.Controls.Add(Me.user_btnNext)
        Me.GroupBox2.Controls.Add(Me.user_btnPrevious)
        Me.GroupBox2.Controls.Add(Me.user_btnFirst)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(61, 402)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 59)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Navigation"
        '
        'user_btnFirst
        '
        Me.user_btnFirst.BackColor = System.Drawing.Color.White
        Me.user_btnFirst.Location = New System.Drawing.Point(79, 19)
        Me.user_btnFirst.Name = "user_btnFirst"
        Me.user_btnFirst.Size = New System.Drawing.Size(40, 30)
        Me.user_btnFirst.TabIndex = 10
        Me.user_btnFirst.Text = "|<"
        Me.user_btnFirst.UseVisualStyleBackColor = False
        '
        'user_cboCategory
        '
        Me.user_cboCategory.FormattingEnabled = True
        Me.user_cboCategory.Items.AddRange(New Object() {"All", "Ingredient", "Flavour", "Toppings", "Ice Cream Base", "Handpacked"})
        Me.user_cboCategory.Location = New System.Drawing.Point(64, 76)
        Me.user_cboCategory.Name = "user_cboCategory"
        Me.user_cboCategory.Size = New System.Drawing.Size(131, 24)
        Me.user_cboCategory.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox3.Controls.Add(Me.user_cboCategory)
        Me.GroupBox3.Controls.Add(Me.user_btnSearch)
        Me.GroupBox3.Controls.Add(Me.user_lblCategory)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(414, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 280)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'user_btnSearch
        '
        Me.user_btnSearch.BackColor = System.Drawing.Color.White
        Me.user_btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnSearch.Location = New System.Drawing.Point(109, 128)
        Me.user_btnSearch.Name = "user_btnSearch"
        Me.user_btnSearch.Size = New System.Drawing.Size(74, 58)
        Me.user_btnSearch.TabIndex = 9
        Me.user_btnSearch.Text = "Search"
        Me.user_btnSearch.UseVisualStyleBackColor = False
        '
        'user_lblCategory
        '
        Me.user_lblCategory.AutoSize = True
        Me.user_lblCategory.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.user_lblCategory.Location = New System.Drawing.Point(6, 79)
        Me.user_lblCategory.Name = "user_lblCategory"
        Me.user_lblCategory.Size = New System.Drawing.Size(62, 16)
        Me.user_lblCategory.TabIndex = 9
        Me.user_lblCategory.Text = "Category:"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(214, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 38)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Manage Stocks"
        '
        'user_btnClose
        '
        Me.user_btnClose.BackColor = System.Drawing.Color.White
        Me.user_btnClose.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.user_btnClose.Location = New System.Drawing.Point(500, 402)
        Me.user_btnClose.Name = "user_btnClose"
        Me.user_btnClose.Size = New System.Drawing.Size(66, 59)
        Me.user_btnClose.TabIndex = 56
        Me.user_btnClose.Text = "Close"
        Me.user_btnClose.UseVisualStyleBackColor = False
        '
        'ManageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BingsuSystem.My.Resources.Resources.WhatsApp_Image_2021_11_03_at_9_50_20_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user_btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageStock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user_btnCancel As System.Windows.Forms.Button
    Friend WithEvents user_lblMaxRec As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents user_btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents user_lblOf As System.Windows.Forms.Label
    Friend WithEvents user_lblNumRec As System.Windows.Forms.Label
    Friend WithEvents user_lblRecords As System.Windows.Forms.Label
    Friend WithEvents user_lblRefresh As System.Windows.Forms.Label
    Friend WithEvents user_txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents user_txtName As System.Windows.Forms.TextBox
    Friend WithEvents user_txtID As System.Windows.Forms.TextBox
    Friend WithEvents user_btnRefresh As System.Windows.Forms.Button
    Friend WithEvents user_btnDelete As System.Windows.Forms.Button
    Friend WithEvents user_btnEdit As System.Windows.Forms.Button
    Friend WithEvents user_btnSave As System.Windows.Forms.Button
    Friend WithEvents user_btnAddNew As System.Windows.Forms.Button
    Friend WithEvents user_lblQuantity As System.Windows.Forms.Label
    Friend WithEvents user_lblName As System.Windows.Forms.Label
    Friend WithEvents user_lblID As System.Windows.Forms.Label
    Friend WithEvents user_btnPrevious As System.Windows.Forms.Button
    Friend WithEvents user_btnLast As System.Windows.Forms.Button
    Friend WithEvents user_btnNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents user_btnFirst As System.Windows.Forms.Button
    Friend WithEvents user_cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents user_btnSearch As System.Windows.Forms.Button
    Friend WithEvents user_lblCategory As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents user_btnClose As System.Windows.Forms.Button

End Class
