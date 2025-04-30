# AIPA API Discovery Service

This is a lightweight registry to register and discover APIs dynamically. It supports basic CRUD-like discovery patterns via REST.

## Features

- Register API descriptors (name, version, URL, description)
- Discover registered APIs
- Lightweight in-memory registry
- Swagger-enabled for easy testing

### Getting Started
1. Navigate to the `AIPA.ApiDiscovery` folder
2. Run the project using .NET SDK: `dotnet run`
3. Visit: `https://localhost:5001/swagger
   
## Endpoints

- `POST /api/discovery/register` — Register a new API
- `GET /api/discovery/all` — Get list of all registered APIs
- `GET /api/discovery/{name}` — Find a specific API

### Source Code
[View AIPA.ApiDiscovery Module](https://github.com/MahendhiranK/AIPA.Framework.Starter/tree/main/AIPA.ApiDiscovery)

## Example Payload

```json
{
  "name": "CustomerService",
  "version": "v1",
  "url": "https://api.example.com/customers",
  "description": "Manages customer profiles"
}
```

## License

MIT
