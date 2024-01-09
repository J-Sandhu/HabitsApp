# HabitsApp
Personal Project. Habit building/tracking app, intended to be similar to Habitica.
Made in C# using .NET MAUI. Will eventually use a SQL database.

## Design
For this project I have chosen to use a Model-View-Controller design pattern.
### Model
The purpose of the model is to hold all the data in the app as well as all the functions that operate on the data: 
* Habits
* To Do list
* User stats
The model also contains a queue of tasks that have been issued to modify the data
### View
The View is in charge of displaying data to the user and taking inputs. It uses threading to maintain speed and responsiveness
Mockup of intended user interface:
![Initial design of user interface](https://github.com/J-Sandhu/HabitsApp/tree/main/HabitClient/View/Resources/Images/Habits_view_design.png?raw=true)
### Controller
The controller handles the running of operations on the model. It contains threads that access the model and modify it as requested by the user.
Eventually it will contain a clock to send events to handle due dates/ deadlines for the to do list.