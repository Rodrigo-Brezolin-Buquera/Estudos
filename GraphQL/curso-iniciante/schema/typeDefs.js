const { gql } = require("apollo-server")

const typeDefs = gql`
    type User {
        id: ID!        
        name: String!
        username: String!
        age: Int!
        nationality: Nationality!
        friends: [User!]
        favoriteMovies:[Movie!]
    }

    type Movie {
        id: ID!
        name: String!
        yearOfPublication: Int!
        isInTheaters: Boolean!
    }

    type Query {
        users: [User!]!
        user(id:ID): User!
        movies: [Movie!]!
        movie(name:String!): Movie!
        User: [Movie] 
    }

    input CreateUserInput {       
        name: String!
        username: String!
        age: Int!
        nationality: Nationality = BRAZIL
    }

    input UpdateUserInput {       
        id: ID!
        username: String
    }

    type Mutation {
        createUser(input:CreateUserInput!): User
        updateUsername(input: UpdateUserInput): User
    }

    enum Nationality {
        CANADA
        BRAZIL
        INDIA
        GERMANY
        CHILE


    }

`
module.exports = {typeDefs}