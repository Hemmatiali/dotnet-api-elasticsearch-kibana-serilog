# C# .NET 8 API with Elasticsearch, Kibana, and Serilog Integration

Welcome to the .NET API with Elasticsearch, Kibana, and Serilog Integration project! This repository demonstrates how to build a .NET API that integrates with Elasticsearch for logging, visualizes logs in Kibana, and uses Serilog for structured logging. The project follows best practices and is built with .NET 8.

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [Debug application](#Debugging)
- [Examples](#examples)
- [Documentation and Comments](#documentation-and-comments)
- [License](#license)

## Features
1. **API Endpoints:**
   - Provides a sample Product API with endpoints to retrieve product details.
   - Implements structured logging using Serilog.

2. **Elasticsearch Integration:**
   - Logs API activity to Elasticsearch for efficient search and analysis.
   - Configurable Elasticsearch sink for Serilog.

3. **Kibana Dashboard:**
   - Visualizes logs in Kibana.
   - Helps in monitoring and troubleshooting with rich data insights.

4. **Global Error Handling:**
   - Implements global error handling middleware.
   - Logs detailed error information including request and response context.

## Installation
  To install and run the application, follow these steps:

  1. Clone the repository from GitHub:
```bash
git clone https://github.com/Hemmatiali/dotnet-api-elasticsearch-kibana-serilog.git
cd dotnet-api-elasticsearch-kibana-serilog
```

2. Ensure Docker is installed and running on your machine.

3. Build and start the Docker containers:
```bash
docker-compose up --build
```

## Debugging the Application
1. Stopping Docker Containers:
```bash
docker-compose down
```

2. Debugging with Visual Studio:
   - Open the solution in Visual Studio.
   - Ensure Docker support is enabled.
   - Set the project as the startup project.
   - Press F5 to start debugging.
  
## Examples
**API Endpoint**
Retrieve a product by ID:
```bash
Swagger http://localhost:5297/swagger
GET http://localhost:5297/api/product/-1
```

**Log Visualization in Kibana**
1. Open Kibana at:
```bash
http://localhost:5601
```
2. Navigate to the "Discover" tab.
3. Select the index pattern corresponding to your logs (e.g., logstash-*).
4. Use the following search query to filter error logs:
```bash
level: "Error"
```

**ElasticSearch**
Open Elasticsearch at:
```bash
http://localhost:9200
```

## Documentation and Comments
The code is thoroughly documented with XML comments explaining the functionality of each component and method. Clear instructions are provided on how to build, run, and use the application.

## License
This project is licensed under the MIT License - see the [LICENSE](license.txt) file for details.
