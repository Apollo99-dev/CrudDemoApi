\# CRUD API using ASP.NET Core



\## 📌 Overview



This is a simple RESTful API built using ASP.NET Core that performs CRUD (Create, Read, Update, Delete) operations on Product data.



The project uses Entity Framework Core with an In-Memory database and includes Swagger UI for API testing.



\---



\## 🚀 Features



\* Create a new product

\* Get all products

\* Get product by ID

\* Update product

\* Delete product

\* Swagger UI for testing APIs



\---



\## 🛠 Tech Stack



\* ASP.NET Core Web API

\* Entity Framework Core

\* In-Memory Database

\* Swagger (Swashbuckle)



\---



\## 📂 Project Structure



Controllers/ → Handles API requests

Models/ → Defines data models

Data/ → Contains DbContext

Program.cs → Application entry point



\---



\## ▶️ How to Run



1\. Clone the repository:



```

git clone https://github.com/Apollo99-dev/CrudDemoApi.git

```



2\. Navigate to project folder:



```

cd CrudDemoApi

```



3\. Run the application:



```

dotnet run

```



4\. Open Swagger UI:



```

https://localhost:xxxx/swagger

```



\---



\## 📌 API Endpoints



| Method | Endpoint          | Description       |

| ------ | ----------------- | ----------------- |

| POST   | /api/Product      | Create product    |

| GET    | /api/Product      | Get all products  |

| GET    | /api/Product/{id} | Get product by ID |

| PUT    | /api/Product/{id} | Update product    |

| DELETE | /api/Product/{id} | Delete product    |



\---



\## 💡 Notes



\* This project uses an in-memory database, so data will be lost when the application stops.

\* Suitable for learning and demonstration purposes.



\---



\## 🚀 Future Improvements



\* Add Service Layer

\* Implement Repository Pattern

\* Use SQL Server instead of In-Memory DB

\* Add Validation and DTOs

\* Add Authentication \& Authorization



\---



\## 👨‍💻 Author



GitHub: https://github.com/Apollo99-dev



