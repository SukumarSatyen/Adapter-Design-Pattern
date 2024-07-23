# Adapter Pattern Demo: Sukumar's Job Search

This project demonstrates the Adapter Design Pattern through a story about Sukumar, an unemployed architect in Gurugram searching for jobs in software companies.

## Project Description

The project illustrates how the Adapter Pattern can be used to make incompatible interfaces work together. In this case, it shows how Sukumar (an architect) can adapt his skills to fit software development roles.

## Design Pattern Explanation

The Adapter Pattern is used as follows:

- `IArchitectJob`: The target interface that Sukumar expects.
- `SoftwareDeveloperJob`: The adaptee, representing the available jobs in software companies.
- `SoftwareArchitectAdapter`: The adapter that makes the `SoftwareDeveloperJob` look like an `IArchitectJob`.

## How to Run

1. Ensure you have the .NET SDK installed on your machine.
2. Clone this repository to your local machine.
3. Open the project in Visual Studio Code.
4. Open a terminal in VS Code and navigate to the project directory.
5. Run the following command:

   ```
   dotnet run
   ```

6. The program will execute, showing Sukumar's journey through different software companies.

## Project Structure

- `Program.cs`: Contains all the classes and the main program.
- `.gitignore`: Specifies which files should be ignored by Git.
- `README.md`: This file, containing project information and instructions.

## Learning Outcomes

By studying this project, you can learn:

1. How the Adapter Pattern works in practice.
2. How to implement the Adapter Pattern in C#.
3. How design patterns can be applied to real-world scenarios.

Feel free to modify the code and experiment with the pattern to deepen your understanding!
