using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{

    public interface IContinentFactory
    {
        IProductA CreateProductA(int id, string name, int cost, string color);

        IProductB CreateProductB(int id, string name, int cost, string weight);
    }
    public interface IProduct
    {
        int GetCost();

    }
    public interface IProductA : IProduct
    {
       
    }

    public interface IProductB : IProduct
    {
       
    }

    //На основании абстрактного класса или интерфейса строятся один или несколько
    //конкретных классов фабрик, создающих конкретные объекты-продукты
    public class Type1 : IContinentFactory
    {
        public IProductA CreateProductA(int id, string name, int cost, string color)
        {
            return new ProductA1(id,name,cost,color);
        }

        public IProductB CreateProductB(int id, string name, int cost, string weigth)
        {
            return new ProductB1(id, name, cost, weigth);
        }
    }

    public class Type2 : IContinentFactory
    {
        public IProductA CreateProductA(int id, string name, int cost, string color)
        {
            return new ProductA2(id, name, cost, color);
        }

        public IProductB CreateProductB(int id, string name, int cost, string color)
        {
            return new ProductB2(id, name, cost, color);
        }
    }


    internal class ProductA1 : IProductA
    {
        
        private int id;
        private string name;
        private int cost;
        private string color;
        public ProductA1(int id, string name, int cost, string color)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.color = color;

        }
        public override string ToString()
        {
            return ($"{this.id}, Name:{this.name}, Cost:{this.cost},Color:{this.color}");
        }
        public int GetCost()
        {
            return this.cost;
        }
    }

    internal class ProductB1 : IProductB
    {
    
        private int id;
        private string name;
        private int cost;
        private string weight;
        public ProductB1(int id, string name, int cost, string weight)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.weight = weight;

        }
        public override string ToString()
        {
            return ($"{this.id}, Name:{this.name}, Cost:{this.cost},Weight:{this.weight}");
        }
        public int GetCost()
        {
            return this.cost;
        }
    }

    internal class ProductA2 : IProductA
    {
        private int id;
        private string name;
        private int cost;
        private string color;
        public ProductA2 (int id, string name, int cost, string color)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.color = color;

        }
        public override string ToString()
        {
            return ($"{this.id}, Name:{this.name}, Cost:{this.cost},Color:{this.color}");
        }
        public int GetCost()
        {
            return this.cost;
        }
    }

    internal class ProductB2 : IProductB
    {
        private int id;
        private string name;
        private int cost;
        private string weight;
        public ProductB2(int id, string name, int cost, string weight)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.weight = weight;

        }
        public override string ToString()
        {
            return ($"{this.id}, Name:{this.name}, Cost:{this.cost},Weight:{this.weight}");
        }
        public int GetCost()
        {
            return this.cost;
        }
    }


}
