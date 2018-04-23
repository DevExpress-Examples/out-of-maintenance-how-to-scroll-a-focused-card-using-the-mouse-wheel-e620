using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Card;

namespace MouseWheelScrollCard
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Card.CardView cardView1;
		private MouseWheelScrollCard.DataSet1 dataSet11;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
		private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
		private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
		private DevExpress.XtraGrid.Columns.GridColumn colShippedDate;
		private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
		private DevExpress.XtraGrid.Columns.GridColumn colFreight;
		private DevExpress.XtraGrid.Columns.GridColumn colShipName;
		private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
		private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
		private DevExpress.XtraGrid.Columns.GridColumn colShipRegion;
		private DevExpress.XtraGrid.Columns.GridColumn colShipPostalCode;
		private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
		private DevExpress.XtraGrid.Columns.GridColumn colShipDate;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.dataSet11 = new MouseWheelScrollCard.DataSet1();
			this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipRegion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.dataSet11.Orders;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// gridControl1.EmbeddedNavigator
			// 
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.cardView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(376, 194);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.cardView1});
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// cardView1
			// 
			this.cardView1.Appearance.FieldValue.Options.UseTextOptions = true;
			this.cardView1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.cardView1.CardWidth = 300;
			this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.colOrderID,
																							 this.colCustomerID,
																							 this.colEmployeeID,
																							 this.colOrderDate,
																							 this.colRequiredDate,
																							 this.colShippedDate,
																							 this.colShipVia,
																							 this.colFreight,
																							 this.colShipName,
																							 this.colShipAddress,
																							 this.colShipCity,
																							 this.colShipRegion,
																							 this.colShipPostalCode,
																							 this.colShipCountry,
																							 this.colShipDate});
			this.cardView1.FocusedCardTopFieldIndex = 0;
			this.cardView1.GridControl = this.gridControl1;
			this.cardView1.Name = "cardView1";
			this.cardView1.OptionsPrint.PrintFilterInfo = false;
			this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
			this.cardView1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.cardView1_MouseWheel);
			// 
			// colOrderID
			// 
			this.colOrderID.Caption = "OrderID";
			this.colOrderID.FieldName = "OrderID";
			this.colOrderID.Name = "colOrderID";
			this.colOrderID.OptionsColumn.ReadOnly = true;
			this.colOrderID.Visible = true;
			this.colOrderID.VisibleIndex = 0;
			// 
			// colCustomerID
			// 
			this.colCustomerID.Caption = "CustomerID";
			this.colCustomerID.FieldName = "CustomerID";
			this.colCustomerID.Name = "colCustomerID";
			this.colCustomerID.Visible = true;
			this.colCustomerID.VisibleIndex = 1;
			// 
			// colEmployeeID
			// 
			this.colEmployeeID.Caption = "EmployeeID";
			this.colEmployeeID.FieldName = "EmployeeID";
			this.colEmployeeID.Name = "colEmployeeID";
			this.colEmployeeID.Visible = true;
			this.colEmployeeID.VisibleIndex = 2;
			// 
			// colOrderDate
			// 
			this.colOrderDate.Caption = "OrderDate";
			this.colOrderDate.FieldName = "OrderDate";
			this.colOrderDate.Name = "colOrderDate";
			this.colOrderDate.Visible = true;
			this.colOrderDate.VisibleIndex = 3;
			// 
			// colRequiredDate
			// 
			this.colRequiredDate.Caption = "RequiredDate";
			this.colRequiredDate.FieldName = "RequiredDate";
			this.colRequiredDate.Name = "colRequiredDate";
			this.colRequiredDate.Visible = true;
			this.colRequiredDate.VisibleIndex = 4;
			// 
			// colShippedDate
			// 
			this.colShippedDate.Caption = "ShippedDate";
			this.colShippedDate.FieldName = "ShippedDate";
			this.colShippedDate.Name = "colShippedDate";
			this.colShippedDate.Visible = true;
			this.colShippedDate.VisibleIndex = 5;
			// 
			// colShipVia
			// 
			this.colShipVia.Caption = "ShipVia";
			this.colShipVia.FieldName = "ShipVia";
			this.colShipVia.Name = "colShipVia";
			this.colShipVia.Visible = true;
			this.colShipVia.VisibleIndex = 6;
			// 
			// colFreight
			// 
			this.colFreight.Caption = "Freight";
			this.colFreight.FieldName = "Freight";
			this.colFreight.Name = "colFreight";
			this.colFreight.Visible = true;
			this.colFreight.VisibleIndex = 7;
			// 
			// colShipName
			// 
			this.colShipName.Caption = "ShipName";
			this.colShipName.FieldName = "ShipName";
			this.colShipName.Name = "colShipName";
			this.colShipName.Visible = true;
			this.colShipName.VisibleIndex = 8;
			// 
			// colShipAddress
			// 
			this.colShipAddress.Caption = "ShipAddress";
			this.colShipAddress.FieldName = "ShipAddress";
			this.colShipAddress.Name = "colShipAddress";
			this.colShipAddress.Visible = true;
			this.colShipAddress.VisibleIndex = 9;
			// 
			// colShipCity
			// 
			this.colShipCity.Caption = "ShipCity";
			this.colShipCity.FieldName = "ShipCity";
			this.colShipCity.Name = "colShipCity";
			this.colShipCity.Visible = true;
			this.colShipCity.VisibleIndex = 10;
			// 
			// colShipRegion
			// 
			this.colShipRegion.Caption = "ShipRegion";
			this.colShipRegion.FieldName = "ShipRegion";
			this.colShipRegion.Name = "colShipRegion";
			this.colShipRegion.Visible = true;
			this.colShipRegion.VisibleIndex = 11;
			// 
			// colShipPostalCode
			// 
			this.colShipPostalCode.Caption = "ShipPostalCode";
			this.colShipPostalCode.FieldName = "ShipPostalCode";
			this.colShipPostalCode.Name = "colShipPostalCode";
			this.colShipPostalCode.Visible = true;
			this.colShipPostalCode.VisibleIndex = 12;
			// 
			// colShipCountry
			// 
			this.colShipCountry.Caption = "ShipCountry";
			this.colShipCountry.FieldName = "ShipCountry";
			this.colShipCountry.Name = "colShipCountry";
			this.colShipCountry.Visible = true;
			this.colShipCountry.VisibleIndex = 13;
			// 
			// colShipDate
			// 
			this.colShipDate.Caption = "ShipDate";
			this.colShipDate.FieldName = "ShipDate";
			this.colShipDate.Name = "colShipDate";
			this.colShipDate.Visible = true;
			this.colShipDate.VisibleIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 194);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			dataSet11.Orders.AddOrdersRow("QUEEN", 5, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(3), 
				DateTime.Today.AddDays(-1), 3, 23.0m, "Vins et alcools Chevalier", "59 rue de l'Abbaye", 
				"Reims", "", "51100", "France", DateTime.Now.AddDays(-1));
		}


		private void cardView1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e) {
			CardView view = sender as CardView;
			view.FocusedCardTopFieldIndex -= Math.Sign(e.Delta);
			throw new DevExpress.Utils.HideException();
		}
	}
}
