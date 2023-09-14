type User {
  id:ID!
  name: String!
  age: Int!
	height: Float!
  isMarried: Boolean
  friends: [User!]
  videosPosted: [Video!]
}

type Video {
  id: ID!
  title: String!
    description: String!
}

types são chamados de Scalar no graphQL

o ! indica que é um campo obrigatório 

[User] => array do type User

[User!] => o type é obrigatório, mas não o array

[User]! => o array é obrigatório, mas não o type

// Query => 

input userInput {
  id:ID
  name: String
}

cria um input para passar por parametro 

type Query {
  users: [User]

  // as duas formas funcionam:
  user(id: ID, name: String): User
  user(input: userInput): User
}