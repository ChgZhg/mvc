﻿using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc.IDAL
{
    public partial interface ISysModuleRepository
    {
        IQueryable<SysModule> GetModuleBySystem(DBContainer db, string parentId);
    }
}
