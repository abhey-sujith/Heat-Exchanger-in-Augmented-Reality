# Heat-Exchanger-in-Augmented-Reality
This is a small project which shows working of a heat exchanger in AR using Unity,Vuforia,Blender and Esp-8266(NodeMcu) wifi module and thinger.io website site.
This project takes sensor value(potentiometer can be changed) by using Node-Mcu and sends it to the iot website thinger.io and the values of the sensor can be seen there.These values are taken and shown in Augmented Reality by using Unity and Vuforia.Blender is used for Animation.

Steps for using Node-Mcu Esp-8266 
go here https://github.com/esp8266/Arduino and copy the Boards manager link: http://arduino.esp8266.com/stable/package_esp8266com_index.json
open Arduino and goto File->Preference->Adittional board manager and paste it.
goto tools->Boards->Boards Manager and search for esp8266 (community) and install it.
goto tools->Boards and set the board to Node-Mcu 1
now beforeing upload the arduino code see the next step

Steps for Thinger Website
create account
goto Devices->Add device write id description and credentials.The same should be also be in the arduino code.
now upload the code and check if data is being sent to website.
if data is being sent goto Devices->"your Device"->Device token and make a new token by pressing add.
