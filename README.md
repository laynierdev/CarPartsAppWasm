# 🌟 CarPartsAppWasm

Welcome to **CarPartsAppWasm**! 🚗✨

## <p style = "color: lightgreen">Description</p>
CarPartsAppWasm is an **online store** for selling **auto parts**, developed using **Blazor** and **WebAssembly**. This project is designed to provide a smooth and modern user experience, leveraging the latest technologies in .NET 8.

## <p style = "color: lightgreen">Technologies Used</p>
- **Blazor**: A framework for building interactive web applications using C# instead of JavaScript. [Learn more about Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor).
- **WebAssembly**: Allows code to run in the browser at high speed, providing a native-like application experience.
- **.NET 8**: The latest version of Microsoft’s popular framework, which offers improved performance and new features.
- **Auth0**: For managing user authentication securely and efficiently.

## <p style = "color: lightgreen">Features</p>
- **Intuitive Interface**: Easily navigate through a user-friendly interface.
- **Secure Authentication**: Users can register and log in securely using Auth0.
- **Fast and Efficient**: Thanks to WebAssembly, the application loads quickly and responds efficiently.

## <p style = "color: lightgreen">Installation</p>
To clone the repository and run the application locally, follow these

1. Clone repo:
   ```bash
   git clone https://github.com/laynierdev/CarPartsAppWasm.git

2. Navigate to project folder:
   ```bash
   cd CarPartsAppWasm

3. Build and Run project:
   
   Create in wwwroot folder an appsettings.json file with relevant Auth0 configuration
like this example:
    ````
        {
          "Auth0": {
            "Authority": "https://<YOUR_AUTH0_DOMAIN>",
            "ClientId": "<YOUR_CLIENT_ID>"
          }
        }
    ````
   

4. Build and Run project:
   ```bash
   dotnet run
***

>>* Remeber to install any missing library to develop. IDE will guide you through.
