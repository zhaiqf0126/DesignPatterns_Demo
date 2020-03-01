using System;
using System.Collections.Generic;
using System.Text;

namespace DesignMethod
{
    public class StartDesign
    {
        public void Start()
        {
            #region 创建型设计模式

            //单例
            OpenDesign design = new SinglePattern.Program();
            design.Open();

            //简单工厂
            //OpenDesign design = new SimpleFactoryPattern.Program();
            //design.Open();

            //工厂方法
            //OpenDesign design = new FactoryMethodPattern.Program();
            //design.Open();

            //抽象工厂
            //OpenDesign design = new AbstractFacoryPattern.Program();
            //design.Open();

            #endregion

            #region 结构型设计模式

            //桥接模式
            //OpenDesign design = new BridgePattern.Program();
            //design.Open();

            //组合模式
            //OpenDesign design = new CompositePattern.Program();
            //design.Open();

            #endregion

            #region 行为型设计模式

            //模板方法
            //OpenDesign design = new TemplateMethodPattern.Program();
            //design.Open();

            //迭代器模式
            //OpenDesign design = new IteratorPattern.Program();
            //design.Open();

            //访问者模式
            //OpenDesign design = new VisitorPattern.Program();
            //design.Open();

            //观察者
            //OpenDesign design = new OberverPattern.Program();
            //design.Open();

            #endregion
        }
    }
}
