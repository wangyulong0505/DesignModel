﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 策略模式就是定义一个类，通过构造方法传入策略，然后执行对应策略的方法
    /// 具体执行的策略由对应的具体类实现
    /// </summary>
    public class StrategyContext
    {
        //定义
        private SuperStrategy super;
        public StrategyContext(String type)
        {
            switch (type)
            {
                case "StrategyA":
                    super = new StrategyA();
                    break;
                case "StrategyB":
                    super = new StrategyB();
                    break;
                default:
                    super = null;
                    break;
            }
        }

        //调用
        public void DoSomeThing()
        {
            super.GetStrategy();
        }
    }
}
