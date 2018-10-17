#include <ESP8266WiFi.h>
#include <ThingerESP8266.h>

#define USERNAME "abhey"
#define DEVICE_ID "NodeMCU"
#define DEVICE_CREDENTIAL "some_credential"

#define SSID "abhey"
#define SSID_PASSWORD "12345678"

ThingerESP8266 thing(USERNAME, DEVICE_ID, DEVICE_CREDENTIAL);

void setup() {
  // put your setup code here, to run once:
  thing.add_wifi(SSID, SSID_PASSWORD);
  pinMode(D1,OUTPUT);
  pinMode(D2,OUTPUT);
  pinMode(D5,OUTPUT);
  pinMode(D6,OUTPUT);
//  Serial.begin(9600);
}
float voltage1(){
digitalWrite(D1,HIGH);
int x=analogRead(A0);
digitalWrite(D1,LOW);
//delay(100);  
float v = x * (20 / 1023.0);
return v;
}
float voltage2(){
digitalWrite(D2,HIGH);
int x=analogRead(A0);
digitalWrite(D2,LOW);
//delay(100);  
float v = x * (20 / 1023.0);
return v;
}
float voltage3(){
digitalWrite(D5,HIGH);
int x=analogRead(A0);
digitalWrite(D5,LOW);
//delay(100);  
float v = x * (150 / 1023.0);
return v;
}
float voltage4(){
digitalWrite(D6,HIGH);
int x=analogRead(A0);
digitalWrite(D6,LOW);
//delay(100);  
float v = x * (150 / 1023.0);
return v;
}
void loop() {
    thing.handle();
  // put your main code here, to run repeatedly:
  thing["Flow"] >> [](pson& out){
      out["F1"] = voltage1();
      out["F2"] = voltage2();
      out["F3"] = voltage3();
      out["F4"] = voltage4();
  };
  thing.handle();
  //Serial.print(v1);
  //Serial.print("\t");
 // Serial.print(v2);
   //Serial.print("\t");
   //Serial.print(v3);
    //Serial.print("\t");
    //Serial.print(v4);
  //Serial.print("\n");
}
