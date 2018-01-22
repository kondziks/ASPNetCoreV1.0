using ASPNetCoreV1.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace ASPNetCoreV1.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;  }
        IEnumerable<Drink> PrefferedDrinks { get;  }

        Drink getDrinkById(int Id);

    }
}