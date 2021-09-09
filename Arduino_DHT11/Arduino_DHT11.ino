#include <dht.h>
dht DHT;
#define DHT11_PIN 8

void setup(){
  
  Serial.begin(9600);
}

void loop()
{
  String datos = Serial.readStringUntil('\n');
  DHT.read11(DHT11_PIN);

  //TEMPERATURA//
  //Serial.print("Temperatura = ");
  Serial.println(DHT.temperature);
  //Serial.println(" C");
  delay(2000);
}
