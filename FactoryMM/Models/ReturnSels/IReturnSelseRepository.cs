using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ReturnSels
{
    public interface IReturnSelseRepository
    {
        ReturnSelse GetReturnSelse(int Id);

        IEnumerable<ReturnSelse> GetAllReturnSelse();

        ReturnSelse Add(ReturnSelse sales);

        ReturnSelse Update(ReturnSelse ReturnSelseChanges);


        ReturnSelse Delete(int id);
    }
}
