﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pbCover = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.plMainTitle = New System.Windows.Forms.Panel()
        Me.ilFlechas = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tblProdSmall = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblLorem = New System.Windows.Forms.Label()
        Me.lblTallaT = New System.Windows.Forms.Label()
        Me.tblTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.plLine2 = New System.Windows.Forms.Panel()
        Me.tblMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.tblNavigation = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.plLine1 = New System.Windows.Forms.Panel()
        Me.tblCopyright = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.TblTallaLista = New System.Windows.Forms.TableLayoutPanel()
        Me.tblDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTalla = New System.Windows.Forms.TableLayoutPanel()
        Me.tblCantidad = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCantidadT = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.tblTotal = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalT = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.plProductoM = New System.Windows.Forms.Panel()
        Me.BTN_HOMBRES = New System.Windows.Forms.Button()
        Me.BTN_MUJERES = New System.Windows.Forms.Button()
        Me.BTN_CALZADO = New System.Windows.Forms.Button()
        Me.BTN_ACCESORIOS = New System.Windows.Forms.Button()
        Me.BTN_S = New System.Windows.Forms.Button()
        Me.BTN_M = New System.Windows.Forms.Button()
        Me.BTN_L = New System.Windows.Forms.Button()
        Me.BTN_XL = New System.Windows.Forms.Button()
        Me.BTN_XS = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plMainTitle.SuspendLayout()
        Me.tblProdSmall.SuspendLayout()
        Me.tblTitle.SuspendLayout()
        Me.tblMenu.SuspendLayout()
        Me.tblNavigation.SuspendLayout()
        Me.tblCopyright.SuspendLayout()
        Me.TblTallaLista.SuspendLayout()
        Me.tblDetails.SuspendLayout()
        Me.tblTalla.SuspendLayout()
        Me.tblCantidad.SuspendLayout()
        Me.tblTotal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCover
        '
        Me.pbCover.Image = CType(resources.GetObject("pbCover.Image"), System.Drawing.Image)
        Me.pbCover.Location = New System.Drawing.Point(0, 0)
        Me.pbCover.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCover.Name = "pbCover"
        Me.pbCover.Size = New System.Drawing.Size(720, 215)
        Me.pbCover.TabIndex = 0
        Me.pbCover.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(541, 16)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(152, 80)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'plMainTitle
        '
        Me.plMainTitle.Controls.Add(Me.pbLogo)
        Me.plMainTitle.Controls.Add(Me.pbCover)
        Me.plMainTitle.Location = New System.Drawing.Point(0, 0)
        Me.plMainTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.plMainTitle.Name = "plMainTitle"
        Me.plMainTitle.Size = New System.Drawing.Size(721, 215)
        Me.plMainTitle.TabIndex = 2
        '
        'ilFlechas
        '
        Me.ilFlechas.ImageStream = CType(resources.GetObject("ilFlechas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilFlechas.TransparentColor = System.Drawing.Color.Transparent
        Me.ilFlechas.Images.SetKeyName(0, "arrow-left.png")
        Me.ilFlechas.Images.SetKeyName(1, "arrow-right.png")
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(100, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(489, 25)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Lorem Ipsum"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblProdSmall
        '
        Me.tblProdSmall.ColumnCount = 1
        Me.tblProdSmall.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblProdSmall.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblProdSmall.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tblProdSmall.Controls.Add(Me.PictureBox2, 0, 1)
        Me.tblProdSmall.Controls.Add(Me.PictureBox3, 0, 2)
        Me.tblProdSmall.Controls.Add(Me.PictureBox4, 0, 3)
        Me.tblProdSmall.Location = New System.Drawing.Point(13, 310)
        Me.tblProdSmall.Name = "tblProdSmall"
        Me.tblProdSmall.RowCount = 4
        Me.tblProdSmall.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblProdSmall.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblProdSmall.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblProdSmall.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblProdSmall.Size = New System.Drawing.Size(99, 503)
        Me.tblProdSmall.TabIndex = 4
        '
        'lblPrecio
        '
        Me.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Black
        Me.lblPrecio.Location = New System.Drawing.Point(68, 9)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(64, 51)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "$0"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLorem
        '
        Me.lblLorem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLorem.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLorem.ForeColor = System.Drawing.Color.DimGray
        Me.lblLorem.Location = New System.Drawing.Point(3, 70)
        Me.lblLorem.Name = "lblLorem"
        Me.lblLorem.Size = New System.Drawing.Size(194, 77)
        Me.lblLorem.TabIndex = 4
        Me.lblLorem.Text = "Lorem ipsum dolor sit amet, eum aeque nonumy constituam ut, ei appetere convenire" &
    " ius, et eos iriure luptatum adipiscing."
        Me.lblLorem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTallaT
        '
        Me.lblTallaT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTallaT.AutoSize = True
        Me.lblTallaT.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaT.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTallaT.Location = New System.Drawing.Point(78, 4)
        Me.lblTallaT.Name = "lblTallaT"
        Me.lblTallaT.Size = New System.Drawing.Size(37, 13)
        Me.lblTallaT.TabIndex = 4
        Me.lblTallaT.Text = "TALLA"
        '
        'tblTitle
        '
        Me.tblTitle.ColumnCount = 1
        Me.tblTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTitle.Controls.Add(Me.plLine2, 0, 3)
        Me.tblTitle.Controls.Add(Me.tblMenu, 0, 0)
        Me.tblTitle.Controls.Add(Me.tblNavigation, 0, 2)
        Me.tblTitle.Controls.Add(Me.plLine1, 0, 1)
        Me.tblTitle.Location = New System.Drawing.Point(12, 220)
        Me.tblTitle.Name = "tblTitle"
        Me.tblTitle.RowCount = 4
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tblTitle.Size = New System.Drawing.Size(697, 81)
        Me.tblTitle.TabIndex = 7
        '
        'plLine2
        '
        Me.plLine2.BackColor = System.Drawing.Color.SteelBlue
        Me.plLine2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plLine2.Location = New System.Drawing.Point(0, 80)
        Me.plLine2.Margin = New System.Windows.Forms.Padding(0)
        Me.plLine2.Name = "plLine2"
        Me.plLine2.Size = New System.Drawing.Size(697, 1)
        Me.plLine2.TabIndex = 3
        '
        'tblMenu
        '
        Me.tblMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblMenu.ColumnCount = 4
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.Controls.Add(Me.BTN_HOMBRES, 0, 0)
        Me.tblMenu.Controls.Add(Me.BTN_MUJERES, 1, 0)
        Me.tblMenu.Controls.Add(Me.BTN_CALZADO, 2, 0)
        Me.tblMenu.Controls.Add(Me.BTN_ACCESORIOS, 3, 0)
        Me.tblMenu.Location = New System.Drawing.Point(149, 3)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.RowCount = 1
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tblMenu.Size = New System.Drawing.Size(399, 33)
        Me.tblMenu.TabIndex = 0
        '
        'tblNavigation
        '
        Me.tblNavigation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblNavigation.BackColor = System.Drawing.Color.White
        Me.tblNavigation.ColumnCount = 3
        Me.tblNavigation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15921!))
        Me.tblNavigation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.67904!))
        Me.tblNavigation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16175!))
        Me.tblNavigation.Controls.Add(Me.btnRight, 2, 0)
        Me.tblNavigation.Controls.Add(Me.btnLeft, 0, 0)
        Me.tblNavigation.Controls.Add(Me.lblTitulo, 1, 0)
        Me.tblNavigation.Location = New System.Drawing.Point(3, 44)
        Me.tblNavigation.Name = "tblNavigation"
        Me.tblNavigation.RowCount = 1
        Me.tblNavigation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblNavigation.Size = New System.Drawing.Size(691, 33)
        Me.tblNavigation.TabIndex = 1
        '
        'btnRight
        '
        Me.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.ImageKey = "arrow-right.png"
        Me.btnRight.ImageList = Me.ilFlechas
        Me.btnRight.Location = New System.Drawing.Point(669, 5)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(19, 23)
        Me.btnRight.TabIndex = 14
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.ImageKey = "arrow-left.png"
        Me.btnLeft.ImageList = Me.ilFlechas
        Me.btnLeft.Location = New System.Drawing.Point(3, 5)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(18, 23)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'plLine1
        '
        Me.plLine1.BackColor = System.Drawing.Color.SteelBlue
        Me.plLine1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plLine1.Location = New System.Drawing.Point(0, 40)
        Me.plLine1.Margin = New System.Windows.Forms.Padding(0)
        Me.plLine1.Name = "plLine1"
        Me.plLine1.Size = New System.Drawing.Size(697, 1)
        Me.plLine1.TabIndex = 2
        '
        'tblCopyright
        '
        Me.tblCopyright.ColumnCount = 1
        Me.tblCopyright.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCopyright.Controls.Add(Me.lblCopyright, 0, 0)
        Me.tblCopyright.Location = New System.Drawing.Point(12, 819)
        Me.tblCopyright.Name = "tblCopyright"
        Me.tblCopyright.RowCount = 1
        Me.tblCopyright.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCopyright.Size = New System.Drawing.Size(694, 31)
        Me.tblCopyright.TabIndex = 10
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.DimGray
        Me.lblCopyright.Location = New System.Drawing.Point(172, 9)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(349, 13)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Copyright © 2016 Tommy Hilfiger Licensing, LLC. All rights reserved"
        '
        'TblTallaLista
        '
        Me.TblTallaLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TblTallaLista.ColumnCount = 5
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.Controls.Add(Me.BTN_XS, 0, 0)
        Me.TblTallaLista.Controls.Add(Me.BTN_S, 1, 0)
        Me.TblTallaLista.Controls.Add(Me.BTN_M, 2, 0)
        Me.TblTallaLista.Controls.Add(Me.BTN_L, 3, 0)
        Me.TblTallaLista.Controls.Add(Me.BTN_XL, 4, 0)
        Me.TblTallaLista.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblTallaLista.Location = New System.Drawing.Point(30, 26)
        Me.TblTallaLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.TblTallaLista.Name = "TblTallaLista"
        Me.TblTallaLista.RowCount = 1
        Me.TblTallaLista.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblTallaLista.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TblTallaLista.Size = New System.Drawing.Size(134, 20)
        Me.TblTallaLista.TabIndex = 11
        '
        'tblDetails
        '
        Me.tblDetails.ColumnCount = 1
        Me.tblDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblDetails.Controls.Add(Me.lblPrecio, 0, 0)
        Me.tblDetails.Controls.Add(Me.lblLorem, 0, 1)
        Me.tblDetails.Controls.Add(Me.tblTalla, 0, 2)
        Me.tblDetails.Controls.Add(Me.tblCantidad, 0, 3)
        Me.tblDetails.Controls.Add(Me.btnAgregar, 0, 4)
        Me.tblDetails.Controls.Add(Me.btnComprar, 0, 5)
        Me.tblDetails.Controls.Add(Me.tblTotal, 0, 6)
        Me.tblDetails.Location = New System.Drawing.Point(505, 310)
        Me.tblDetails.Name = "tblDetails"
        Me.tblDetails.RowCount = 7
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.tblDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblDetails.Size = New System.Drawing.Size(200, 503)
        Me.tblDetails.TabIndex = 12
        '
        'tblTalla
        '
        Me.tblTalla.ColumnCount = 1
        Me.tblTalla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTalla.Controls.Add(Me.lblTallaT, 0, 0)
        Me.tblTalla.Controls.Add(Me.TblTallaLista, 0, 1)
        Me.tblTalla.Location = New System.Drawing.Point(3, 157)
        Me.tblTalla.Name = "tblTalla"
        Me.tblTalla.RowCount = 2
        Me.tblTalla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726!))
        Me.tblTalla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274!))
        Me.tblTalla.Size = New System.Drawing.Size(194, 51)
        Me.tblTalla.TabIndex = 5
        '
        'tblCantidad
        '
        Me.tblCantidad.ColumnCount = 1
        Me.tblCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCantidad.Controls.Add(Me.lblCantidadT, 0, 0)
        Me.tblCantidad.Controls.Add(Me.txtCantidad, 0, 1)
        Me.tblCantidad.Location = New System.Drawing.Point(3, 219)
        Me.tblCantidad.Name = "tblCantidad"
        Me.tblCantidad.RowCount = 2
        Me.tblCantidad.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726!))
        Me.tblCantidad.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274!))
        Me.tblCantidad.Size = New System.Drawing.Size(194, 51)
        Me.tblCantidad.TabIndex = 5
        '
        'lblCantidadT
        '
        Me.lblCantidadT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCantidadT.AutoSize = True
        Me.lblCantidadT.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadT.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCantidadT.Location = New System.Drawing.Point(66, 4)
        Me.lblCantidadT.Name = "lblCantidadT"
        Me.lblCantidadT.Size = New System.Drawing.Size(61, 13)
        Me.lblCantidadT.TabIndex = 4
        Me.lblCantidadT.Text = "CANTIDAD"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(3, 25)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(188, 23)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(3, 290)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 24)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "LOREM IPSUM"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnComprar
        '
        Me.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnComprar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(3, 322)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(194, 24)
        Me.btnComprar.TabIndex = 6
        Me.btnComprar.Text = "LOREM IPSUM"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'tblTotal
        '
        Me.tblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblTotal.ColumnCount = 2
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTotal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTotal.Controls.Add(Me.lblTotalT, 0, 0)
        Me.tblTotal.Controls.Add(Me.lblTotal, 1, 0)
        Me.tblTotal.Location = New System.Drawing.Point(3, 471)
        Me.tblTotal.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.tblTotal.Name = "tblTotal"
        Me.tblTotal.RowCount = 1
        Me.tblTotal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTotal.Size = New System.Drawing.Size(197, 32)
        Me.tblTotal.TabIndex = 7
        '
        'lblTotalT
        '
        Me.lblTotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalT.AutoSize = True
        Me.lblTotalT.Location = New System.Drawing.Point(1, 14)
        Me.lblTotalT.Margin = New System.Windows.Forms.Padding(1, 0, 3, 5)
        Me.lblTotalT.Name = "lblTotalT"
        Me.lblTotalT.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalT.TabIndex = 0
        Me.lblTotalT.Text = "Lorem Ipsum"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Location = New System.Drawing.Point(160, 1)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(3, 1, 0, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.lblTotal.Size = New System.Drawing.Size(37, 31)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "$0"
        '
        'plProductoM
        '
        Me.plProductoM.Location = New System.Drawing.Point(118, 310)
        Me.plProductoM.Name = "plProductoM"
        Me.plProductoM.Size = New System.Drawing.Size(381, 503)
        Me.plProductoM.TabIndex = 13
        '
        'BTN_HOMBRES
        '
        Me.BTN_HOMBRES.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_HOMBRES.BackColor = System.Drawing.Color.White
        Me.BTN_HOMBRES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_HOMBRES.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_HOMBRES.FlatAppearance.BorderSize = 0
        Me.BTN_HOMBRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_HOMBRES.Location = New System.Drawing.Point(12, 5)
        Me.BTN_HOMBRES.Name = "BTN_HOMBRES"
        Me.BTN_HOMBRES.Size = New System.Drawing.Size(75, 23)
        Me.BTN_HOMBRES.TabIndex = 0
        Me.BTN_HOMBRES.Text = "HOMBRES"
        Me.BTN_HOMBRES.UseVisualStyleBackColor = False
        '
        'BTN_MUJERES
        '
        Me.BTN_MUJERES.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_MUJERES.BackColor = System.Drawing.Color.White
        Me.BTN_MUJERES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_MUJERES.CausesValidation = False
        Me.BTN_MUJERES.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_MUJERES.FlatAppearance.BorderSize = 0
        Me.BTN_MUJERES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MUJERES.Location = New System.Drawing.Point(111, 5)
        Me.BTN_MUJERES.Name = "BTN_MUJERES"
        Me.BTN_MUJERES.Size = New System.Drawing.Size(75, 23)
        Me.BTN_MUJERES.TabIndex = 1
        Me.BTN_MUJERES.Text = "MUJERES"
        Me.BTN_MUJERES.UseVisualStyleBackColor = False
        '
        'BTN_CALZADO
        '
        Me.BTN_CALZADO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_CALZADO.BackColor = System.Drawing.Color.White
        Me.BTN_CALZADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_CALZADO.CausesValidation = False
        Me.BTN_CALZADO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_CALZADO.FlatAppearance.BorderSize = 0
        Me.BTN_CALZADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CALZADO.Location = New System.Drawing.Point(210, 5)
        Me.BTN_CALZADO.Name = "BTN_CALZADO"
        Me.BTN_CALZADO.Size = New System.Drawing.Size(75, 23)
        Me.BTN_CALZADO.TabIndex = 2
        Me.BTN_CALZADO.Text = "CALZADO"
        Me.BTN_CALZADO.UseVisualStyleBackColor = False
        '
        'BTN_ACCESORIOS
        '
        Me.BTN_ACCESORIOS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_ACCESORIOS.BackColor = System.Drawing.Color.White
        Me.BTN_ACCESORIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_ACCESORIOS.CausesValidation = False
        Me.BTN_ACCESORIOS.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_ACCESORIOS.FlatAppearance.BorderSize = 0
        Me.BTN_ACCESORIOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACCESORIOS.Location = New System.Drawing.Point(303, 5)
        Me.BTN_ACCESORIOS.Name = "BTN_ACCESORIOS"
        Me.BTN_ACCESORIOS.Size = New System.Drawing.Size(89, 23)
        Me.BTN_ACCESORIOS.TabIndex = 3
        Me.BTN_ACCESORIOS.Text = "ACCESORIOS"
        Me.BTN_ACCESORIOS.UseVisualStyleBackColor = False
        '
        'BTN_S
        '
        Me.BTN_S.FlatAppearance.BorderSize = 0
        Me.BTN_S.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_S.Font = New System.Drawing.Font("Segoe UI Light", 4.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_S.Location = New System.Drawing.Point(29, 3)
        Me.BTN_S.Name = "BTN_S"
        Me.BTN_S.Size = New System.Drawing.Size(20, 14)
        Me.BTN_S.TabIndex = 1
        Me.BTN_S.UseVisualStyleBackColor = True
        '
        'BTN_M
        '
        Me.BTN_M.FlatAppearance.BorderSize = 0
        Me.BTN_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_M.Font = New System.Drawing.Font("Segoe UI Light", 4.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_M.Location = New System.Drawing.Point(55, 3)
        Me.BTN_M.Name = "BTN_M"
        Me.BTN_M.Size = New System.Drawing.Size(20, 14)
        Me.BTN_M.TabIndex = 2
        Me.BTN_M.UseVisualStyleBackColor = True
        '
        'BTN_L
        '
        Me.BTN_L.FlatAppearance.BorderSize = 0
        Me.BTN_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_L.Font = New System.Drawing.Font("Segoe UI Light", 4.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_L.Location = New System.Drawing.Point(81, 3)
        Me.BTN_L.Name = "BTN_L"
        Me.BTN_L.Size = New System.Drawing.Size(20, 14)
        Me.BTN_L.TabIndex = 3
        Me.BTN_L.UseVisualStyleBackColor = True
        '
        'BTN_XL
        '
        Me.BTN_XL.FlatAppearance.BorderSize = 0
        Me.BTN_XL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_XL.Font = New System.Drawing.Font("Segoe UI Light", 4.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_XL.Location = New System.Drawing.Point(107, 3)
        Me.BTN_XL.Name = "BTN_XL"
        Me.BTN_XL.Size = New System.Drawing.Size(24, 14)
        Me.BTN_XL.TabIndex = 4
        Me.BTN_XL.UseVisualStyleBackColor = True
        '
        'BTN_XS
        '
        Me.BTN_XS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_XS.FlatAppearance.BorderSize = 0
        Me.BTN_XS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_XS.Font = New System.Drawing.Font("Segoe UI Light", 4.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_XS.Location = New System.Drawing.Point(3, 3)
        Me.BTN_XS.Name = "BTN_XS"
        Me.BTN_XS.Size = New System.Drawing.Size(20, 14)
        Me.BTN_XS.TabIndex = 0
        Me.BTN_XS.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 119)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_02_small
        Me.PictureBox2.Location = New System.Drawing.Point(3, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 119)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_03_small
        Me.PictureBox3.Location = New System.Drawing.Point(3, 253)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 119)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.ep_shoppingcart.My.Resources.Resources.h_01_04_small
        Me.PictureBox4.Location = New System.Drawing.Point(3, 378)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(93, 122)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "h-01-01-small.jpg")
        Me.ImageList1.Images.SetKeyName(1, "h-01-02-small.jpg")
        Me.ImageList1.Images.SetKeyName(2, "h-01-03-small.jpg")
        Me.ImageList1.Images.SetKeyName(3, "h-01-04-small.jpg")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 750)
        Me.Controls.Add(Me.plProductoM)
        Me.Controls.Add(Me.tblDetails)
        Me.Controls.Add(Me.tblCopyright)
        Me.Controls.Add(Me.tblTitle)
        Me.Controls.Add(Me.tblProdSmall)
        Me.Controls.Add(Me.plMainTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plMainTitle.ResumeLayout(False)
        Me.plMainTitle.PerformLayout()
        Me.tblProdSmall.ResumeLayout(False)
        Me.tblTitle.ResumeLayout(False)
        Me.tblMenu.ResumeLayout(False)
        Me.tblNavigation.ResumeLayout(False)
        Me.tblNavigation.PerformLayout()
        Me.tblCopyright.ResumeLayout(False)
        Me.tblCopyright.PerformLayout()
        Me.TblTallaLista.ResumeLayout(False)
        Me.tblDetails.ResumeLayout(False)
        Me.tblDetails.PerformLayout()
        Me.tblTalla.ResumeLayout(False)
        Me.tblTalla.PerformLayout()
        Me.tblCantidad.ResumeLayout(False)
        Me.tblCantidad.PerformLayout()
        Me.tblTotal.ResumeLayout(False)
        Me.tblTotal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbCover As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents plMainTitle As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents tblProdSmall As TableLayoutPanel
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblLorem As Label
    Friend WithEvents lblTallaT As Label
    Friend WithEvents tblTitle As TableLayoutPanel
    Friend WithEvents tblMenu As TableLayoutPanel
    Friend WithEvents tblNavigation As TableLayoutPanel
    Friend WithEvents tblCopyright As TableLayoutPanel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents plLine2 As Panel
    Friend WithEvents plLine1 As Panel
    Friend WithEvents ilFlechas As ImageList
    Friend WithEvents TblTallaLista As TableLayoutPanel
    Friend WithEvents tblDetails As TableLayoutPanel
    Friend WithEvents tblTalla As TableLayoutPanel
    Friend WithEvents tblCantidad As TableLayoutPanel
    Friend WithEvents lblCantidadT As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents tblTotal As TableLayoutPanel
    Friend WithEvents lblTotalT As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents plProductoM As Panel
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents BTN_HOMBRES As Button
    Friend WithEvents BTN_MUJERES As Button
    Friend WithEvents BTN_CALZADO As Button
    Friend WithEvents BTN_ACCESORIOS As Button
    Friend WithEvents BTN_S As Button
    Friend WithEvents BTN_M As Button
    Friend WithEvents BTN_L As Button
    Friend WithEvents BTN_XL As Button
    Friend WithEvents BTN_XS As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class
