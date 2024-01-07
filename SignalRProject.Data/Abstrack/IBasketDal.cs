﻿using SignalRProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.Data.Abstrack
{
    public interface IBasketDal:IGenericDal<Basket>
    {
        List<Basket> GetBasketByTableNumber(int id);
    }
}
