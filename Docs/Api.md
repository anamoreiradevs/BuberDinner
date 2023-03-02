# Buber Diner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
    - [Register Request](#register-request)
    - [Register Response](#register-response)
      - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-reponse)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "password": "amiko1232!"
}
```

### Register Response

```js
200 Ok
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhb..z9dqcnXoy"
}
```
### Login

```js
POST {{host}}/auth/login
```
### Login Request

```json
{
  "email": "amichai@mantinband.com",
  "password": "amiko1232!"
}
```
### Login Response

```js
200 Ok
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "Amichai",
  "lastName": "Mantinband",
  "email": "amichai@mantinband.com",
  "token": "eyJhb..z9dqcnXoy"
}
```