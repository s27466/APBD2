
using System.Collections;

LiquidContainer waterContainer1 = new LiquidContainer(10,50,45,50,true);
LiquidContainer waterContainer2 = new LiquidContainer(15,60,55,70,false);

GasContainer heliumContainer = new GasContainer(10,50,45,50,3000);

List<Product> productList = new List<Product>
{
    new Product("Milk", 4),
    new Product("Egg", 2),
    new Product("Beef", 1),
    new Product("Fruit Juice", 5),
    new Product("Cheese", 6),
    new Product("Carrot", 3),
    new Product("Yogurt", 8),
    new Product("Banana", 7),
    new Product("Fish", 0),
    new Product("Ice Cream", -10)
};

CoolingContainer bananaContainer = new CoolingContainer(12,70,60,90,productList,"Banana",7);

waterContainer1.addCargo(30);
waterContainer2.addCargo(40);
bananaContainer.addCargo(80);

heliumContainer.addCargo(20);

waterContainer1.getInfo();
waterContainer2.getInfo();
heliumContainer.getInfo();
bananaContainer.getInfo();

waterContainer2.removeCargo();