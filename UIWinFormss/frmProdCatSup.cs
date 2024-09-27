using DataAccess.Interfaces;
using Microsoft.Identity.Client;

namespace UIWinFormss;

public partial class frmProdCatSup : Form
{
    private readonly NorthwindEfCoreContext context;
    private readonly IDalVwProdCatSup dalVwProdCatSup;
    public frmProdCatSup()
    {
        InitializeComponent();
        dalVwProdCatSup = new DalVwProdCatSup(context = new ());
    }

    private void frmProdCatSup_Load(object sender, EventArgs e)
    {
        dgwProdCatSup.DataSource = dalVwProdCatSup.GetAll().ToList();
        dgwProdCatSup.AutoResizeRows();
    }
}
