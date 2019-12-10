﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartSchool.Customization.Data;
using System.IO;
using FISCA.DSAUtil;
using FISCA.Data;
using System.Data;
using Aspose.Cells;
using FISCA.Presentation.Controls;
using System.Windows.Forms;
using K12.Data;

namespace 班級點名單_套表列印
{
    public class Program
    {
        [FISCA.MainMethod]
        public static void Main()
        {
            FISCA.Presentation.MenuButton btn = FISCA.Presentation.MotherForm.RibbonBarItems["班級", "資料統計"]["報表"]["學籍相關報表"];
            btn["班級點名單(名條樣式) For Docx"].Enable = Permissions.班級點名單_週報表樣式權限;
            btn["班級點名單(名條樣式) For Docx"].Click += delegate
            {
                new Form1().ShowDialog();
            };
            FISCA.Permission.Catalog TestCatalog = FISCA.Permission.RoleAclSource.Instance["班級"]["報表"];
            TestCatalog.Add(new FISCA.Permission.RibbonFeature(Permissions.班級點名單_週報表樣式, "班級點名單(名條樣式) For Docx"));
        }
    }
}
