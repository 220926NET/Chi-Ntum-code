/*variables
-engine
-color
-name
-model
-mileage
-brand

method
-air conditioner
    -set temperature
-radio
    -set station
    -set volume
-gps
    -set location/destination

-price of car

*/
class Car{
private string? engine {get; set;}
private string? color {get; set;}
private string? model {get; set;}
private double? mileage {get; set;}
private string? brand {get; set;}

public Car(){}
public Car (string? engine, string? color, string? name,double? mileage, string? brand){
    this.engine = engine;
    this.color = color;
    this.model = model;
    this.mileage = mileage;
    this.brand = brand;
}

public void airConditioner(string temp){

}
public string radio(double radioStation, int volume){
    return "You set the station to " + radioStation + " and the volume to " + volume;
}

public string gps(string currentAddress, string destination){
    return "Your destination is " + destination;
}

public int price(Car carType){
    if (carType.color != null){
        if (carType.color.Equals("yellow", StringComparison.OrdinalIgnoreCase)){
            return 1500;
        }else if (carType.color.Equals("red", StringComparison.OrdinalIgnoreCase)){
            return 1700;
        }else if (carType.color.Equals("blue", StringComparison.OrdinalIgnoreCase)){
            return 1900;
        }else{
            return 1600;
        }
    }else {
        return 1600;
    }
}

}
