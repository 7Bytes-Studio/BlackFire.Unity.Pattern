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
    /// <summary>
    /// 显示层。
    /// </summary>
    public abstract class ViewBase : PatternEntityTreeNode
    {
       
        internal List<Type> PresenterTypeList=new List<Type>();

        /// <summary>
        /// 显示层曝露出来的接口，用于显示层的数据设置（一般单向设置）。
        /// </summary>
        protected internal abstract IView ViewInterface { get; }

        /// <summary>
        /// 发出事件。
        /// </summary>
        /// <param name="fireCallback">事件执行回调。</param>
        /// <typeparam name="T">事件接口类型。</typeparam>
        protected void Fire<T>(Action<T> fireCallback) where T : IViewEventHandler
        {
            var module = Parrent as IMVPModule;
            
            for (int i = 0; i < PresenterTypeList.Count; i++)
            {
                var presenter = module.AcquirePresenter(PresenterTypeList[i]);
                
                if (null!=presenter && presenter is T && null!=fireCallback )
                {
                    fireCallback.Invoke((T)(object)presenter);
                    return;
                }
            }
        }


        
    }
}