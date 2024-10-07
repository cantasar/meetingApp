# readme

# MeetingApp

MeetingApp is a web application built with **ASP.NET Core MVC** designed to help users organize and manage meetings. The application allows users to schedule meetings, view meeting details, and see a list of all upcoming meetings. It follows a **Model-View-Controller (MVC) architecture**, ensuring a clean separation of concerns.

## Table of Contents

- [Features](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [Technologies](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [Project Structure](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [Installation](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [Usage](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [Contributing](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)
- [License](https://www.notion.so/readme-1183b92b857a802daefbe3159a9fd934?pvs=21)

## Features

- Schedule meetings.
- View details for specific meetings.
- See a list of attendees.
- Simple and intuitive user interface.

## Technologies

- [**ASP.NET](http://asp.net/) Core 6.0 MVC:** Backend framework.
- Static Mock Data: Simulates a database for development and testing purposes.
- **Razor Pages:** For dynamic web pages.
- **Bootstrap:** For responsive design and UI components.

## Project Structure

The project is organized following the standard **ASP.NET Core MVC** structure:

### Controllers

- **HomeController.cs**: Manages requests to the home page, including rendering the main dashboard.
- **MeetingController.cs**: Manages meeting-related requests like creating, viewing, and listing meetings.

### Models

- **Repository.cs**: Manages data access logic for meetings, acting as a simple repository pattern for managing meetings in memory.
- **UserInfo.cs**: Represents user-specific data, such as name or email, which might be tied to meetings or participants.

### Views

The **Views** directory contains Razor views (.cshtml files) for rendering the UI. These are further organized into folders:

- **Home/index.cshtml**: The main page of the application.
- **Meeting/Apply.cshtml**: A form to apply or create a new meeting.
- **Meeting/Details.cshtml**: Shows detailed information about a specific meeting.
- **Meeting/List.cshtml**: Displays a list of all scheduled meetings.
- **Meeting/Thanks.cshtml**: A thank you page, potentially displayed after a user creates or schedules a meeting.
- **Shared/_Layout.cshtml**: The main layout file used across the entire application, which contains common HTML structure like header, footer, and styles.
- **Shared/_LayoutHomePage.cshtml**: A specific layout for the homepage, differentiating it from other pages.

### Properties

- **launchSettings.json**: Contains settings related to how the application is launched, including environment variables and server configurations.

### Static Files

The **wwwroot/lib/bootstrap/css** directory contains the Bootstrap CSS library, which is used to style the UI components of the application.

## Installation

To set up and run the project locally, follow these steps:

1. Clone the repository:
    
    ```bash
    git clone https://github.com/cantasar/meetingApp.git
    ```
    
2. Navigate to the project directory:
    
    ```bash
    cd meetingApp
    ```
    
3. Restore the required dependencies:
    
    ```bash
    dotnet restore
    ```
    
4. Build and run the project:
    
    ```bash
    dotnet run
    ```
    

## Usage

Once the application is running, you can access it through your browser at `http://localhost:5000`. The following features are available:

1. **Create a Meeting**: Navigate to the "Apply" page to schedule a new meeting by providing relevant details such as meeting name, date, and time.
2. **View Meeting List**: Access the "List" page to see a list of all upcoming meetings.
3. **View Meeting Details**: Click on a specific meeting from the list to view more detailed information.

## Contributing

Contributions to this project are welcome! To contribute, follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b new-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin new-feature`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](https://www.notion.so/LICENSE) file for details.