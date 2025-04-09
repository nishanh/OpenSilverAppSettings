# OpenSilver Application Settings Demo

This is an updated version of the application settings demo referenced on the OpenSilver website.  
The prior version uses deprecated methods and doesn't work in the simulator. This version addresses both issues.

The associated projects use **OpenSilver 3.2** and **.NET 9** where appropriate.

## Important Instructions

- To make this work in the simulator, you **MUST** add the `appsettings.json` file to the OpenSilver project proper — **NOT** to the `wwwroot` folder of the `.Browser` project.

- The `appsettings.json` file will be copied to the `wwwroot` folder as an **"After Build"** step.  
  Reference the `.csproj` file of the OpenSilver XAML project for details.


