Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Card

Namespace MouseWheelScrollCard
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits System.Windows.Forms.Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(376, 194)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1})
            ' 
            ' cardView1
            ' 
            Me.cardView1.Appearance.FieldValue.Options.UseTextOptions = True
            Me.cardView1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.cardView1.CardWidth = 300
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(376, 194)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim dt As New DataTable()
            For i As Integer = 0 To 13
                dt.Columns.Add("Column" & i)
            Next i
            dt.Rows.Add(New Object() {"QUEEN", 5, Date.Today.AddDays(-10), Date.Today.AddDays(3), Date.Today.AddDays(-1), 3, 23.0D, "Vins et alcools Chevalier", "59 rue de l'Abbaye", "Reims", "", "51100", "France", Date.Now.AddDays(-1) })
            gridControl1.DataSource = dt
        End Sub
        Private Sub cardView1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cardView1.MouseWheel
            Dim view As CardView = TryCast(sender, CardView)
            view.FocusedCardTopFieldIndex -= Math.Sign(e.Delta)
            Throw New DevExpress.Utils.HideException()
        End Sub
    End Class
End Namespace
