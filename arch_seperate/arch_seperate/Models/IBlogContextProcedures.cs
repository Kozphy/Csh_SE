﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using arch_seperate.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace arch_seperate.Models
{
    public partial interface IBlogContextProcedures
    {
        Task<int> resetTableIdentiyAsync(string table, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
