namespace ProductInventoryApp.UI;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.tlpRoot = new TableLayoutPanel();
        this.flpInput = new FlowLayoutPanel();
        this.lblName = new Label();
        this.txtName = new TextBox();
        this.lblSku = new Label();
        this.txtSku = new TextBox();
        this.lblCategory = new Label();
        this.txtCategory = new TextBox();
        this.lblPrice = new Label();
        this.txtPrice = new TextBox();
        this.lblQuantity = new Label();
        this.txtQuantity = new TextBox();
        this.btnAdd = new Button();
        this.flpSearch = new FlowLayoutPanel();
        this.lblSearch = new Label();
        this.txtSearch = new TextBox();
        this.lblError = new Label();
        this.dgvProducts = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
        this.tlpRoot.SuspendLayout();
        this.flpInput.SuspendLayout();
        this.flpSearch.SuspendLayout();
        this.SuspendLayout();

        // tlpRoot
        this.tlpRoot.Dock = DockStyle.Fill;
        this.tlpRoot.ColumnCount = 1;
        this.tlpRoot.RowCount = 3;
        this.tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        this.tlpRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        this.tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tlpRoot.Controls.Add(this.flpInput, 0, 0);
        this.tlpRoot.Controls.Add(this.flpSearch, 0, 1);
        this.tlpRoot.Controls.Add(this.dgvProducts, 0, 2);

        // flpInput
        this.flpInput.AutoSize = true;
        this.flpInput.Dock = DockStyle.Top;
        this.flpInput.Padding = new Padding(10);
        this.flpInput.WrapContents = true;
        this.flpInput.Controls.Add(this.lblName);
        this.flpInput.Controls.Add(this.txtName);
        this.flpInput.Controls.Add(this.lblSku);
        this.flpInput.Controls.Add(this.txtSku);
        this.flpInput.Controls.Add(this.lblCategory);
        this.flpInput.Controls.Add(this.txtCategory);
        this.flpInput.Controls.Add(this.lblPrice);
        this.flpInput.Controls.Add(this.txtPrice);
        this.flpInput.Controls.Add(this.lblQuantity);
        this.flpInput.Controls.Add(this.txtQuantity);
        this.flpInput.Controls.Add(this.btnAdd);

        // lblName
        this.lblName.AutoSize = true;
        this.lblName.Text = "Name:";
        this.lblName.Margin = new Padding(3, 8, 3, 3);

        // txtName
        this.txtName.Width = 150;
        this.txtName.Margin = new Padding(3, 3, 15, 3);

        // lblSku
        this.lblSku.AutoSize = true;
        this.lblSku.Text = "SKU:";
        this.lblSku.Margin = new Padding(3, 8, 3, 3);

        // txtSku
        this.txtSku.Width = 100;
        this.txtSku.Margin = new Padding(3, 3, 15, 3);

        // lblCategory
        this.lblCategory.AutoSize = true;
        this.lblCategory.Text = "Category:";
        this.lblCategory.Margin = new Padding(3, 8, 3, 3);

        // txtCategory
        this.txtCategory.Width = 120;
        this.txtCategory.Margin = new Padding(3, 3, 15, 3);

        // lblPrice
        this.lblPrice.AutoSize = true;
        this.lblPrice.Text = "Price:";
        this.lblPrice.Margin = new Padding(3, 8, 3, 3);

        // txtPrice
        this.txtPrice.Width = 80;
        this.txtPrice.Margin = new Padding(3, 3, 15, 3);

        // lblQuantity
        this.lblQuantity.AutoSize = true;
        this.lblQuantity.Text = "Quantity:";
        this.lblQuantity.Margin = new Padding(3, 8, 3, 3);

        // txtQuantity
        this.txtQuantity.Width = 80;
        this.txtQuantity.Margin = new Padding(3, 3, 15, 3);

        // btnAdd
        this.btnAdd.Text = "Add Product";
        this.btnAdd.AutoSize = true;
        this.btnAdd.Margin = new Padding(3, 3, 3, 3);
        this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

        // flpSearch
        this.flpSearch.AutoSize = true;
        this.flpSearch.Dock = DockStyle.Top;
        this.flpSearch.Padding = new Padding(10, 0, 10, 10);
        this.flpSearch.Controls.Add(this.lblSearch);
        this.flpSearch.Controls.Add(this.txtSearch);
        this.flpSearch.Controls.Add(this.lblError);

        // lblSearch
        this.lblSearch.AutoSize = true;
        this.lblSearch.Text = "Search by name:";
        this.lblSearch.Margin = new Padding(3, 8, 3, 3);

        // txtSearch
        this.txtSearch.Width = 200;
        this.txtSearch.Margin = new Padding(3, 3, 20, 3);
        this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);

        // lblError
        this.lblError.AutoSize = true;
        this.lblError.ForeColor = Color.Red;
        this.lblError.Margin = new Padding(3, 8, 3, 3);
        this.lblError.Text = "";

        // dgvProducts
        this.dgvProducts.Dock = DockStyle.Fill;
        this.dgvProducts.ReadOnly = true;
        this.dgvProducts.AllowUserToAddRows = false;
        this.dgvProducts.AllowUserToDeleteRows = false;
        this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvProducts.MultiSelect = false;

        // MainForm
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.tlpRoot);
        this.Text = "Product Inventory";
        this.MinimumSize = new Size(700, 400);

        ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
        this.flpSearch.ResumeLayout(false);
        this.flpSearch.PerformLayout();
        this.flpInput.ResumeLayout(false);
        this.flpInput.PerformLayout();
        this.tlpRoot.ResumeLayout(false);
        this.tlpRoot.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tlpRoot;
    private FlowLayoutPanel flpInput;
    private Label lblName;
    private TextBox txtName;
    private Label lblSku;
    private TextBox txtSku;
    private Label lblCategory;
    private TextBox txtCategory;
    private Label lblPrice;
    private TextBox txtPrice;
    private Label lblQuantity;
    private TextBox txtQuantity;
    private Button btnAdd;
    private FlowLayoutPanel flpSearch;
    private Label lblSearch;
    private TextBox txtSearch;
    private Label lblError;
    private DataGridView dgvProducts;
}
