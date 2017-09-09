using Euler.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Euler.Business.Problem
{
    public class ProblemData
    {
        private readonly EulerDbContext _context;

        public ProblemData(EulerDbContext context)
        {
            _context = context;
        }
    }
}
