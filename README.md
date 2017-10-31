# Social Robots Project
>IST Social Robots and Human-Robot Interaction 2017 - Group 11 Project Repo



## Initial Idea
Robotic assistant to serve as personal trainer at a gym, from here on referred to as _assistant_. The robot would be semi-autonomous in the sense that it could perform some autonomous supervision of the _trainees_ workout but could also be overridden by a human personal trainer (_supervisor_) tasked with supervising several robotic assistants at once, making the costs of having a personal trainer lower for the Gym users.




## Revised Idea
An individual who would like to work out, but has no one to exercise with, therefore he lacks motivation.

[Schneider and Kummert](https://pub.uni-bielefeld.de/publication/2906151) suggest that workouts can be enhanced by having a Robotic Companion (RI) that performs the exercises alongside a human. To support this claim they tested three scenarios:
1. Human alone: A person doing the exercise by herself
2. Human and Robot Companion: A person and a robot doing the same exercise
3. Human and Robot Instructor: A person doing the exercise with a robot telling what exercise was next

They concluded that:
- Scenario 2 showed significant improvements over scenario 1. People exercised for more time when the robot was doing the exercise alongside them.
- Scenario 3 **did not show**(contrary to what they hypothesized) an improvement over scenario 1. People questioned the purpose of the robot and even became frustrated by its presence.

The goal of our study is to learn whether there is an intermediate level between having a robot doing the exercises with you (_robot companion_) and having the robot instruction you what to do (_robot instructor_) that can result in a significant improvement over doing exercises alone.

To achieve this goal we propose to develop a robot that gamifies the workout (_robot motivator_), for instance, setting goals a user has to achieve, followed by positive reinforcement.

To test this hypothesis we propose having individuals performing exercises in two scenarios, by themselves and with the robot.

## Research Questions

1. Is an individual's workout with a robot motivator better than doing it by her/himself?
2. Is an individual's workout with a robot motivator better than doing it with a robot instructor?





## Scenario
In this scenario we will be using a wizard of Oz setup. The setup will be a room with a yoga mattress in which each user will have to perform a series of simple exercises.
We want to test with individual users and compare the workout result and users reactions in two scenarios:
1. Alone
2. With a robot motivator



### Scenario 1 - Alone


In this scenario we have the normal way of working out where and individual walks into a room and does the exercises by himself. 
Some people know their training plan by hard, others consult a sheet of paper for this purpose and some do what they feel like.
Specially if the attendee has no experience some exercise can be performed the wrong way and if you have no one telling you how it is correctly done this can be rather harmful.
Also new users tend to mix random exercises that are not efficient together.
For example do 1 exercise for your legs followed by 1 related to your biceps.
Also new users are restricted often by the simpler exercises like push ups because they are unaware about the other possibilities they have to train the same body parts which turns their workout monotunous over time.

### Scenario 2 - With a Robot Motivator
In this scenario we wish to evaluate the impact of having a motivational robotic companion supervising and gamifying your workout, and seeing if it has a positive impact on your workout.

For each exercise the robot will display some sort of status in a way that is designed to motivate the user. For example, in an exercise where a person has to do 20 push-ups the robot's display would show a pyramid being built, the closer the user got to finish the exercise, the taller (closer to completion) the pyramid would be, this could also be accompanied by audible motivational messages such as "Keep going, you're doing great!"

### FAQ

> How will the robot know that the user is not cheating?

This is why we are using a wizard of Oz configuration. The robot will be transmitting a live video feed to a human that will be monitoring the workout and who can send messages to be relayed to the user by the robot.





## Technical Characteristics

### Software

The robot has to be able to:
- Synthesize speech
- Send a live video feed


### hardware

- RC Motion
    - Wheels
    - motors
    - battery
    - radio
    - rc remote

- Touchscreen
    - Tablet
    - 7''
    - Android
    - Webcam

- Kinnect (instead of webcam?)

- Speakers  

    

## Evaluation

- Compare the duration of the workout when a person is by themselves and when they have a robot motivator with them.
- Compare the accomplishment feeling of the users when they work out alone with the scenario where they have a robot motivator while they work out.
- 
