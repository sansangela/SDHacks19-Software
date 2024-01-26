# SD Hacks 2019: Watchtower Project (Software)
More on Devpost: https://devpost.com/software/disease-transmission-simulator

## Inspiration
Watch Tower Project is inspired by the SIR math model, which predicts the disease breakout under the consideration of a variety of factors. We considered the population distribution, transportation, geolocation, etc. in order to simulate a real-life disease breakout.
## What it does
**Watch Tower Project** is capable of predicting the transmission of **infectious diseases** based on the **local Disease Prevention Center resource**, the**route of transmission **, **local transportation network** and many other variables. Once the **Watch Tower** finished the calculation, it will send a warning message to citizens who nearby the outbreak area through smart devices to prevent or control the separation of disease. 
## How We built it
The entire Watch Tower Project is divided into two parts. One is the simulator system that is built with Unity. The simulator system will predict the impact area of **infectious diseases** based on the SIR math model and the Unity physics engine. The other part is the smart device linked with the simulator to notify users of related information or warning. The smart device we used for the demonstration is a **Fitbit** smartwatch.
## Challenges We ran into
We had a hard time trying to send data from Unity to Fitbit. The main reason being we were using two different languages to implement our front and back end
## Accomplishments that We're proud of
The simulation have very mature icon and UI design. And the simulator has already included a certain amount of conditions.
## What We learned
We learned a lot more about CSS related front end development and more function of the Unity engine and its application field is not only limited to the game.
## What's next for Watch Tower Project
Our team hopes the Watch Tower Project can include more parameters in the future in order to provide a more accurate prediction. We also hope to implement our project into remote areas where people need the most. 
