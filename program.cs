'[POST] /api/users/create'
Request body
{
  // Allowed a-z, A-Z and 0-9 chars only
  // Min size 4 chars and max size 32 chars
  username: string,

  // Your email address so we are able to contact you
  email: string,

  // Min size 8 chars
  password: string //
}

Response
{
  code: string, // ['Success', 'Error']
  message?: string
}