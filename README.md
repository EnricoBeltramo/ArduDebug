# ArduDebug

How any SW developer know, to have a good tool to debug the SW is a very helpful utility. Unfortunately the base Arduino IDE haven’t much utility to debug your sketch. In order to improve that I created a tool that allow, by the USB, to see (and modify) at runtime the SW variables while the program is running on the Arduino board.

Basically this feature is more or less an “hack” of Arduino compiler and memory management in Arduino. Using the compiled files (.elf), I get the memory address of variables used in the sketch. After, with this information, I created a serial communication that allow me to read and write any statically allocated variable on the Arduino SW. To do that, it’s necessary a tool to install on PC and a little library to add to Arduino sketch.

this project is composed by two parts:

- An Arduino library, to add in your sketh (see example to see how it work):
https://github.com/EnricoBeltramo/ArduDebug/tree/master/Arduino

- A graphical user interface to run to PC connected to Arduino by USB:
https://github.com/EnricoBeltramo/ArduDebug/tree/master/PC%20interface/Binaries
