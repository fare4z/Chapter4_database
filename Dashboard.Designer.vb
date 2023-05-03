<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyDBDataSet1 = New Chapter4_database.MyDBDataSet1()
        Me.MyDBDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_loginTableAdapter = New Chapter4_database.MyDBDataSet1TableAdapters.tbl_loginTableAdapter()
        Me.TblloginBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.MyDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblloginBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of User"
        '
        'MyDBDataSet1
        '
        Me.MyDBDataSet1.DataSetName = "MyDBDataSet1"
        Me.MyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyDBDataSet1BindingSource
        '
        Me.MyDBDataSet1BindingSource.DataSource = Me.MyDBDataSet1
        Me.MyDBDataSet1BindingSource.Position = 0
        '
        'TblloginBindingSource
        '
        Me.TblloginBindingSource.DataMember = "tbl_login"
        Me.TblloginBindingSource.DataSource = Me.MyDBDataSet1BindingSource
        '
        'Tbl_loginTableAdapter
        '
        Me.Tbl_loginTableAdapter.ClearBeforeFill = True
        '
        'TblloginBindingSource1
        '
        Me.TblloginBindingSource1.DataMember = "tbl_login"
        Me.TblloginBindingSource1.DataSource = Me.MyDBDataSet1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 192)
        Me.DataGridView1.TabIndex = 2
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(625, 69)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 3
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID : "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(162, 322)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(293, 20)
        Me.txtID.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(162, 348)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(293, 20)
        Me.txtUsername.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Full Name : "
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(162, 374)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(293, 20)
        Me.txtPassword.TabIndex = 11
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(162, 400)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(293, 20)
        Me.txtFullname.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(482, 392)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(87, 28)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Update"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(575, 392)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 28)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.MyDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblloginBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MyDBDataSet1BindingSource As BindingSource
    Friend WithEvents MyDBDataSet1 As MyDBDataSet1
    Friend WithEvents TblloginBindingSource As BindingSource
    Friend WithEvents Tbl_loginTableAdapter As MyDBDataSet1TableAdapters.tbl_loginTableAdapter
    Friend WithEvents TblloginBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnDelete As Button
End Class
