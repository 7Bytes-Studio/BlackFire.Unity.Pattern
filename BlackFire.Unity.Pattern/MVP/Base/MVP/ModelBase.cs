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
    /// 模型层。
    /// </summary>
    public abstract class ModelBase : PatternEntityTreeNode
    {
        /// <summary>
        /// 模型层接口。
        /// </summary>
        protected internal abstract IModel ModelInterface{ get; }
    }
}