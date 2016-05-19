using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMVC.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LearnMVCDbContext dbContext;

        public LearnMVCDbContext Init()
        {
            return dbContext ?? (dbContext = new LearnMVCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
