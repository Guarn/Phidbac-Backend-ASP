using Phidbac.Domain.Interfaces;
using Phidbac.Domain.Models;
using Phidbac.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phidbac.Domain.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(PhidbacDBContext context) : base(context) { }
    }
}
