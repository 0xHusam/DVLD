using Business.GlobalData;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ModelsManger
{
    public static class clsManagerHelper
    {
        public static eResult Operation<T>(T Entity, Func<T, eResult> operation, Action<T> RowOperation)
        {
            eResult result = operation(Entity);

            if (result == eResult.Success)
                RowOperation(Entity);

            return result;
        }
    }
}
