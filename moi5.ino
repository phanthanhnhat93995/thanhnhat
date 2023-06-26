#include <OneWire.h>
#include <DallasTemperature.h>
#define ONE_WIRE_BUS 4
#include <PZEM004Tv30.h>
PZEM004Tv30 pzem(10, 9);
OneWire oneWire(ONE_WIRE_BUS);
DallasTemperature sensors(&oneWire);
#define ce 2
#define b2 7
#define t2 8
#define qn 5
#define da 6

int encoder_pin = 3;       
unsigned int rpm;     
int pulses=0;  
unsigned long timeold; 
unsigned int pulsesperturn = 1;
int pulsesold = 0;
float nhietdo_tt;
unsigned long timer;

float dong;
float ap;
float power2;
float temperature;
String Cbatdau;
String gui;
String nhan;
String dieukhien;
String Cketthuc;
String ttdc;
int td;

void counter()
 {    
      pulses++;    
 }

void setup()
{
  Serial.begin(9600);
  sensors.begin();
  pinMode(b2, OUTPUT);
  pinMode(t2, OUTPUT); 
  pinMode(ce, OUTPUT);
  pinMode(qn, OUTPUT);
  pinMode(da, OUTPUT);
  pinMode(encoder_pin, INPUT);
  attachInterrupt(1, counter, RISING);
  rpm = 0;
  timeold = 0;
  pulses = 0;
  delay(10);
  pinMode(ONE_WIRE_BUS, INPUT);
  timer = millis();
  digitalWrite (ce, LOW);
}

float doc_nhietdo()
{
  sensors.requestTemperatures();
  nhietdo_tt = sensors.getTempCByIndex(0);
  return nhietdo_tt;
}

void boctach(String ct)
{
  float voltage = pzem.voltage();
  float current = pzem.current();
  
  dong = current;
  ap = voltage;
  power2= dong*ap*0.8;
  
  Cbatdau = ct.charAt(0);
  gui = ct.charAt(1);
  nhan = ct.charAt(2);
  dieukhien = ct.charAt(3);
  Cketthuc = ct.charAt(4);
  if ( Cbatdau == "@" && Cketthuc == "#")
  {    
    if (gui == "0")
    {
      if (nhan == "2")
      {
        if (dieukhien == "D")
        {        
            digitalWrite(ce, HIGH);
            temperature = doc_nhietdo();
            Serial.println("@20DT" + String(temperature) + "V" + String(ap) + "C" + String(dong) + "S" + String(rpm) + "P" + String(power2) + "I" + String(ttdc) + "#");
            delay(100);
            digitalWrite(ce, LOW);         
        }
        if (dieukhien == "B")
        {
          digitalWrite (b2, HIGH);
          delay(50);
          digitalWrite (b2, LOW);
        }
        if (dieukhien == "T")
        {
          digitalWrite (t2, HIGH);
          delay(50);
          digitalWrite(t2, LOW);
        }      
      }
    }
  }
}

void loop()
{ 
  
  if(temperature > 35 )
  {
    digitalWrite(qn, HIGH);
  }
  else
  {
    digitalWrite(qn, LOW);
  }

  if( dong > 1.1 || ap > 250)
  {
    digitalWrite(da, HIGH);
  }
  else
  {
    digitalWrite(da, LOW);
  }

  if (millis() - timeold >= 1000)
     {  
     rpm = ((pulses - pulsesold) / pulsesperturn )*60; 
     if(pulses -  pulsesold  < 0)
       {
        rpm = 0;
       }
     
     timeold = millis();
     pulsesold = pulses;
       
       if(rpm !=0)
     {
      ttdc="XOAY";
     }
     else
     {
     ttdc="DUNG";
     pulses = 0;
     }
     if (rpm>3100)
     {
      rpm=3000;
     }
     td=rpm;   
    }    
  
  String dulieu = "";
  while (Serial.available() > 0)
  {
    char c = Serial.read();
    dulieu = dulieu + c;
    delay(5);
  }
  dulieu.trim();
  if (dulieu != "")
  {
    boctach(dulieu);
  }
  dulieu = "";
  delay(500);
}
