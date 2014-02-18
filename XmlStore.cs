using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace XmlStore
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox tablesListbox;
		private System.Windows.Forms.TextBox tableNameTextbox;
		private System.Windows.Forms.Button addTableButton;
		private System.Windows.Forms.Button removeTableButton;
		private System.Windows.Forms.Button changeTableNameButton;
		private System.Windows.Forms.TextBox columnNameTextbox;
		private System.Windows.Forms.ComboBox columnTypeCombobox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button changeColumnButton;
		private System.Windows.Forms.Button removeColumnButton;
        private System.Windows.Forms.Button addColumnButton;
		private System.Windows.Forms.ListView columnsListbox;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnType;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuSaveAs;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuExit;

		private DataTable currentTable;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.MenuItem menuAbout;
		private string fileNameSchema=null;
        private DataSet dataSet = new DataSet();
        private MenuItem menuTools;
        private MenuItem menuXMLDocValidator;
        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private GroupBox groupBoxExistingTables;
        private DataGrid dataDatagrid;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private MenuItem xpathLocatorMenuItem;
        private MenuItem saveSchemaMenuItem;
        private MenuItem saveXMLDataMenuItem;
        private IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
	{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTableButton = new System.Windows.Forms.Button();
            this.groupBoxExistingTables = new System.Windows.Forms.GroupBox();
            this.changeTableNameButton = new System.Windows.Forms.Button();
            this.tablesListbox = new System.Windows.Forms.ListBox();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.columnsListbox = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeColumnButton = new System.Windows.Forms.Button();
            this.changeColumnButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.columnNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnTypeCombobox = new System.Windows.Forms.ComboBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuNew = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuTools = new System.Windows.Forms.MenuItem();
            this.saveXMLDataMenuItem = new System.Windows.Forms.MenuItem();
            this.saveSchemaMenuItem = new System.Windows.Forms.MenuItem();
            this.menuXMLDocValidator = new System.Windows.Forms.MenuItem();
            this.xpathLocatorMenuItem = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataDatagrid = new System.Windows.Forms.DataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxExistingTables.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBoxExistingTables);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableNameTextbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.addTableButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Table:";
            // 
            // tableNameTextbox
            // 
            this.tableNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameTextbox.Location = new System.Drawing.Point(135, 21);
            this.tableNameTextbox.Name = "tableNameTextbox";
            this.tableNameTextbox.Size = new System.Drawing.Size(232, 20);
            this.tableNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Na&me:";
            // 
            // addTableButton
            // 
            this.addTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTableButton.Location = new System.Drawing.Point(263, 47);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(104, 24);
            this.addTableButton.TabIndex = 1;
            this.addTableButton.Text = "&Add Table";
            this.addTableButton.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // groupBoxExistingTables
            // 
            this.groupBoxExistingTables.Controls.Add(this.changeTableNameButton);
            this.groupBoxExistingTables.Controls.Add(this.tablesListbox);
            this.groupBoxExistingTables.Controls.Add(this.removeTableButton);
            this.groupBoxExistingTables.Location = new System.Drawing.Point(6, 125);
            this.groupBoxExistingTables.Name = "groupBoxExistingTables";
            this.groupBoxExistingTables.Size = new System.Drawing.Size(373, 400);
            this.groupBoxExistingTables.TabIndex = 5;
            this.groupBoxExistingTables.TabStop = false;
            this.groupBoxExistingTables.Text = "Existing tables:";
            // 
            // changeTableNameButton
            // 
            this.changeTableNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTableNameButton.Location = new System.Drawing.Point(144, 370);
            this.changeTableNameButton.Name = "changeTableNameButton";
            this.changeTableNameButton.Size = new System.Drawing.Size(104, 24);
            this.changeTableNameButton.TabIndex = 2;
            this.changeTableNameButton.Text = "&Change Name";
            this.changeTableNameButton.Click += new System.EventHandler(this.changeTableNameButton_Click);
            // 
            // tablesListbox
            // 
            this.tablesListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesListbox.Location = new System.Drawing.Point(6, 19);
            this.tablesListbox.Name = "tablesListbox";
            this.tablesListbox.Size = new System.Drawing.Size(361, 342);
            this.tablesListbox.TabIndex = 4;
            this.tablesListbox.TabStop = false;
            this.tablesListbox.SelectedIndexChanged += new System.EventHandler(this.tablesListBox_SelectedIndexChanged);
            // 
            // removeTableButton
            // 
            this.removeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTableButton.Location = new System.Drawing.Point(263, 370);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(104, 24);
            this.removeTableButton.TabIndex = 3;
            this.removeTableButton.Text = "&Remove Table";
            this.removeTableButton.Click += new System.EventHandler(this.removeButtonTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(399, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.columnsListbox);
            this.groupBox5.Controls.Add(this.removeColumnButton);
            this.groupBox5.Controls.Add(this.changeColumnButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 400);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Existing Columns:";
            // 
            // columnsListbox
            // 
            this.columnsListbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType});
            this.columnsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsListbox.FullRowSelect = true;
            this.columnsListbox.HideSelection = false;
            this.columnsListbox.Location = new System.Drawing.Point(4, 19);
            this.columnsListbox.Name = "columnsListbox";
            this.columnsListbox.Size = new System.Drawing.Size(357, 342);
            this.columnsListbox.TabIndex = 5;
            this.columnsListbox.TabStop = false;
            this.columnsListbox.UseCompatibleStateImageBehavior = false;
            this.columnsListbox.View = System.Windows.Forms.View.Details;
            this.columnsListbox.SelectedIndexChanged += new System.EventHandler(this.columnsListbox_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 260;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 90;
            // 
            // removeColumnButton
            // 
            this.removeColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeColumnButton.Location = new System.Drawing.Point(257, 370);
            this.removeColumnButton.Name = "removeColumnButton";
            this.removeColumnButton.Size = new System.Drawing.Size(104, 24);
            this.removeColumnButton.TabIndex = 4;
            this.removeColumnButton.Text = "Remo&ve Column";
            this.removeColumnButton.Click += new System.EventHandler(this.removeColumnButton_Click);
            // 
            // changeColumnButton
            // 
            this.changeColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeColumnButton.Location = new System.Drawing.Point(147, 370);
            this.changeColumnButton.Name = "changeColumnButton";
            this.changeColumnButton.Size = new System.Drawing.Size(104, 24);
            this.changeColumnButton.TabIndex = 3;
            this.changeColumnButton.Text = "Change &Name";
            this.changeColumnButton.Click += new System.EventHandler(this.changeColumnButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addColumnButton);
            this.groupBox4.Controls.Add(this.columnNameTextbox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.columnTypeCombobox);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Column:";
            // 
            // addColumnButton
            // 
            this.addColumnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColumnButton.Location = new System.Drawing.Point(257, 70);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(104, 24);
            this.addColumnButton.TabIndex = 2;
            this.addColumnButton.Text = "Add C&olumn";
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // columnNameTextbox
            // 
            this.columnNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnNameTextbox.Location = new System.Drawing.Point(135, 19);
            this.columnNameTextbox.Name = "columnNameTextbox";
            this.columnNameTextbox.Size = new System.Drawing.Size(226, 20);
            this.columnNameTextbox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Type:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nam&e:";
            // 
            // columnTypeCombobox
            // 
            this.columnTypeCombobox.CausesValidation = false;
            this.columnTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnTypeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTypeCombobox.Items.AddRange(new object[] {
            "Boolean",
            "Byte",
            "Char",
            "DateTime",
            "Decimal",
            "Double",
            "Int16",
            "Int32",
            "Int64",
            "String"});
            this.columnTypeCombobox.Location = new System.Drawing.Point(135, 43);
            this.columnTypeCombobox.Name = "columnTypeCombobox";
            this.columnTypeCombobox.Size = new System.Drawing.Size(226, 21);
            this.columnTypeCombobox.TabIndex = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuTools,
            this.menuAbout});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuItem5,
            this.menuSave,
            this.menuSaveAs,
            this.menuItem8,
            this.menuExit});
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Index = 0;
            this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 1;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // menuSave
            // 
            this.menuSave.Index = 3;
            this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Index = 4;
            this.menuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuSaveAs.Text = "Save &As...";
            this.menuSaveAs.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 6;
            this.menuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // menuTools
            // 
            this.menuTools.Index = 1;
            this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.saveXMLDataMenuItem,
            this.saveSchemaMenuItem,
            this.xpathLocatorMenuItem,
            this.menuXMLDocValidator});
            this.menuTools.Text = "&Tools";
            // 
            // saveXMLDataMenuItem
            // 
            this.saveXMLDataMenuItem.Index = 0;
            this.saveXMLDataMenuItem.Text = "Save XML Data";
            this.saveXMLDataMenuItem.Click += new System.EventHandler(this.saveXMLDataMenuItem_Click);
            // 
            // saveSchemaMenuItem
            // 
            this.saveSchemaMenuItem.Index = 1;
            this.saveSchemaMenuItem.Text = "Save XML Schema";
            this.saveSchemaMenuItem.Click += new System.EventHandler(this.saveSchemaMenuItem_Click);
            // 
            // menuXMLDocValidator
            // 
            this.menuXMLDocValidator.Index = 3;
            this.menuXMLDocValidator.Text = "XML Doc Validator";
            this.menuXMLDocValidator.Click += new System.EventHandler(this.menuXMLDocValidator_Click);
            // 
            // xpathLocatorMenuItem
            // 
            this.xpathLocatorMenuItem.Index = 2;
            this.xpathLocatorMenuItem.Text = "XPath Validator";
            this.xpathLocatorMenuItem.Click += new System.EventHandler(this.xpathLocatorMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 2;
            this.menuAbout.Text = "&About!";
            this.menuAbout.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML Files|*.xml";
            this.saveFileDialog.InitialDirectory = ".\\";
            this.saveFileDialog.Title = "Save Database As...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "\"XML Files|*.xml";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(0, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(842, 687);
            this.mainTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataDatagrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataDatagrid
            // 
            this.dataDatagrid.DataMember = "";
            this.dataDatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDatagrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataDatagrid.Location = new System.Drawing.Point(0, 3);
            this.dataDatagrid.Name = "dataDatagrid";
            this.dataDatagrid.Size = new System.Drawing.Size(781, 544);
            this.dataDatagrid.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 21);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(785, 589);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "XML Store v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxExistingTables.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDatagrid)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		// ========================== MENU COMMANDS =========================
        /// <summary>
        /// Hanles New menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void newMenu_Click(object sender, System.EventArgs e)
		{
			fileNameSchema=null;
			tablesListbox.Items.Clear();
			columnsListbox.Items.Clear();
			tableNameTextbox.Text = "";
			columnNameTextbox.Text = "";
			columnTypeCombobox.Text = "";
			this.Text = "XML Store";
			dataSet = new DataSet();
			dataDatagrid.SetDataBinding(dataSet, null);
		}
        /// <summary>
        /// Handles Open menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void openMenu_Click(object sender, System.EventArgs e)
		{
            openFileDialog.Title = "Select file to open the store...";
			DialogResult dialogResult = openFileDialog.ShowDialog(this);
			if (dialogResult == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				DataSet ds = new DataSet();
				ds.ReadXml(fileName);
				tablesListbox.Items.Clear();
				foreach (DataTable dt in ds.Tables)
				{
					tablesListbox.Items.Add(dt.TableName);
				}
				dataSet = ds;
				tablesListbox.SelectedIndex = 0;
				fileNameSchema = fileName;
				this.Text="XML Store - "+fileNameSchema;
			}
		}
        /// <summary>
        /// Handles Save menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void saveMenu_Click(object sender, System.EventArgs e)
		{
			if (fileNameSchema == null)
				saveAsMenu_Click(sender, e);
			else
			{
				SaveXml(fileNameSchema, true);
				tablesListbox.SelectedIndex=tablesListbox.SelectedIndex;		// reselect
			}
		}
        /// <summary>
        /// Handles SaveAs menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void saveAsMenu_Click(object sender, System.EventArgs e)
		{
			DialogResult res = saveFileDialog.ShowDialog(this);
			if (res == DialogResult.OK)
			{
				fileNameSchema = saveFileDialog.FileName;
                SaveXml(fileNameSchema, true);
				this.Text="XML Store - "+fileNameSchema;
				tablesListbox.SelectedIndex=tablesListbox.SelectedIndex;		// reselect
			}
		}
        /// <summary>
        /// Handles About menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void aboutMenu_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("XML Store v1.0\nShikha Agrawal & Deeti Shah\nshikha87it@gmail.com", "XML Store & Database v1.0", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
        /// <summary>
        /// Handles exit menu command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void exitMenu_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		// ========================= TABLE MANIPULATION ========================
        /// <summary>
        /// Handles table add 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnAddTable_Click(object sender, System.EventArgs e)
		{
			string tblName=tableNameTextbox.Text;
			if (!ValidateTableName(tblName))
			{
				return;
			}
			
			DataTable dt = new DataTable(tblName);
			currentTable = dt;
			tablesListbox.Items.Add(tblName);
			dataSet.Tables.Add(dt);
			tablesListbox.SelectedItem = tablesListbox.Items[tablesListbox.FindStringExact(tblName)];
		}
        /// <summary>
        /// Handles table name change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void changeTableNameButton_Click(object sender, System.EventArgs e)
		{
			string tableName = tableNameTextbox.Text;
            if (!ValidateSelectedTable() || !ValidateTableName(tableNameTextbox.Text))
                return;

			int n = tablesListbox.Items.IndexOf(tablesListbox.SelectedItem);
			string oldTableName = tablesListbox.Items[n].ToString();
			dataSet.Tables[oldTableName].TableName = tableName;
			tablesListbox.Items[n] = tableName;
			dataDatagrid.SetDataBinding(dataSet, tableName);
		}
        /// <summary>
        /// Removes tables name from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void removeButtonTable_Click(object sender, System.EventArgs e)
		{
			if ( !ValidateSelectedTable())
			{
				return;
			}
			int n = tablesListbox.Items.IndexOf(tablesListbox.SelectedItem);
			string tableName = tablesListbox.Items[n].ToString();
			tablesListbox.Items.Remove(tablesListbox.SelectedItem);
		
			DataTable dt = dataSet.Tables[tableName];
			dt.Clear();
			dt.Columns.Clear();
			dataSet.Tables.Remove(tableName);
			
			currentTable = null;
			dataDatagrid.SetDataBinding(dataSet, null);
		}
        /// <summary>
        /// Handles selection change in the table list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void tablesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string tableName = tablesListbox.Text;
            tableNameTextbox.Text = tableName;
			currentTable=dataSet.Tables[tableName];
			ShowColumns();
			dataDatagrid.SetDataBinding(dataSet, tableName);
			dataDatagrid.CaptionText = "Table: "+tableName;
            mainTabControl.TabPages[1].Text = "Data: " + tableName;
		}

		// ========================= COLUMN MANIPULATION ========================
        /// <summary>
        /// Handles new column add to the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void addColumnButton_Click(object sender, System.EventArgs e)
		{
			string columnName = columnNameTextbox.Text;
			string columnType = columnTypeCombobox.Text;
			if ( (!ValidateColumnNameAndType(columnName, columnType)) || (!ValidateSelectedTable()) )
			{
				return;
			}
			ListViewItem listViewItem=columnsListbox.Items.Add(columnName);
			listViewItem.SubItems.Add(columnType);
			currentTable.Columns.Add(columnName, Type.GetType("System."+columnType));
		}
        /// <summary>
        /// Handles name change for the column in a table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void changeColumnButton_Click(object sender, System.EventArgs e)
		{
            ListViewItem listViewItem = columnsListbox.SelectedItems[0];
            if (!ValidateSelectedColumn() || 
                !ValidateColumnNameAndType(columnNameTextbox.Text, listViewItem.SubItems[1].Text))
			{
				return;
			}

			string prevColumnName = listViewItem.Text;
			listViewItem.Text = columnNameTextbox.Text;
			currentTable.Columns[prevColumnName].ColumnName = columnNameTextbox.Text;

            if (dataSet.Tables[0].Rows.Count != 0 &&
                listViewItem.SubItems[1].Text != columnTypeCombobox.Text)
            {
                if (DialogResult.OK == MessageBox.Show("Column type change will result in data from that column to be dropped. \n Do you want to go ahead?",
                    "Xml Store v1.0", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    // can't change the data type once data exists
                    listViewItem.SubItems[1].Text = columnTypeCombobox.Text;
                    int indexOf = currentTable.Columns.IndexOf(columnNameTextbox.Text);
                    currentTable.Columns.Remove(columnNameTextbox.Text);
                    DataColumn column = new DataColumn(listViewItem.SubItems[0].Text, Type.GetType("System." + columnTypeCombobox.Text));
                    currentTable.Columns.Add(column);
                    column.SetOrdinal(indexOf);
                }
                else
                    return;
            }
		}
        /// <summary>
        /// Removes column from the list and table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void removeColumnButton_Click(object sender, System.EventArgs e)
		{
			if (!ValidateSelectedColumn())
			{
				return;
			}
			ListViewItem listViewItem = columnsListbox.SelectedItems[0];
			columnsListbox.Items.Remove(listViewItem);
			currentTable.Columns.Remove(listViewItem.Text);
		}

		// ========================= HELPERS ========================
        /// <summary>
        /// Validates table name
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <returns></returns>
		bool ValidateTableName(string tableName)
		{
			if (tableName == "")
			{
				MessageBox.Show("Please enter a name for the table.", "Missing Information");
				return false;
			}
			int ret=tablesListbox.FindStringExact(tableName);
			if (ret!=ListBox.NoMatches)
			{
				MessageBox.Show("This table is already defined.", "Duplicate Name");
				return false;
			}
			return true;
		}
        /// <summary>
        /// Validates selected table for errors
        /// </summary>
        /// <returns></returns>
		bool ValidateSelectedTable()
		{
			if (tablesListbox.SelectedItem == null)
			{
				MessageBox.Show("Please select a table from the table list.", "No Selection");
				return false;
			}
			return true;
		}
        /// <summary>
        /// Validates column name and type
        /// </summary>
        /// <param name="columnName">Name of the column</param>
        /// <param name="columnType">Name of the type</param>
        /// <returns></returns>
		bool ValidateColumnNameAndType(string columnName, string columnType)
		{
			if (columnName == "")
			{
				MessageBox.Show("Please enter a name for the column.", "Missing Information");
				return false;
			}
			if (columnType == "")
			{
				MessageBox.Show("Please select a type for the column.", "Missing Information");
				return false;
			}

			if (GetListViewItem(columnName)!=null)
			{
				MessageBox.Show("This column is already defined.", "Duplicate Name");
				return false;
			}
			return true;
		}
        /// <summary>
        /// Validates selected column for errors
        /// </summary>
        /// <returns></returns>
		bool ValidateSelectedColumn()
		{
			if (columnsListbox.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please select a column from the column list.", "No Selection");
				return false;
			}
			return true;
		}
        /// <summary>
        /// Gets list view item for given column name
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
		ListViewItem GetListViewItem(string columnName)
		{
			ListView.ListViewItemCollection lvItems=columnsListbox.Items;
			foreach (ListViewItem listViewItem in lvItems)
			{
				if (listViewItem.Text == columnName)
				{
					return listViewItem;
				}
			}
			return null;
		}
        /// <summary>
        /// Shows all the columns for loaded store in the list
        /// </summary>
		void ShowColumns()
		{
			columnsListbox.Items.Clear();
			if (currentTable != null)
			{
				foreach (DataColumn dc in currentTable.Columns)
				{
					ListViewItem listViewItem=columnsListbox.Items.Add(dc.ColumnName);
					string s=dc.DataType.ToString();
					s=s.Split(new Char[] {'.'})[1];
					listViewItem.SubItems.Add(s);
				}
			}
            if(this.columnsListbox.Items.Count > 0)
                this.columnsListbox.Items[0].Selected = true;
		}
		/// <summary>
		/// Saves data and schema to the file
		/// </summary>
		/// <param name="fileName">File name to which data and schema will be saved</param>
		/// <param name="includeSchema">
        /// True: Schema is saved in the file with data
        /// False: Only data is saved to the file
        /// </param>
		void SaveXml(string fileName, bool includeSchema)
		{
            if (includeSchema)
            {
                dataSet.WriteXml(fileName, XmlWriteMode.WriteSchema);
                MessageBox.Show("XML schema and data saved", "XML Store v1.0");
            }
            else
            {
                dataSet.WriteXml(fileName, XmlWriteMode.IgnoreSchema);
                MessageBox.Show("XML data saved", "XML Store v1.0");
            }
			
        }
        /// <summary>
        /// Saves schema to the file
        /// </summary>
        /// <param name="fileName">File name where schema will be saved</param>
        void SaveSchema(String fileName)
        {
            dataSet.WriteXmlSchema(fileName);
            MessageBox.Show("XML Schema saved", "XML Store v1.0");
        }
        /// <summary>
        /// Updates controls when column selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void columnsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (columnsListbox.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = columnsListbox.SelectedItems[0];
                columnNameTextbox.Text = listViewItem.SubItems[0].Text;
                columnTypeCombobox.Text = listViewItem.SubItems[1].Text;
            }
        }
        /// <summary>
        /// Validates XML document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuXMLDocValidator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming with next version of XML Store.", "XML Store v1.0", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        /// <summary>
        /// Handles error and warning found in xml document validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void xmlDocValidatorEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                   MessageBox.Show(String.Format("Error: {0}", e.Message), "XML validation error");
                    break;
                case XmlSeverityType.Warning:
                    MessageBox.Show(String.Format("Warning {0}", e.Message), "XML validation warning");
                    break;
            }

        }
        /// <summary>
        /// Saves scehama for loaded XML to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveSchemaMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                fileNameSchema = saveFileDialog.FileName;
                SaveSchema(fileNameSchema);
            }
        }
        /// <summary>
        /// Saves xml data to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveXMLDataMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                fileNameSchema = saveFileDialog.FileName;
                SaveXml(fileNameSchema, false);
            }
        }

        private void xpathLocatorMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select XML file to load...";
			DialogResult dialogResult = openFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                XPathForm xPathForm = new XPathForm(openFileDialog.FileName);
                xPathForm.ShowDialog(this);
            }
        }
	}
}
