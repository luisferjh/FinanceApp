﻿using FinanceApp.Repository.Interfaces.Actions;
using FinanceApp.Web.Models.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.Expenses
{
    public interface IOperationService: IReadRepository<OperationViewModel, int>, 
                                      ICreateRepository<AddOperationVwModel>,
                                      IUpdateRepository<UpdateOperationVwModel>,
                                      IRemoveRepository<DeleteOperationVwModel, int> 
    {

    }
}
