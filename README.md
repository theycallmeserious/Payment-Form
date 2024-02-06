# Payment Form

Payment Form is a CRUD operation project that allows users to manage credit card details. It includes features to create new cards, update existing ones, remove cards from the list, and read card details from the UI list.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [Acknowledgments](#acknowledgments)

## Introduction

Payment Form is a web application designed to facilitate CRUD operations on credit card details. Users can easily create, update, and remove cards, as well as retrieve card information from the UI.

## Features

- **Create:** Add a new credit card entry.
- **Update:** Modify existing credit card details.
- **Remove:** Delete a credit card entry from the list.
- **Read:** Retrieve and display credit card information.

## Technologies

- Angular 17
- Angular CLI
- Bootstrap CSS
- ASP.NET Core Web API
- Entity Framework
- CORS
- HTTP methods
- Async programming

## Getting Started

To run the Payment Form project locally, follow the instructions below.

### Prerequisites

Ensure you have the following software installed:

- Node.js
- Angular CLI
- .NET SDK

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/theycallmeserious/Payment-Form.git
    ```

2. Navigate to the project directory:

    ```bash
    cd Payment-Form
    ```

3. Install dependencies:

    ```bash
    # Angular
    cd client
    npm install

    # .NET
    cd server
    dotnet restore
    ```

## Configuration

No additional configuration is required. CORS settings are already configured for seamless communication between the Angular front end and ASP.NET Core Web API.

## Usage

1. Run the Angular development server:

    ```bash
    cd client
    ng serve
    ```

   Access the UI at `http://localhost:4200`.

2. Run the .NET Core Web API:

    ```bash
    cd server
    dotnet run
    ```

   The API will be accessible at `http://localhost:5000`.

## API Endpoints

- `GET /api/Payments`: Retrieve all credit card details.
- `POST /api/Payments`: Create a new credit card entry.
- `PUT /api/Payments/:id`: Update an existing credit card entry.
- `DELETE /api/Payments/:id`: Remove a credit card entry.

## Contributing

Feel free to contribute to this project by submitting issues, feature requests, or pull requests.

## Acknowledgments

- Bootstrap CSS for styling.
- Angular and ASP.NET Core communities for their invaluable resources.
