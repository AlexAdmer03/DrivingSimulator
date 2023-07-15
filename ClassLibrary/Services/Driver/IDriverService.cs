using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Driver
{
    public interface IDriverService
    {
        void Rest();
        bool CheckIfDriverIsTooTired();

    }
}
