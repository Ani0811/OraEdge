﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraEdge.Code
{
    public interface IOraSingleton
    {
        void Initialize_Form(string argClassName, TabControl argTarget_TabCtrl);
        void Initialize_Form(string argClassName, Panel argPanel,
                                        DataGridView argGridView);
    }
}
