﻿using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace DataAccess.Classes;

public class DalVwProdCatSup : EntityRepo<VwProdCatSup>, IDalVwProdCatSup
{
    public DalVwProdCatSup(NorthwindEfCoreContext p_context) 
                               : base(p_context)
    {
    }
}