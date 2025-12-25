Laboratory Work №3: OAuth2 Authentication in ASP.NET Core MVC
This project demonstrates the implementation of OAuth2 (Google) authentication within an ASP.NET Core MVC web application. The application provides secure access to specific subroutines only for authenticated users.

🚀 Features
OAuth2 Integration: Secure login using Google accounts.

Cookie-based Authentication: Local session management after successful Google login.

Role-based Access Control: Use of [Authorize] attributes to protect specific controllers and views.

User Profile: Displaying authenticated user information (Name).

Subroutines: Three protected pages representing different computational tasks.

🛠 Technology Stack
Framework: .NET 7 / .NET 8

Pattern: ASP.NET Core MVC

Security: Microsoft.AspNetCore.Authentication.Google

Frontend: Razor Views (HTML, CSS/Bootstrap)

📂 Project Structure
Program.cs — Authentication configuration and middleware pipeline.

Controllers/

AccountController.cs — Handles Login, Logout, and Profile logic.

SubroutinesController.cs — Contains protected logic for Task 1, 2, and 3.

Views/ — UI templates for Home, Profile, and Subroutines.

⚙️ Configuration
To run this project locally, you need to configure Google OAuth credentials:

Go to the Google Cloud Console.

Create a new project and set up OAuth 2.0 Client IDs.

Add https://localhost:XXXX/signin-google to your Authorized redirect URIs.

Replace the placeholders in Program.cs with your actual credentials:

C#

.AddGoogle(options =>
{
    options.ClientId = "YOUR_CLIENT_ID";
    options.ClientSecret = "YOUR_CLIENT_SECRET";
});
📝 How it works
Home Page: User arrives at the landing page.

Authentication: User clicks "Login with Google" and is redirected to Google's auth server.

Authorization: Upon successful login, the user gains access to the Profile and Subroutines.

Protection: If an unauthenticated user tries to access /Subroutines/Task1, the application automatically redirects them to the Google login page.
