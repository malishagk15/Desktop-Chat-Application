# Desktop Chat Application

This project is a desktop chat application developed in C# using the .NET Framework. It integrates Firebase for real-time data synchronization and user authentication. The application allows users to securely log in, chat with others in real-time, and manage their profile information.

## Table of Contents

- [Key Features](#key-features)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Key Features

- **Real-Time Chat Functionality**: Users can send and receive messages instantly using Firebase’s real-time database, ensuring synchronized data across all clients.
- **User Authentication**: Users must register and log in before accessing the chat features. Firebase Authentication is used to manage user credentials securely.
- **User Profile Management**: Each user has a personalized profile where they can update their password and other details.
- **Password Recovery**: A secure mechanism is implemented for users who forget their passwords.
- **Modern User Interface**: The application is built with a responsive and intuitive user interface using WinForms in C#.

## Installation

### Prerequisites

- .NET Framework 4.7.2 or higher
- Visual Studio (with .NET desktop development workload installed)
- A Firebase project (for authentication and real-time database)

### Steps to Run Locally

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/DesktopChatApp.git
   ```
2. Open the solution in Visual Studio:
   ```bash
   cd DesktopChatApp
   start ChatApp.sln
   ```

3. Configure Firebase:

   - Create a Firebase project in the [Firebase Console](https://console.firebase.google.com/).
   - Enable Firebase Authentication and Realtime Database.
   - Add your Firebase credentials (API key, authentication domain, etc.) in the `firebase_connection.cs` file.

4. Restore NuGet Packages:

   Visual Studio should automatically restore the necessary NuGet packages from the `packages.config` file. If not, right-click on the solution in the Solution Explorer and select "Restore NuGet Packages."

5. Build and Run the project:
   - Press `F5` or click on the "Start" button in Visual Studio to run the application.

## Usage

- **Register**: Users can create an account by providing an email and password.
- **Login**: Use registered credentials to log in.
- **Chat**: Once logged in, users can send and receive messages in real time.
- **Profile**: Users can update their personal information and change their password from the profile section.
- **Password Recovery**: If users forget their password, they can recover it using their email address.

## Project Structure

```bash
│   ChatApp.sln
└───ChatApp
    │   firebase_connection.cs        # Firebase connection handling
    │   login_form.cs                 # User login interface
    │   register_form.cs              # User registration interface
    │   home_form.cs                  # Main chat window
    │   profile_form.cs               # User profile management
    │   change_pass_form.cs           # Change password functionality
    │   forget_pass_form.cs           # Password recovery
    │   Program.cs                    # Main entry point of the application
    ├───icons                         # UI icons for buttons, forms, etc.
    └───Properties                    # Project metadata and settings
```

## Technologies Used

- **C# and .NET Framework**: Core language and framework for developing the application.
- **WinForms**: For building the graphical user interface.
- **Firebase Realtime Database**: For managing real-time chat data.
- **Firebase Authentication**: For secure user authentication and management.
- **Newtonsoft.Json**: For JSON serialization and deserialization.
- **FireSharp**: For interacting with Firebase services.
- **MySQL.Data**: For handling potential user data storage (optional).

## Contributing

Contributions are welcome! If you'd like to contribute to this project:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-branch
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m 'Add some feature'
   ```
4. Push to the branch:
   ```bash
   git push origin feature-branch
   ```
5. Open a Pull Request.

### Customizing Firebase Configuration:
Make sure to include instructions about where and how to add Firebase API keys or secrets if necessary, or consider using a `.config` file for these values. Let me know if you need that section added to the README.
