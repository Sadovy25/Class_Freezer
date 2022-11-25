using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Color
    {Red, Green, Blue, White, Gray, No_color}
    class Freezer
    {
        public Freezer()
        {
            _Engine_Power = 0;
            _NAME = null;
            _Color = Color.No_color;
            _price = 0;
            this.description = null;
        }
        public Freezer(int engine_Power, string nAME, Color color,  int price, string description=null)
        {
            _Engine_Power = engine_Power;
            _NAME = nAME;
            _Color = color;
             _price = price;
            this.description = description;
        }

        static Freezer()
        {
            var config = new Configuration();
            _stock_availability =config._stock;
            _weight_of_packing = config._weigth;
        }
        public int _Engine_Power { get; set; }
        public string _NAME { get; set; }
        public Color _Color { get; set; }
        private Guid id = Guid.NewGuid();
        public int _price { get; set; }
        private string description = null;
        public static bool _stock_availability { get; set; }
        public static double _weight_of_packing { get; set; }
        public override string ToString()
        {
            string info = "";
            info = ($"\t\t==FREEZER==\nName: {_NAME}"+".\n"+id+"\nEngine power: "+_Engine_Power+" watt.\nColor: "+_Color+".\nPrice: "+_price+" UAH."+
                "\nStock availability: "+_stock_availability+".\nWeigth of packing: "+_weight_of_packing+"kg.");
            if (description != null)
                info += "\nDescription: \n"+description+".";
            info += "\n************************************";
            return info;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
       public void Description(in string des)
        {
            this.description = des;
        }
    }


    class Configuration
    {
        public double _weigth { get; set; } = 1.8;
        public bool _stock { get; set; } = true;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Freezer fr=new Freezer();
            fr._Engine_Power=1200;
            fr._NAME=("Wirlpool");
            fr._price = 399;
            fr._Color = Color.White;
            fr.Description("Only at Best BuyInsignia™ Chest Freezer: Store frozen items that don't fit \nin your refrigerator with this freezer," +
                " which features a 10.2 cu. ft. capacity \nto accommodate plenty of frozen foods. \nA removable storage basket offers easy access to smaller items.");
            //fr.Print();

            Freezer fr1= new Freezer(1900, "Wirlpool", Color.Green, 999);
            //fr1.Print();

            var fr2 = new Freezer();
            //fr2.Print();
            var fr_arr = new Freezer[5];
           
            fr_arr[0] = fr;
            fr_arr [1] = fr1;
            fr_arr[2] = fr2;
            //foreach (var item in fr_arr) //памяті виділено на 5, а є 3. з цікавості
            //{
            //    item.Print();
            //}
            for (int i = 0; i < fr_arr.Length; i++)
            {
                if (fr_arr[i] == null)
                    continue;
                fr_arr[i].Print();
            }
        }
    }
}
