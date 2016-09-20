/*************************************************** 
  This is a library for the run-time debug of variables on Arduino



  This library needs to use Serial, that can't be used for other function

  Written by Enrico Beltramo
  BSD license, all text above must be included in any redistribution
 ****************************************************/

#ifndef ARDUDEBUG_H
#define ARDUDEBUG_H

#if (ARDUINO >= 100)
 #include "Arduino.h"
#else
 #include "WProgram.h"
#endif

#define DEBUGSERIAL_MAX_VAR       5     // max number of variables to debug

class DEBUGSERIAL
{

public:
  DEBUGSERIAL();                  // constructor
  void init();                    // init internal variables and serial: to call once at setup
  void manage();                  // manage serial communication: to call continuosly in loop
  
private:

  // structure info variables to send
  typedef struct _varsinfo
  {
    byte len;                     // size variable
    unsigned int address;         // address variable
  } varsinfo;

  // variables
  unsigned long timesend;               // store last time send a message
  unsigned int  ratesend;               // store the rate to send messages
  varsinfo Vars[DEBUGSERIAL_MAX_VAR];   // info of variables to send
  
  byte trasmissionpending;        // flag RX transmission pending
  byte messatype;                 // type of message in RX
  byte lastread;                  // last byte read
  byte indexvar;                  // counter varaibles to send
  byte index;                     // index RX buffer

  unsigned int addresstoforce;     // address for forcing variables
  
  void newData(byte readval);     // add a new data in variables structures
  void writeSerialDebug();        // manage send data to serial
  void readSerialDebug();         // manage read data from serial
};

#endif //  ADAFRUIT_BMP085_H
