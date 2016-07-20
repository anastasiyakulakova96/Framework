﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Element
{
    public interface TextBox : Element
    {
        void Type(String text);

        void Clear();

        void ClearAndType(String text);
    }
}
