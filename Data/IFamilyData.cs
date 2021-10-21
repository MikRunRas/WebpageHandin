using System.Collections.Generic;
using Models;

namespace WebApplication.Data
{
    public interface IFamilyData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int Id);
        void Update(Adult adult);
        Person Get(int Id);
    }
}