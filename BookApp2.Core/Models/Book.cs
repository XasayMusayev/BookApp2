

    using BookApp2.Core.Models.BaseModel;
namespace BookApp2.Core.Models
{

public class Book:BaseModel.BaseModel
    {
        private string _name;
        public string Name { get => _name; set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("Name is not included");
                    Name = Console.ReadLine();
                }
                _name = value;
                    
               
                 
            } }

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value<=0)
                {
                    
                    Console.WriteLine("Price is not true");
                    Price = double.Parse(Console.ReadLine());

                }

                _price = value;

            }
        }
    }
}
