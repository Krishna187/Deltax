# Deltax Casting 
Technologies:  Asp.net Mvc with EF, Code first Approach, Repository Pattern using Unit of work

Editor: VS2017

Project :
1. Deltax.Casting : Is the web based project contains controller,View and Areas for represent different Entities
2. Deltax.Entity: Contains the Codefirst approach to generate the DB based on the model.
3. Deltax.Service : contains the repository pattern using unit of work 

To generate the DB follow the below steps
1. Go to the web.config of Deltax.Casting and change the connection string   
2. go to the Package manager console by select the project Deltax.Entity then run the command 
PM> Update-Database

I have focused the Codefirst approach without concentrate the design 
I have written all the codes to add and display movie ,actor and Producer in the function controller of respective areas in Deltax.Entity project please review
