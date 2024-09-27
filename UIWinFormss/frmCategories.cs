using DataAccess.Interfaces;

namespace UIWinFormss;

public partial class frmCategories : Form
{
    private readonly NorthwindEfCoreContext context;
    private readonly IDalCategory dalCategory;

    public frmCategories()
    {
        InitializeComponent();
        context = new();
        dalCategory = new DalCategory(context = new());
    }

    private void frmCategories_Load(object sender, EventArgs e)
    {
        dgwCategories.DataSource = dalCategory.GetAll().ToList();
        dgwCategories.AutoResizeRows();
    }
}