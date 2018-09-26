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
    /// 用于BlackFireFramework.Pattern程序集的公共EntityTreeNode。
    /// </summary>
    public abstract class PatternEntityTreeNode:EntityTreeNode
    {
        protected PatternEntityTreeNode() : base(null)
        {
            
        }
        
        
        protected override void OnBorn()
        {
            OnInit();
        }

        protected override void OnAct()
        {
            OnUpdate();
        }

        protected override void OnDie()
        {
            OnDestroy();
        }

        
        protected abstract void OnInit();

        protected abstract void OnUpdate();

        protected abstract void OnDestroy();
        
    }
}