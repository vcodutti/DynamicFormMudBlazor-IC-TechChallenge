# DynamicFormMudBlazor

Project Overview
This project is a Blazor WebAssembly application that dynamically generates forms using MudBlazor components. 
The form configuration is defined in a FormConfiguration object, which includes various FormField objects 
representing different types of form fields (text, email, number, dropdown, checkbox). The form is rendered 
dynamically based on this configuration, and the form data is validated and submitted.

Step-by-Step Execution
1.	Clone the Repository: Clone the project repository to your local machine.
    git clone https://github.com/vcodutti/DynamicFormMudBlazor-IC-TechChallenge.git
2.	Open the Project in Visual Studio: Open the solution file (.sln) in Visual Studio.
3.	Restore NuGet Packages: Restore the required NuGet packages by right-clicking on the solution.
4.	Build the Project: Build the project to ensure that all dependencies are resolved and there are no 
	compilation errors. 
5.	Run the Project: Run the project by pressing F5. This will launch the Blazor WebAssembly application in 
	your default web browser.
6.	Interact with the Form: The form will be displayed on the home page. Fill in the form fields and submit 
	the form. The form data will be validated, and the results will be displayed in JSON format below the form.
	
Decision-making statements
- The application is structured using reusable MudBlazor offers a comprehensive set of modern, responsive UI 
  components that integrate well with Blazor. It simplifies the creation of a consistent and visually appealing 
  user interface.
- The application uses Blazor's data binding and validation features (@bind, DataAnnotationsValidator, ValidationMessage).
  Blazor's data binding simplifies the process of synchronizing the UI with the underlying data model. Using data
  annotations for validation ensures that form inputs are validated on the client side, providing immediate feedback to
  users and improving the overall user experience.
- The application includes error handling and user feedback mechanisms (alerts for success and error messages). Providing
  feedback to users is essential for a good user experience. By displaying success and error messages, the application
  informs users about the status of their actions, helping them understand whether their input was processed correctly or
  if there were issues that need to be addressed.

  ![MudBlazorResult](https://github.com/user-attachments/assets/f73704ab-df55-48ce-b145-b6592c2184b6)
