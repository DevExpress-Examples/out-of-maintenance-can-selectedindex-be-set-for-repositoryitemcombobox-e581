Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace SetComboBoxValue
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private colDay As DevExpress.XtraGrid.Columns.GridColumn
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private bindingSource1 As BindingSource
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colDay = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(8, 32)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(208, 20)
			Me.comboBoxEdit1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(367, 32)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(168, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Set Day Index 1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.ExternalRepository = Me.persistentRepository1
			Me.gridControl1.Location = New System.Drawing.Point(8, 64)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(325, 208)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Day"
			' 
			' persistentRepository1
			' 
			Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colDay})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colDay
			' 
			Me.colDay.Caption = "Day"
			Me.colDay.ColumnEdit = Me.repositoryItemComboBox1
			Me.colDay.FieldName = "Day"
			Me.colDay.Name = "colDay"
			Me.colDay.Visible = True
			Me.colDay.VisibleIndex = 0
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.ExternalRepository = Me.persistentRepository1
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barEditItem1})
			Me.barManager1.MaxItemId = 2
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 1"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem1, "", False, True, True, 201)})
			Me.bar1.Text = "Custom 1"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemComboBox1
			Me.barEditItem1.Id = 0
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(367, 61)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(168, 23)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "Get Selected Day and Index"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(545, 280)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			dataTable1.Rows.Add(New Object() { "Friday" })
			dataTable1.Rows.Add(New Object() { "Saturday" })

			comboBoxEdit1.Properties.Assign(repositoryItemComboBox1)
			gridControl1.RepositoryItems.Add(repositoryItemComboBox1)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			' Get the value at index 1
			Const index As Integer = 1
			Dim val As Object = repositoryItemComboBox1.Items(index)

			' stand-alone editor
			'comboBoxEdit1.SelectedIndex = index;
			' or
			comboBoxEdit1.EditValue = val

			' XtraGrid
			gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Day", val)

			' XtraBars
			barEditItem1.EditValue = val
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Dim result As String = ""
			Dim val As Object

			' XtraBars
			val = barEditItem1.EditValue
			result &= String.Format("XtraBars editor: " & Constants.vbTab & " {0} / {1}", val, repositoryItemComboBox1.Items.IndexOf(val))

			' stand-alone editor
			val = comboBoxEdit1.EditValue
			result &= String.Format(Constants.vbLf & "ComboBoxEdit: " & Constants.vbTab & " {0} / {1}", val, repositoryItemComboBox1.Items.IndexOf(val))

			' XtraGrid
			val = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Day")
			result &= String.Format(Constants.vbLf & "XtraGrid cell: " & Constants.vbTab & " {0} / {1}", val, repositoryItemComboBox1.Items.IndexOf(val))

			MessageBox.Show(result)
		End Sub
	End Class
End Namespace
