#include "ArduDebug.h"

/*
  ArduinoDebug test
  This example show how init and run the realtime debug on arduino
  It need to have an Arduino connected to serial USB and the related graphical user interface

  Written by Enrico Beltramo
  
  This example code is in the public domain.
*/



DEBUGSERIAL ArduinoDebugger;

float counter = 0;
char temp[20];

// the setup routine runs once when you press reset:
void setup() {
  
  ArduinoDebugger.init();

  strcpy(temp,"ciao");
  
}

// the loop routine runs over and over again forever:
void loop() {
  
  ArduinoDebugger.manage();

  counter = counter + 1;

  if (counter >= 1000)
  {
    counter = 0;
  } 
  
  delay(1);
}

