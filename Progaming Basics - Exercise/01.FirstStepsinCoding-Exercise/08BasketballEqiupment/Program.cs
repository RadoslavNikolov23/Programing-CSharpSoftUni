﻿int yearTax = int.Parse(Console.ReadLine());


double priceSnikers = yearTax - (yearTax * 0.40);
double priceOutfit = priceSnikers -(priceSnikers * 0.20);
double priceBall = priceOutfit / 4;
double priceAccessories = priceBall / 5;


double finalTax = priceBall + priceAccessories + priceOutfit + priceSnikers + yearTax;

Console.WriteLine(finalTax);
//Джеси решава, че иска да се занимава с баскетбол, но за да тренира е нужна екипировка. 
//   Напишете програма, която изчислява какви разходи ще има Джеси, ако започне да тренира, 
//   като знаете колко е таксата за тренировки по баскетбол за период от 1 година. 
   
//   Нужна екипировка: 
//•	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
//•	Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
//•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
//•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

//Изход
//Да се отпечата на конзолата колко ще са разходите на Джеси, ако започне да спортува баскетбол.

