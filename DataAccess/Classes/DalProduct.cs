using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Entities.Context;
using Entities.Models;

namespace DataAccess.Classes;

    public class DalProduct : EntityRepo<Product>, IDalProduct
    {
        public DalProduct(NorthwindEfCoreContext p_context) : base(p_context)
        {
        }
    }

