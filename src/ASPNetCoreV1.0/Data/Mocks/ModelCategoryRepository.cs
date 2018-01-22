using ASPNetCoreV1.Data.Interfaces;
using ASPNetCoreV1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreV1.Data.Mocks
{
    public class ModelCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alkoholowe", Description = "Opis dla alkoholowych." },
                    new Category { CategoryName="Bezalkoholowe", Description="Opis dla bezalkoholowych"}
                };
            }
        }
    }
}
