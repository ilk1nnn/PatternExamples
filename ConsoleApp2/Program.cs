using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    // ---------------------------------------------------------------------

    interface IVehicle
    {
        void deliver();
    }


    class Truck : IVehicle
    {
        public void deliver()
        {
            Console.WriteLine("I deliver all goods by road");
        }
    }


    class Ship : IVehicle
    {
        public void deliver()
        {
            Console.WriteLine("I deliver all goods by sea");
        }
    }


    abstract class Logistic
    {
        public abstract IVehicle CreateTransport();
    }


    class RoadLogistic : Logistic
    {
        public override IVehicle CreateTransport()
        {
            return new Truck();
        }
    }


    class SeaLogistic : Logistic
    {
        public override IVehicle CreateTransport()
        {
            return new Ship();
        }
    }

    // ---------------------------------------------------------------------


    interface IChair
    {
        bool HasLegs();
        bool SitOn();
    }


    class ArtDecoChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public bool SitOn()
        {
            return true;
        }
    }


    class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return false;
        }

        public bool SitOn()
        {
            return true;
        }
    }


    class VictorianChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public bool SitOn()
        {
            return true;
        }
    }


    interface ITable
    {
        bool CanOpen();
        bool CanRotate();
    }


    class ArtDecoTable : ITable
    {
        public bool CanOpen()
        {
            return true;
        }

        public bool CanRotate()
        {
            return true;
        }
    }


    class ModernTable : ITable
    {
        public bool CanOpen()
        {
            return false;
        }

        public bool CanRotate()
        {
            return true;
        }
    }


    class VictorianTable : ITable
    {
        public bool CanOpen()
        {
            return false;
        }

        public bool CanRotate()
        {
            return false;
        }
    }



    interface ISofa
    {
        bool CanEnlarge();
    }


    class ArtDecoSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }


    class VictorianSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return false;
        }
    }


    class ModernSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }


    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa(); 
        ITable CreateTable();
        void Show();
    }


    class ModernFurniture : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }

        public void Show()
        {
            Console.WriteLine("Modern Style");
            var chair = CreateChair();
            var table = CreateTable();
            var sofa = CreateSofa();
        }

    }


    class VictorianFurniture : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }

        public void Show()
        {
            Console.WriteLine("Victorian Style");
            var chair = CreateChair();
            var table = CreateTable();
            var sofa = CreateSofa();
        }

    }


    class ArtDecoFurniture : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ITable CreateTable()
        {
            return new ArtDecoTable();
        }

        public void Show()
        {
            Console.WriteLine("ArtDeco Style");
            var chair = CreateChair();
            var table = CreateTable();
            var sofa = CreateSofa();
        }

    }


    // ---------------------------------------------------------------------


    // Task





    abstract class Button
    {
        public abstract void Show();
    }


    abstract class CheckBox
    {
        public abstract void Show();
    }


    class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public CheckBox CreateCheckbox()
        {
            return new WinCheckBox();
        }
    }

    class WinButton : Button
    {
        public override void Show()
        {
            Console.WriteLine("I am WinButton");
        }
    }


    class WinCheckBox : CheckBox
    {
        public override void Show()
        {
            Console.WriteLine("I am WinCheckBox");
        }
    }


    interface GUIFactory
    {
        Button CreateButton();
        CheckBox CreateCheckbox();
    }



    class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public CheckBox CreateCheckbox()
        {
            return new MacChecBox();
        }
    }


    class MacButton : Button
    {
        public override void Show()
        {
            Console.WriteLine("I am MacButton");
        }
    }


    class MacChecBox : CheckBox
    {
        public override void Show()
        {
            Console.WriteLine("I am MacCheckBox");
        }
    }


    class Application
    {
        private GUIFactory _factory;

        public Application(GUIFactory factory)
        {
            _factory = factory;
        }

        public void CreateUI()
        {
            _factory.CreateButton().Show();
            _factory.CreateCheckbox().Show();
        }

    }



    // ---------------------------------------------------------------------



    class SingleTon
    {

    }


    public class Program
    {
        static void Main(string[] args)
        {


            //Logistic logistic;
            //Console.WriteLine("By Road Select 1");
            //Console.WriteLine("By Sea Select 2");
            //Console.WriteLine();
            //int select = int.Parse(Console.ReadLine());
            //if(select == 1)
            //{
            //    logistic = new RoadLogistic();
            //}
            //else
            //{
            //    logistic = new SeaLogistic();
            //}
            //var vehicle = logistic.CreateTransport();
            //vehicle.deliver();


            //IFurnitureFactory furnitureFactory = new VictorianFurniture();
            //furnitureFactory.Show();






            //Application application = new Application(new WinFactory());
            //application.CreateUI();




        }
    }
}
