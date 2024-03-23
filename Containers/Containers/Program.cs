
using System.Collections;

LiquidContainer waterContainer1 = new LiquidContainer(10,50,45,50,true);
LiquidContainer waterContainer2 = new LiquidContainer(15,60,55,70,false);

GasContainer heliumContainer = new GasContainer(10,50,45,50,3000);
CoolingContainer bananaContainer = new CoolingContainer();

waterContainer1.addCargo(30);
waterContainer2.addCargo(40);

heliumContainer.addCargo(20);

waterContainer1.getInfo();
waterContainer2.getInfo();
heliumContainer.getInfo();

waterContainer2.removeCargo();