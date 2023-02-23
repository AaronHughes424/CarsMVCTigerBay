# Project Overview
There are two projects within this solution, a .NET Core Web API, and a .NET Core Web App. Both are targeting .NET 6.

The API has a basic implementation to expose a list of cars via one GET endpoint. These cars are held in-memory within a singleton repository.

The Web App is the default structure as added with visual studio - it is essentially empty.

# Tasks

- Create a page within the Web App. Using the API, display a list of cars on this page.
- Extend the API so that cars can be added to the list.
- Create an 'Add Car' page within the Web App which should use the API call you have created.
