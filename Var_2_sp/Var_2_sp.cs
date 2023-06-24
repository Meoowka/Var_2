using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Var_2_sp
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Var_2_sp" в коде и файле конфигурации.
    public class Var_2_sp : IVar_2_sp
    {
        public string GetMessage(string name)
        {
            return "Hello" + name;
        }
    }
}
