 #include <SHT1x.h>
 #define dataPin 10
 #define clockPin 11
 SHT1x sht1x(dataPin, clockPin);
 float temp_c;
 void setup()
 {
 Serial.begin(9600);
 }
 void loop()
 {
  temp_c = sht1x.readTemperatureC();

 Serial.println(temp_c);

 delay(50);
}
