using ASPNetCoreV1.Data.Models;
using System.Collections.Generic;

namespace ASPNetCoreV1.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}