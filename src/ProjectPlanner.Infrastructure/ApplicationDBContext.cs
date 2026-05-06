using Microsoft.EntityFrameworkCore;
using ProjectPlanner.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Infrastructure
{
    public sealed class ApplicationDBContext : DbContext , IUnitOfWork
    {
    }
}


