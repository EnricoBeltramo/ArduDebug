/*************************************************** 
  This is a library for the run-time debug of variables on Arduino



  This library needs to use Serial, that can't be used for other function

  Written by Enrico Beltramo
  BSD license, all text above must be included in any redistribution
 ****************************************************/

#include "ArduDebug.h"

// defines
#define MAX_BUFFERSERIAL  10    // size of internal buffer serial to transmit
#define DEFAULT_SEND_RATE 10    // ms for frequency send rate

#define SPECIAL_CAR_ESC   0xFF  // escape character
#define SPECIAL_CAR_INIT  0x02  // init transmission character
#define SPECIAL_CAR_END   0x03  // end transmission character

#define RX_NONE           0     // flag no pending trasmission
#define RX_START          1     // flag trasmission started
#define RX_ONGOING        2     // flag trasmission ongoing

#define MESSAGE_VAR       'V'   // flag message configuration variables
#define MESSAGE_RATE      'R'   // flag message rate update
#define MESSAGE_FORCE     'F'   // flag message force


// default constructor
DEBUGSERIAL::DEBUGSERIAL()
{
  // reset all internal variables
  trasmissionpending = RX_NONE;
  ratesend = DEFAULT_SEND_RATE;
  lastread = 0;
  indexvar = 0;
  messatype = 0;
  index = 0;
}


// init serial communication
void DEBUGSERIAL::init()
{
  // initialize serial communication at 57600 bits per second:
  Serial.begin(57600);

  // init time to send data
  timesend = millis();
}

// to call continously in main loop: manage serial communication
void DEBUGSERIAL::manage()
{
  // manage RX messages
  readSerialDebug();

  // manage TX messages
  writeSerialDebug();
}

// manage TX messages
void DEBUGSERIAL::writeSerialDebug()
{
  int i,j;
  
  byte buffersend[MAX_BUFFERSERIAL];
  int counter = 0;
  byte *point;
  byte data;
  int len;

  // verify if a RX trasmission is pending: if is, disable the trasmission till the end or RX
  if (trasmissionpending == RX_NONE)
  {
    // verify if time to send new data
    if (millis() - timesend >= ratesend)
    {
      // store actual time
      timesend = millis();
    
      // insert star message charapters
      buffersend[counter++] = SPECIAL_CAR_ESC;
      buffersend[counter++] = SPECIAL_CAR_INIT;
  
      // loop for all required varaibles
      for (i = 0; i < indexvar ; i++)
      {
        // get the base adrress of variable (the data content is converted as byte buffer)
        point = (byte*)(Vars[i].address);
  
        // get the len of variable
        len = Vars[i].len;
  
        // for all byte of data of variables
        for (j = 0 ; j < len ; j++)
        {
          // get the related byte
          data = point[j];
  
          // store the data in buffer
          buffersend[counter++] = data;
  
          // if the data to send is an escape charapter
          if (data == SPECIAL_CAR_ESC)
          {
            // send the data twice in order to avoid ambiguity
            buffersend[counter++] = SPECIAL_CAR_ESC;
          }
  
          // if fill the internal buffer
          if (counter >= MAX_BUFFERSERIAL - 3)
          {
            // send partially data
            Serial.write(buffersend,counter);
  
            // reset the index
            counter = 0;
          }
        }
      }
  
      // add end message charapters
      buffersend[counter++] = SPECIAL_CAR_ESC;
      buffersend[counter++] = SPECIAL_CAR_END;
  
      // send all data to serial
      Serial.write(buffersend,counter);
    }
  }
}


// add a new data in variable structure
void DEBUGSERIAL::newData(byte readval)
{
  byte *pointvar;

  switch (trasmissionpending)
  {
    // check if RX trasmission in pending
    case RX_ONGOING:
    
      switch(messatype)
      {
        case MESSAGE_VAR:
        
          // get the pointer in structure data: the structure is written byte after byte
          pointvar = (byte*)(&(Vars[indexvar]));
      
          // save the data in structure memory
          pointvar[index++] = readval;
      
          // if all bytes of structure are wrote
          if (index == sizeof(varsinfo))
          {
            // increase the number of stored variables
            indexvar = (indexvar + 1) % (DEBUGSERIAL_MAX_VAR + 1);
      
            // reset the index
            index = 0;
          }
          break;

        case MESSAGE_FORCE:
        
          // first 2 bytes are for address
          if (index < 2)
          {
            // get the pointer in structure data: the structure is written byte after byte
            pointvar = (byte*)(&(addresstoforce));

            // save the data in structure memory
            pointvar[index] = readval;
          }
          else  // the other bytes are to force buffer
          {
            // copy data to buffer (-2 offset because for index)
            ((byte*)(addresstoforce))[index - 2] = readval;
          }

          // increases index
          index++;
            
          break;

        case MESSAGE_RATE:

          // set address of send rate variable
          pointvar = (byte*)(&(ratesend));

          if (index < sizeof(ratesend))
          {
            // save the data in structure memory
            pointvar[index++] = readval;
          }

          break;
          
        default:
         break;
      }    
      break;

    // check if RX trasmission in starting
    case RX_START:

      // store type of trasmission
      messatype = readval;

      // if message set variables
      if (messatype == MESSAGE_VAR)
      {
        // reset the counter for variables
        indexvar = 0;
      }

      // set trasmission ongoing
      trasmissionpending = RX_ONGOING;

      break;

    // ignore the data
    default:
      break;
  }
}

// manage reading data from serial
void DEBUGSERIAL::readSerialDebug()
{
  // check if serial data are available
  while (Serial.available())
  {
    // if the previos received byte was a escape charapter
    // if iyes, it shall manage the new data in order to manage the special charapters
    if (lastread == SPECIAL_CAR_ESC)
    { 
      // read the new serial data
      lastread = Serial.read();

      // parse special charapter
      switch(lastread)
      {
        // detected init transmission
        case SPECIAL_CAR_INIT:

          // set transmission pending
          trasmissionpending = RX_START;

          // reset all counters
          index = 0;
          break;

        // end message
        case SPECIAL_CAR_END:

          // reset flag transmission pending
          trasmissionpending = RX_NONE;
     
          // store actual time
          timesend = millis();
          
          break;

        // no special charapter: get the data and decode it
        default:
          newData(lastread);

          // clear the data (it should be an escape, to avoid this condiction in next check)
          lastread = 0;
          break;
      }
    }
    else  // no special charapter
    {
      // if the new data is not a escape
      if ((lastread = Serial.read()) != SPECIAL_CAR_ESC)
      {
        // add the data in buffer if necessary
        newData(lastread); 
      }  
    }
  }
}
