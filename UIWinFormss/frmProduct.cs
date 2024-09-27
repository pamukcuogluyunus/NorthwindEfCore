using static System.Convert;
using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace UIWinFormss;

public partial class frmProduct : Form
{
    private readonly NorthwindEfCoreContext context;
    private readonly IDalCategory dalCategory;
    private readonly IDalProduct dalProduct;
    private readonly IDalSupplier dalSupplier;
    private readonly IDalDtoProductCatName dalPrdCatName;
    private readonly IDalCustomer dalCustomer;
    private readonly IDalEmployee dalEmployee;
    private readonly IDalOrder dalOrder;
    private readonly IDalRegion dalRegion;
    private readonly IDalShipper dalShipper;
    private readonly IDalTerritory dalTerritory;


    public frmProduct()
    {

        context = new();
        dalProduct = new DalProduct(context);
        dalCategory = new DalCategory(context);
        dalSupplier = new DalSupplier(context);
        dalCustomer = new DalCustomer(context);

        dalPrdCatName = new DalDtoProductCatName(context);
        InitializeComponent();
    }

    private void frmProduct_Load(object sender, EventArgs e)
    {
        dgwProducts.DataSource = ProductIncludeData().ToList();
        dgwFormat(dgwProducts);
        dgwProductCatName.DataSource = dalPrdCatName.GetProductsCatName(0).ToList();
        dgwFormat(dgwProductCatName);
        CmbCatLoad();
        CmbSupLoad();
    }

    private IQueryable<Product> ProductIncludeData()

        => dalProduct.GetAll().Include(x => x.Category).Include(x => x.Supplier);
    //Entities.Models.Category
    private void CmbCatLoad()
    {
        comboBox1.DataSource = dalCategory.GetAll().ToList();
        comboBox3.DataSource = dalCategory.GetAll().ToList();
        comboBox3.DisplayMember = nameof(Category.CategoryName);
        comboBox1.DisplayMember = nameof(Category.CategoryName);
        comboBox3.ValueMember = nameof(Category.CategoryId);
        comboBox1.ValueMember = nameof(Category.CategoryId);


    }

