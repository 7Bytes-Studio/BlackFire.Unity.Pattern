/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using System;
using System.Collections.Generic;

namespace BlackFire.Unity.Pattern
{
    internal sealed class VPEntry
    {
        internal Type View;
        internal IEnumerable<Type> Presenters;
    }
    
    internal sealed class MPEntry
    {
        internal Type Model;
        internal IEnumerable<Type> Presenters;   
    }
}