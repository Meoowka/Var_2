using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Var_2_sp
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IVar_2_sp" в коде и файле конфигурации.
    [ServiceContract]
    public interface IVar_2_sp
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