    private void CmbSupLoad()
    {
        comboBox2.DataSource = dalSupplier.GetAll().ToList();
        comboBox2.DisplayMember = nameof(Supplier.CompanyName);
        comboBox2.ValueMember = nameof(Supplier.SupplierId);
    }


    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var frmOpen = new frmCategories();
        frmOpen.ShowDialog();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        var frmOpen = new frmSuppliers();
        frmOpen.ShowDialog();
    }

    private void button8_Click(object sender, EventArgs e)
    {
        var frmOpen = new frmProdCatSup();
        frmOpen.ShowDialog();
    }

    public void dgwFormat(DataGridView dgw)
    {
        int SatirNo = 1;
        foreach (DataGridViewRow item in dgw.Rows)
        {
            item.HeaderCell.Value = SatirNo.ToString();
            SatirNo++;
            if (SatirNo > 500) break;

        }
        dgw.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader);
        dgw.RowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
        dgw.EditMode = DataGridViewEditMode.EditProgrammatically;
        dgw.AllowUserToDeleteRows = false;
        dgw.AllowUserToAddRows = false;
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var cmb = sender as ComboBox;
        var isCatID = int.TryParse(cmb.SelectedValue.ToString(), out var catID);
        if (isCatID == true)

            dgwProducts.DataSource =
                dalPrdCatName.GetProductsByCategory(catID).ToList();

    }

    private int satir = 0;
    private void button2_Click(object sender, EventArgs e)
    {
        satir = dgwProducts.CurrentRow.Cells[0].RowIndex > 1
            ? dgwProducts.CurrentRow.Cells[0].RowIndex
            : dgwProducts.RowCount - 1;
        dgwProducts.DataSource = ProductIncludeData().ToList();
        dgwFormat(dgwProducts);
        textBox1.Clear();
        dgwProducts.CurrentCell = dgwProducts.Rows[satir].Cells[1];
    }

    private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        GridToControl(sender);
    }

    private void GridToControl(object sender)
    {
        var row = (sender as DataGridView).CurrentRow;
        textBox2.Text = row.Cells[0].Value.ToString();
        textBox3.Text = row.Cells[1].Value.ToString();
        comboBox2.SelectedValue = row.Cells[2].Value;
        comboBox3.SelectedValue = row.Cells[3].Value;
        textBox4.Text = row.Cells[4].Value.ToString();
        textBox5.Text = row.Cells[5].Value.ToString();
        textBox6.Text = row.Cells[6].Value.ToString();
        textBox7.Text = row.Cells[7].Value.ToString();
        textBox8.Text = row.Cells[8].Value.ToString();
        radioButton1.Checked = ToBoolean(row.Cells[9].Value);

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (sender is TextBox { TextLength: > 1 } txt)
            dgwProducts.DataSource = string.IsNullOrWhiteSpace(txt.Text)
                ? ProductIncludeData().ToList()
               : ProductIncludeData().Where(x => x.ProductName
                .Contains(textBox1.Text)).ToList();
    }

    private void button3_Click(object sender, EventArgs e)
        => textBox2.Text = "";

    private async void button4_Click(object sender, EventArgs e)
    {
        try
        {
            var prd = new Product
            {
                ProductName = textBox3.Text,
                SupplierId = ToInt32(comboBox2.SelectedValue),
                CategoryId = ToInt32(comboBox3.SelectedValue),
                QuantityPerUnit = textBox4.Text,
                UnitPrice = ToDecimal(textBox5.Text),
                UnitsInStock = ToInt16(textBox6.Text),
                UnitsOnOrder = ToInt16(textBox7.Text),
                ReorderLevel = ToInt16(textBox8.Text),
                Discontinued = radioButton1.Checked
            };

            await CUDEntity(CUDtype.Insert, prd);
            dgwFormat(dgwProducts);
            MessageBox.Show($"{nameof(Product)} eklendi");
            button2_Click(null, null); // DataGridView'i yenile
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ürün eklerken hata: {ex.Message}");
        }
    }


    private async Task CUDEntity(CUDtype cruType, Product prd)
    {
        prd.ProductId = cruType == CUDtype.Insert ? 0
            : ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
        prd.ProductName = textBox3.Text;
        prd.SupplierId = ToInt32(comboBox2.SelectedValue);
        prd.CategoryId = ToInt32(comboBox3.SelectedValue);
        prd.QuantityPerUnit = textBox4.Text;
        prd.UnitPrice = ToDecimal(textBox5.Text);
        prd.UnitsInStock = ToInt16(textBox6.Text);
        prd.UnitsOnOrder = ToInt16(textBox7.Text);
        prd.ReorderLevel = ToInt16(textBox8.Text);
        prd.Discontinued = radioButton1.Checked;
        switch (cruType)
        {
            case CUDtype.Insert:
                await dalProduct.AddAsync(prd);
                break;
            case CUDtype.Update:
                await dalProduct.Update(prd);
                break;
            case CUDtype.Delete:
                await dalProduct.Remove(prd);
                break;
            default:
                break;
        }
    }

    private async void button5_Click(object sender, EventArgs e)
    {
        var prd = new Product();
        await CUDEntity(CUDtype.Update, prd);
        dgwFormat(dgwProducts);
        MessageBox.Show($"{nameof(Product)} modified");
        button2_Click(null, null);

    }

    private async void button6_Click(object sender, EventArgs e)
    {
        var prd = new Product();
        await CUDEntity(CUDtype.Delete, prd);
        dgwFormat(dgwProducts);
        MessageBox.Show($"{nameof(Product)} deleted");
        satir--;
        button2_Click(null, null);
    }

    //private void button4_MouseMove(object sender, MouseEventArgs e) //Ekle
    //    => CUDControl(sender);

    //private void button5_MouseMove(object sender, MouseEventArgs e)//güncelle
    //    => CUDControl(sender);

    //private void button6_MouseMove(object sender, MouseEventArgs e)//sil
    //   => CUDControl(sender);

    private void button4_MouseEnter(object sender, EventArgs e)//Ekle
        => CUDControl(sender);

    private void button5_MouseEnter(object sender, EventArgs e)//Güncelle
        => CUDControl(sender);

    private void button6_MouseEnter(object sender, EventArgs e)//Sil
        => CUDControl(sender);

    private void CUDControl(object sender)
    {
        var button = (Button)sender;
        if (button == null || context == null) return;
        
        button3.Enabled = true;
        button4.Enabled = true;
        button5.Enabled = true;
        button6.Enabled = true;
        if (textBox2.Text != "" && button == button4)
        {
            MessageBox.Show($"""
                             Bu ürün zaten mevcuttur, ancak
                             güncelleme veya silme iþlemi yapabilirsiniz ?
                             """);
        }else if(textBox2.Text == "" && button != button4)

        {
            string delUp = button == button6 ? "Sil" : "Güncelle";
            MessageBox.Show($$"""
                             Grid üzerinden bir ürün geçmediniz.
                             Hangi ürün {{delUp}}me iþlemine tabi tutulacak
                             seçmeniz gerekir.
                             """);
        }

    }

    public enum CUDtype
    {
        Insert, Update, Delete
    }
}
