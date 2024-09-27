using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace DataAccess.Classes;

public class DalSupplier : EntityRepo<Supplier>, IDalSupplier
{
    public DalSupplier(NorthwindEfCoreContext p_context)
        : base(p_context){ }
}