using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 班級點名單_套表列印
{
    class Permissions
    {
        public static string 班級點名單_週報表樣式 { get { return "K12.Class.Report.點名單.週報表樣式"; } }
        public static bool 班級點名單_週報表樣式權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[班級點名單_週報表樣式].Executable;
            }
        }
    }
}
