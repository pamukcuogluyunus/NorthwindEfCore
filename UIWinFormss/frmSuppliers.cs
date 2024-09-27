using DataAccess.Interfaces;

namespace UIWinFormss;

public partial class frmSuppliers : Form
{
    private readonly NorthwindEfCoreContext context;
    private readonly IDalSupplier dalSupplier;
    public frmSuppliers()
    {
        InitializeComponent();
        dalSupplier = new DalSupplier(context = new());
    }

    private void frmSuppliers_Load(object sender, EventArgs e)
    {
        dgwSuppliers.DataSource = dalSupplier.GetAll().ToList();
        dgwSuppliers.AutoResizeRows();
    }
}