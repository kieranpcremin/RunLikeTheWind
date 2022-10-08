# Run Like The Wind Demo

The RunLikeTheWind is probably the worlds worst running coach :). It mainly advises you to go for PBs (Personal bests) by running in the same direction as the wind if the weather is windy :) . If the weather is calm it recommends a tempo run. If the weather is above 25 degrees celcius, you are wisely advised to stay hydrated and go for a very easy run. 

The code has been layered and structured so that RunLikeTheWind may grow as it recieves feedback and suggestions from its millions of users and more data to analyse in order to make good workout suggestions. E.g a users last x number of strava activities, a users latest health readings from their wearables, resting, variable heart rate etc...




# Tech Stack
The RunLikeTheWind Demo Web application is an Angular and ASP.NET Core solution. 

When the Angular web application loads, it communicates with an ASP.NET Core Web API to get a list of cities and binds them to a dropdown control.  When the user selects a city, the web api is called and gets the weather forecast data for the selected city.

The Workoutplanner in the domain model uses this weather data to determine a suitable run workout for the user. 



Web APP Url:            https://localhost:4200

Web API Documentation:  https://localhost:7051/swagger


## Prerequisites

Visual Studio 2022 Preview 2 or later with the ASP.NET and web development workload installed.

npm (https://www.npmjs.com/), which is included with Node.js

Angular CLI (https://angular.io/cli) This can be the version of your choice






# RunLikeTheWind  - Technical Details

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 14.2.5.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.
