class CarImplementation{

    public static void Main(string[] args){
        Console.WriteLine("Welcome to our car application.\nWe have options for different types of cars, are you looking for a car today?");
        string? answer = Console.ReadLine();
        if (answer != null){
            if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("What kind of car are you looking for givin the following options?\nEngine\nColor\nModel\nMileage\nBrand");
                Console.WriteLine("What is the Engine?");
                string? engine = Console.ReadLine();
                if(engine == null){
                    engine = "None";
                }
                Console.WriteLine("What is the color of your prefered car?");
                string? color = Console.ReadLine();
                if(color == null){
                    color = "None";
                }
                Console.WriteLine("What is the model?");
                string? model = Console.ReadLine();
                if(model == null){
                    model = "None";
                }
                Console.WriteLine("What is the Mileage you're looking for?");
                double mil;
                double? mileage = 0;
                if(double.TryParse(Console.ReadLine(), out mil)){
                mileage = mil;
                }
                Console.WriteLine("What is the Brand?");
                string? brand = Console.ReadLine();
                if(brand == null){
                    brand = "None";
                }
                Car car = new Car(engine, color, model, mileage, brand);

                Console.WriteLine("The price of your car would be: " + car.price(car));

            }else{
                Console.WriteLine("OK, have a nice day!");
            }
        }



    }
}
