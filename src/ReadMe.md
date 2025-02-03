ReadMe.md

## Usage

This is a simple calculator application built using C# and .NET 8.The application supports addition of up to two numbers provided via command line input.

## Requirements

- .NET 8.0 SDK

## Building the Application

1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Run the following command to build the application:

   ```
   dotnet build
   ```

## Running the Application

1. After building the application, run the following command from root:

   ```
   dotnet run --project src
   ```

2. Enter numbers separated by a comma, "#" character, or other non-numeric delimiter (i.e. wsfgf, xxx, ddd) when prompted.

## Usage - General

- The application accepts a single input string with two numbers separated by a comma.
- If more than two numbers are entered, an exception will be thrown.
- Empty input or missing numbers will be treated as `0`.
- Invalid numbers or characters will be converted to `0`.

## Running Unit Tests

1. Navigate to the `tests` directory and run the following command:

   ```
   dotnet test

   ```

## Examples

- Input: `1,2` -> Output: `3`
- Input: `20,33` -> Output: `53`
- Input: `5,tytyt` -> Output: `5`
- Input: `,` -> Output: `0`

```

```
