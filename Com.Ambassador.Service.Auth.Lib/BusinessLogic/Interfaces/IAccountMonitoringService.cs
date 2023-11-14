using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.Ambassador.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IAccountMonitoringService
    {
        MemoryStream GetExcel(int userId, string menu);
    }
}
