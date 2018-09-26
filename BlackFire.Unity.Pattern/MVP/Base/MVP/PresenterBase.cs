/*
--------------------------------------------------
| Copyright © 2008 Mr-Alan. All rights reserved. |
| Website: www.0x69h.com                         |
| Mail: mr.alan.china@gmail.com                  |
| QQ: 835988221                                  |
--------------------------------------------------
*/

namespace BlackFire.Unity.Pattern
{
    /// <summary>
    /// 表示层。
    /// </summary>
    public abstract class PresenterBase : PatternEntityTreeNode
    {
    
        protected internal IView ViewInterface { get; set; }
        protected internal IModel ModelInterface { get; set; }
      
    }
}