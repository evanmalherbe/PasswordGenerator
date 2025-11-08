# Password Generator
This password generator web app is built using **.NET 8 with an MVC (Mode-View-Controller)** architecture and **Razor** views. It lets the user determine password length and which complexity options to include (e.g. numbers, special characters).<br/> 
[![Live Demo Link](https://img.shields.io/badge/Live%20Demo%20Link-3178c6)](https://passwordgenerator-production-963f.up.railway.app/)<br/>
![.NET 8](https://img.shields.io/badge/.NET%208-275779) 
![Razor](https://img.shields.io/badge/Razor-da1f1f) 
![Javascript](https://img.shields.io/badge/Javascript-43a618) 

## Table of Contents
- [Description](#description)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Credits](#credits)

## Description
This app is a **.NET 8 web app** built using MVC (Model-View-Controller) architecture with **Razor** views. It allows the user to select a password length and add complexity options (numbers, special characters). It also has simple form validation with error messages to ensure the user chooses valid options. Once the user generates a new password, they are given the option to copy the password to their clipboard or return to the home page to create a different password.

## Getting Started
To run this app outside of Visual Studio, you'll need the **.NET 8 SDK** installed on your machine (the version that is compatible with this project - 8.0). 

1. **Get the code (cloning the repository)** - You'll first need to get the code from Github. Follow these steps from your command line interface (CLI), such as Command Prompt, Powershell or Bash:<br/>
`git clone https://github.com/evanmalherbe/PasswordGenerator.git`
2. **Navigate to project directory** - Now use the `cd` command to move into the directory that contains the project's `.csproj` file.<br/>
`cd PasswordGenerator`
3. **Restore dependencies (optional but recommended):** Run the following command to download any necessary packages and dependencies. This is often done automatically, but this makes sure everything is in place.<br/>
`dotnet restore`
4. **Run the application:** Execute the project using the `dotnet run` command. <br/>`dotnet run`
5. **Access the application:** Once the application starts, the console output will show the urls where the app is listening. Usually, it will be something like `http://localhost:5000` or `http://localhost:5001`. Open your web browser (E.g. Microsoft Edge, Google Chrome etc) and type that address into your browser address bar to view the app.

## Usage
Once you open the project in your browser `http://localhost:5000` (or similar), you will see the homepage of the password generator app. Choose a password length from the dropdown menu (See image below).<br/>
![Password Generator - screenshot 1](PasswordGenerator/wwwroot/images/passwordGen1.png)<br/><br/>
Choose one or more complexity options (See image below).<br/>
![Password Generator - screenshot 2](PasswordGenerator/wwwroot/images/passwordGen2.png) <br/><br/>
Click the "Generate Password" button (see image below).<br/> 
![Password Generator - screenshot 3](PasswordGenerator/wwwroot/images/passwordGen3.png)<br/><br/>
See your new password and click the "Copy to clipboard" button if you like, or return to the home screen by clicking the "Go back to Generator" button (see image below).<br/>
![Password Generator - screenshot 4](PasswordGenerator/wwwroot/images/passwordGen4.png)

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement" or "bug".

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

## License
Distributed under the **MIT License**. See **[LICENSE](LICENSE)** for more information.

## Credits
This project was created by Evan Malherbe - October 2025 - [GitHub profile](https://github.com/evanmalherbe)
