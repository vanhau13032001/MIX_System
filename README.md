# Mix_System
# Description
The Material Mixing System is an application designed to control the process of mixing two types of materials in a mixing tank. The system consists of two material discharge valves, each controlling a separate type of material. The operator can input the weight of each material for each batch. After the materials are discharged into the mixing tank, a mixing motor is activated to mix the materials for a set period of time.

Once the mixing process is completed as per the set time, the system will activate a third valve to discharge the mixed material. This process continues until a low-level sensor detects depletion, at which point the system automatically closes the third valve and completes a batch.

The system also allows for manual control by the operator, enabling them to intervene in the mixing process and control the valves and mixing motor manually.

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/7be4de25-4d95-44be-97b4-065aa87917b7)

# Features
 + User Management:The User Management feature enables the system to efficiently manage users with varying levels of access and control within the system. This feature allows users to log in to the system based on their roles, ranging from system administrators to operations supervisors, with different access privileges to control the system.
   
![image](https://github.com/vanhau13032001/mix_system/assets/131149905/57df7a98-4a8a-4e21-bbc8-ce03112204b9)

 + Order Management:The Order Management feature allows users to efficiently manage orders, including the ability to set order names, specify ingredient quantities, and add, delete, or update orders. The values associated with each order are stored in a SQL Server database.
   
![image](https://github.com/vanhau13032001/mix_system/assets/131149905/bf88cd3a-a155-4fd7-b9bf-247abb84d80d)

+ <h3>**Production Data Management and Reporting**</h3>: The Production Data Management and Reporting feature allows users to efficiently manage and retrieve production data. Users can search for data based on date, time, production shift, and generate reports in PDF and Excel formats for further data analysis and processing.
  
![image](https://github.com/vanhau13032001/mix_system/assets/131149905/d1685268-eef6-43f6-9736-f67f4c0bb36f)

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/739b3702-d690-4fbc-85d8-ed05de8bbc5b)

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/f4e5bae7-2eff-4727-b365-12a170428c86)

+ Alerting System:The Alerting System feature is designed to monitor the status of devices and equipment within the system and provide real-time alerts in case of errors or issues. It displays these alerts on the main control interface and records the time of the errors in the database.

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/48675ac7-dbf3-4177-b9d5-077167471c5d)

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/7d00720e-345a-49ab-9acb-c07cbb15bc37)

+ System Configuration:The System Configuration feature allows authorized users to modify the system's settings, including changing the database for data storage and adjusting production shift times.

![image](https://github.com/vanhau13032001/mix_system/assets/131149905/5a4b60d0-eff6-47c5-b0ee-90f8eeeeb863)

 # Technology in use
 
+ C# (Widownform):User interface for monitoring system status.
+ PLC: the PLC S7-1200, programming is used to control the system's state.
+ Kepserver: Kepserver is used to establish a connection between Visual Studio and a PLC via the OPC protocol.
+ SQL SERVER:SQL Server connects to Visual Studio to store production data.




