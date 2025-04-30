# AIPA API Discovery Service

This is a lightweight registry to register and discover APIs dynamically. It supports basic CRUD-like discovery patterns via REST.

## Features

- Register APIs with name, version, and description.
- Query all registered APIs.
- Lookup API by name.

## Endpoints

- `POST /api/discovery/register` — Register a new API
- `GET /api/discovery/all` — Get list of all registered APIs
- `GET /api/discovery/{name}` — Find a specific API

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
