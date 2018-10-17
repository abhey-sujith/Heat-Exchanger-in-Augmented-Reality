# Heat-Exchanger-in-Augmented-Reality

**__This is a small project which shows working of a heat exchanger in AR using Unity,Vuforia,Blender and Esp-8266(NodeMcu) wifi module and thinger.io website site.__**                                                                                                
This project takes sensor values(potentiometer) by using Node-Mcu and sends it to the iot website 'thinger.io' .These values are taken and shown in Augmented Reality by using Unity and Vuforia. Blender is used for Animation.                    

**Steps for using Node-Mcu Esp-8266**                                                                           
1)Connect the Node-Mcu as shown in the figure using 4 potentiometer (diode is important as current will only flow in one direction).                                                                                                     
2)Go here https://github.com/esp8266/Arduino and copy the Boards manager link: http://arduino.esp8266.com/stable/package_esp8266com_index.json.                                                                                                                                         
3)Open Arduino and goto File->Preference->Additional board manager and paste it.                                
4)Goto tools->Boards->Boards Manager and search for esp8266 (community) and install it.                                  
5)Goto tools->Boards and set the board to Node-Mcu 1.0.                                                           
6)Now before uploading the arduino code see the step 2 below.                                                           

**Steps for Thinger Website**                                                                            
1)Create account in thinger.io                                                           
2)Goto Devices->Add device write id description and credentials.The same should be also be in the arduino code.               
3)Now upload the code and check if data is being sent to website.                                                      
4)If data is being sent goto Devices->"your Device"->Device token and make a new token by pressing Add.                        
5)Now open unity and after doing step 1 below open the newbehaviourscript and change url to"https://api.thinger.io/v2/users/username/devices/deviceid/details" this can be seen in Devices->"your Device"->API explorer and authorization to the "Bearer***** the big device token ******" in Device token.                                                                                               

**Steps for Unity 2017.3.1f1**                                                                  
1)Now open unity and copy everything "inside" the asset folder of Heat Exchanger into the asset folder of unity.                
2)Goto GameObject and import vuforia by just clicking anything inside it(if vuforia is not imported).                          
3)Goto file->Build settings->Player settings->XR settings->tick vuforia augmented reality.                                     
4)Now drag the heat exchanger.unity file to the hierarchy.                                                                        
5)Goto vuforia website log in and goto Develop->License Manager->get Development Key add a name and confirm.Go inside the name and copy the big key and now in unity in the hierarchy click AR camera look at the inspector panel and go to open vuforia configuration and add the app key in the box also check if in databases there is two tick marks for load 'he' database and also for activate and the load object target should also be tick marked.                                                                                   
6)In the inspector tab for AR camera change world centre mode to device tracking.                                              
7)Now press the play button and show the image use_apk_on_this_image.jpg to the camera present inside the Heat exchanger folder(type stones and chips vuforia the first image should be it).                                                            
8)If u want to make an app goto file->Build settings select android and build(file->Build settings->Player settings write the company name and product name file->Build settings->Player settings->Other Settings package name as com.companyname.productname)                                          


references:
for unity -https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA -Brackeys                                                                                    
for blender -https://www.youtube.com/user/AndrewPPrice -Blender Guru                                                       
for Augmented Reality -https://www.youtube.com/channel/UCBVWZH7ZrnegbWiK9pY5V-A -Edgaras Art                             
