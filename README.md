# Heat-Exchanger-in-Augmented-Reality
This is a small project which shows working of a heat exchanger in AR using Unity,Vuforia,Blender and Esp-8266(NodeMcu) wifi module and thinger.io website site.
This project takes sensor value(potentiometer can be changed) by using Node-Mcu and sends it to the iot website thinger.io and the values of the sensor can be seen there.These values are taken and shown in Augmented Reality by using Unity and Vuforia.Blender is used for Animation.

Steps for using Node-Mcu Esp-8266 
Connect the Node-Mcu as shown in the figure using 4 potentiometer (diode is important as current will only go in one direction) 
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
now open unity and after doing step 1 open the newbehaviourscript and change url to"https://api.thinger.io/v2/users/username/devices/deviceid/details" this can be seen in Devices->"your Device"->API explorer and authorization to the "Bearer***** the big device token ******"

Steps for Unity 2017.3.1f1
now open unity and copy everything "inside" the asset folder of Heat Exchanger into the asset folder of unity
goto GameObject and import vuforia by just clicking anything inside it(if vuforia is not imported).
goto file->Build settings->Player settings->XR settings->tick vuforia augmented reality.
now drag the heat exchanger.unity file to the hierarchy
goto vuforia website log in and goto Develop->License Manager->get Development Key add a name and confirm.Go inside the name and copy the big key and now in unity in the hierarchy click AR camera look at the inspector panel and go to open vuforia configuration and add the app key in the box also check if in databases there is two tick marks for load he database and activate and also load object target there should be a tick mark.
in the inspector tab for AR camera change world centre mode to device tracking.
now press the play button and show the image use_apk_on_this_image.jpg to the camera present inside the Heat exchanger folder(type stones and chips vuforia the first image should be it).
