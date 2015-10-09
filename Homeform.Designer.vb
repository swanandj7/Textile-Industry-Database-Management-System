<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverallTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addnewpurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pendingpurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.Completedpurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewquality = New System.Windows.Forms.ToolStripMenuItem()
        Me.qualitylist = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pendingorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.Completedorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addnewbill = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewpayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransportAgenciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewtransport = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgencyListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewsupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewcustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerLIstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.opButton = New System.Windows.Forms.Button()
        Me.ocButton = New System.Windows.Forms.Button()
        Me.oqButton = New System.Windows.Forms.Button()
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drag = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.StockToolStripMenuItem, Me.ProductionToolStripMenuItem, Me.ToolStripMenuItem1, Me.OrderToolStripMenuItem, Me.BillToolStripMenuItem, Me.ToolStripMenuItem2, Me.TransportAgenciesToolStripMenuItem, Me.SuppliersToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverallTransactionsToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ExitToolStripMenuItem})
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OverallTransactionsToolStripMenuItem
        '
        Me.OverallTransactionsToolStripMenuItem.Name = "OverallTransactionsToolStripMenuItem"
        Me.OverallTransactionsToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.OverallTransactionsToolStripMenuItem.Text = "Overall Transactions"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(221, 26)
        Me.ToolStripMenuItem3.Text = "Change User Name"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(221, 26)
        Me.ToolStripMenuItem4.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewStockToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(60, 25)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ViewStockToolStripMenuItem
        '
        Me.ViewStockToolStripMenuItem.Name = "ViewStockToolStripMenuItem"
        Me.ViewStockToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ViewStockToolStripMenuItem.Text = "View Stock"
        '
        'ProductionToolStripMenuItem
        '
        Me.ProductionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addnewpurchase, Me.VToolStripMenuItem})
        Me.ProductionToolStripMenuItem.Name = "ProductionToolStripMenuItem"
        Me.ProductionToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.ProductionToolStripMenuItem.Text = "Purchase"
        '
        'addnewpurchase
        '
        Me.addnewpurchase.Name = "addnewpurchase"
        Me.addnewpurchase.Size = New System.Drawing.Size(179, 26)
        Me.addnewpurchase.Text = "New Purchase"
        '
        'VToolStripMenuItem
        '
        Me.VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pendingpurchase, Me.Completedpurchase})
        Me.VToolStripMenuItem.Name = "VToolStripMenuItem"
        Me.VToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.VToolStripMenuItem.Text = "Purchase List"
        '
        'Pendingpurchase
        '
        Me.Pendingpurchase.Name = "Pendingpurchase"
        Me.Pendingpurchase.Size = New System.Drawing.Size(156, 26)
        Me.Pendingpurchase.Text = "Pending"
        '
        'Completedpurchase
        '
        Me.Completedpurchase.Name = "Completedpurchase"
        Me.Completedpurchase.Size = New System.Drawing.Size(156, 26)
        Me.Completedpurchase.Text = "Completed"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewquality, Me.qualitylist})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(72, 25)
        Me.ToolStripMenuItem1.Text = "Quality"
        '
        'AddNewquality
        '
        Me.AddNewquality.Name = "AddNewquality"
        Me.AddNewquality.Size = New System.Drawing.Size(158, 26)
        Me.AddNewquality.Text = "Add New"
        '
        'qualitylist
        '
        Me.qualitylist.Name = "qualitylist"
        Me.qualitylist.Size = New System.Drawing.Size(158, 26)
        Me.qualitylist.Text = "Quality List"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem, Me.ViewListsToolStripMenuItem2})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.NewOrderToolStripMenuItem.Text = "New Order"
        '
        'ViewListsToolStripMenuItem2
        '
        Me.ViewListsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pendingorder, Me.Completedorder})
        Me.ViewListsToolStripMenuItem2.Name = "ViewListsToolStripMenuItem2"
        Me.ViewListsToolStripMenuItem2.Size = New System.Drawing.Size(157, 26)
        Me.ViewListsToolStripMenuItem2.Text = "Order Lists"
        '
        'Pendingorder
        '
        Me.Pendingorder.Name = "Pendingorder"
        Me.Pendingorder.Size = New System.Drawing.Size(156, 26)
        Me.Pendingorder.Text = "Pending"
        '
        'Completedorder
        '
        Me.Completedorder.Name = "Completedorder"
        Me.Completedorder.Size = New System.Drawing.Size(156, 26)
        Me.Completedorder.Text = "Completed"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addnewbill, Me.BillListsToolStripMenuItem})
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(43, 25)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'addnewbill
        '
        Me.addnewbill.Name = "addnewbill"
        Me.addnewbill.Size = New System.Drawing.Size(144, 26)
        Me.addnewbill.Text = "Add New"
        '
        'BillListsToolStripMenuItem
        '
        Me.BillListsToolStripMenuItem.Name = "BillListsToolStripMenuItem"
        Me.BillListsToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.BillListsToolStripMenuItem.Text = "Bill List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewpayment, Me.PaymentListToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(83, 25)
        Me.ToolStripMenuItem2.Text = "Payment"
        '
        'AddNewpayment
        '
        Me.AddNewpayment.Name = "AddNewpayment"
        Me.AddNewpayment.Size = New System.Drawing.Size(169, 26)
        Me.AddNewpayment.Text = "Add New"
        '
        'PaymentListToolStripMenuItem
        '
        Me.PaymentListToolStripMenuItem.Name = "PaymentListToolStripMenuItem"
        Me.PaymentListToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.PaymentListToolStripMenuItem.Text = "Payment List"
        '
        'TransportAgenciesToolStripMenuItem
        '
        Me.TransportAgenciesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewtransport, Me.AgencyListsToolStripMenuItem})
        Me.TransportAgenciesToolStripMenuItem.Name = "TransportAgenciesToolStripMenuItem"
        Me.TransportAgenciesToolStripMenuItem.Size = New System.Drawing.Size(155, 25)
        Me.TransportAgenciesToolStripMenuItem.Text = "Transport Agencies"
        '
        'AddNewtransport
        '
        Me.AddNewtransport.Name = "AddNewtransport"
        Me.AddNewtransport.Size = New System.Drawing.Size(159, 26)
        Me.AddNewtransport.Text = "Add New"
        '
        'AgencyListsToolStripMenuItem
        '
        Me.AgencyListsToolStripMenuItem.Name = "AgencyListsToolStripMenuItem"
        Me.AgencyListsToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.AgencyListsToolStripMenuItem.Text = "Agency List"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewsupplier, Me.SupplierListToolStripMenuItem})
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(87, 25)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'AddNewsupplier
        '
        Me.AddNewsupplier.Name = "AddNewsupplier"
        Me.AddNewsupplier.Size = New System.Drawing.Size(166, 26)
        Me.AddNewsupplier.Text = "Add New"
        '
        'SupplierListToolStripMenuItem
        '
        Me.SupplierListToolStripMenuItem.Name = "SupplierListToolStripMenuItem"
        Me.SupplierListToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SupplierListToolStripMenuItem.Text = "Supplier List"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewcustomer, Me.CustomerLIstToolStripMenuItem, Me.TransactionsToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'AddNewcustomer
        '
        Me.AddNewcustomer.Name = "AddNewcustomer"
        Me.AddNewcustomer.Size = New System.Drawing.Size(176, 26)
        Me.AddNewcustomer.Text = "Add New"
        '
        'CustomerLIstToolStripMenuItem
        '
        Me.CustomerLIstToolStripMenuItem.Name = "CustomerLIstToolStripMenuItem"
        Me.CustomerLIstToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.CustomerLIstToolStripMenuItem.Text = "Customer List"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'IndividualToolStripMenuItem
        '
        Me.IndividualToolStripMenuItem.Name = "IndividualToolStripMenuItem"
        Me.IndividualToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.IndividualToolStripMenuItem.Text = "Individual"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "images2.jpg")
        Me.ImageList1.Images.SetKeyName(1, "indus.jpg")
        Me.ImageList1.Images.SetKeyName(2, "pakistani_industry11 (1).jpg")
        '
        'opButton
        '
        Me.opButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opButton.Location = New System.Drawing.Point(19, 614)
        Me.opButton.Name = "opButton"
        Me.opButton.Size = New System.Drawing.Size(37, 40)
        Me.opButton.TabIndex = 134
        Me.opButton.Text = ">"
        Me.ToolTip1.SetToolTip(Me.opButton, "Suppliers Crossed Delivery limit")
        Me.opButton.UseVisualStyleBackColor = True
        Me.opButton.Visible = False
        '
        'ocButton
        '
        Me.ocButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ocButton.Location = New System.Drawing.Point(19, 430)
        Me.ocButton.Name = "ocButton"
        Me.ocButton.Size = New System.Drawing.Size(37, 40)
        Me.ocButton.TabIndex = 133
        Me.ocButton.Text = ">"
        Me.ToolTip1.SetToolTip(Me.ocButton, "Customers havent Paid since Last 3 Months")
        Me.ocButton.UseVisualStyleBackColor = True
        Me.ocButton.Visible = False
        '
        'oqButton
        '
        Me.oqButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oqButton.Location = New System.Drawing.Point(19, 250)
        Me.oqButton.Name = "oqButton"
        Me.oqButton.Size = New System.Drawing.Size(37, 40)
        Me.oqButton.TabIndex = 132
        Me.oqButton.Text = ">"
        Me.ToolTip1.SetToolTip(Me.oqButton, "Qualities Below Limit")
        Me.oqButton.UseVisualStyleBackColor = True
        Me.oqButton.Visible = False
        '
        'Timer9
        '
        Me.Timer9.Interval = 2000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 614)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 60)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "           Proprietor : Gourishankar Khandelwal (9422046995)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12/141,Bunglow Ro" & _
            "ad,Congress Committee,Ichalkaranji-416115"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Notifications"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(550, 284)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(386, 277)
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = "331,65"
        Me.PictureBox1.Location = New System.Drawing.Point(426, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 90)
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Control
        Me.MonthCalendar1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MonthCalendar1.Location = New System.Drawing.Point(1124, 132)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 128
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1092, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 40)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1314, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 40)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.BackColor = System.Drawing.SystemColors.Control
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(1182, 76)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(57, 20)
        Me.login.TabIndex = 125
        Me.login.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1120, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "User"
        '
        'drag
        '
        Me.drag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.drag.BackColor = System.Drawing.SystemColors.Control
        Me.drag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drag.Location = New System.Drawing.Point(1368, 373)
        Me.drag.Name = "drag"
        Me.drag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.drag.Size = New System.Drawing.Size(488, 166)
        Me.drag.TabIndex = 142
        Me.drag.Text = "Developed By" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Abhishek Khandelwal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Swanand Joshi"
        '
        'homeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.drag)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.opButton)
        Me.Controls.Add(Me.ocButton)
        Me.Controls.Add(Me.oqButton)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "homeform"
        Me.Text = "Home Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addnewpurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pendingpurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Completedpurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewquality As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents qualitylist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewListsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pendingorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Completedorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addnewbill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillListsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewpayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransportAgenciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewtransport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgencyListsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewsupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewcustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerLIstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer9 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents opButton As System.Windows.Forms.Button
    Friend WithEvents ocButton As System.Windows.Forms.Button
    Friend WithEvents oqButton As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents login As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents drag As System.Windows.Forms.Label
    Friend WithEvents OverallTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
