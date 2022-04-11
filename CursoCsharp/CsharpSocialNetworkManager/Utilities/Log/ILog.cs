using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSocialNetworkManager.Utilities.Log
{
    public interface ILog<T>
    {
        void SaveLog(T action);
    }
}
