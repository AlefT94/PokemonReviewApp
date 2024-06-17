# PokemonReviewApp

PokemonReviewApp is an API designed to manage various entities related to Pokémon, such as Pokemons, Countries, Reviewers, Reviews, and Categories. This API provides functionalities to create, read, update, and delete these entities.

The API is developed using ASP.NET Core and follows the REST architectural style along with the Repository pattern to ensure clean separation of concerns and ease of maintenance.

__Features__
- CRUD Operations: Perform Create, Read, Update, and Delete operations on:
  Pokemons: Manage Pokémon data.
  Countries: Handle country-related information.
  Reviewers: Manage reviewer details.
  Reviews: Handle reviews given by reviewers for Pokémon.
  Categories: Manage different categories of Pokémon.
- RESTful API: Follows REST principles for predictable and resource-oriented endpoints.
- Repository Pattern: Implements the repository pattern for data access, providing a layer of abstraction over the data layer.
- 
__Technologies Used__
- ASP.NET Core: Framework for building modern, cloud-based, internet-connected applications.
- Entity Framework Core: Object-relational mapper (ORM) for .NET, simplifying data access.
- MySql: Database for storing application data.

__Getting Started__
__Prerequisites__
- NET Core SDK: Ensure you have the .NET Core SDK installed.
- MySql: Set up a MySql instance for database operations.

__Installation__
- Clone the repository:
  __git clone https://github.com/yourusername/PokemonReviewApp.git__
- Navigate to the project directory:
  __cd PokemonReviewApp__
- Restore the dependencies:
  __dotnet restore__
  
- Update the database connection string in appsettings.json to point to your MySql instance.
- Apply migrations and update the database:
  __dotnet ef database update__
- Run the application:
  __dotnet run__
