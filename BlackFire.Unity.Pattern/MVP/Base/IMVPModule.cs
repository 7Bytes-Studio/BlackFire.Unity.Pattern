/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace BlackFire.Unity.Pattern
{
    public interface IMVPModule:IModule
    {

        void BindVP(Type view,IEnumerable<Type> presenters);
        
        void BindMP(Type model,IEnumerable<Type> presenters);
        
        void UnBind(Type viewOrmodel);

        ModelBase AcquireModel(Type model);
        ViewBase AcquireView(Type view);
        PresenterBase AcquirePresenter(Type presenter);
    }
}