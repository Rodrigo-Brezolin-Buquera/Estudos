const { userList, movieList } = require("../mockData")
const _ = require("lodash")

const resolvers = {
    Query: {
       // USERS
        users() {
            return userList
        },
        // parents, arguments -> como parents não será usado colocou _ (trocou depois)
        user:(parent,arg ) => {
           const {id} = arg
            // lodash não funcinou como deveria => preciva converter para Number
           const user = userList.find(user=> user.id==id)
          
            return user
        },

        //MOVIES
        movies: ()=> {
            return movieList
        },
        movie: (parent, arg)=> {
            const {name} = arg
            // lodash não funcinou como deveria
           const movie = _.find(movieList, {name})
            return movie
        },
        // não funcionou
        User:{
            favoriteMovies: ()=>{
               return movieList
            }
        },
    // não funcionou, tive que adicionar na Query para não dar erro, mas não funciona


    },
    // Mutations
    Mutation:{
        createUser: (parent, arg)=> {
            const user = arg.input
            const id = 4523
            user.id = id   
            userList.push(user)
            return user
        },
        updateUsername: (parent, arg)=> {
            const {id, userName} = arg.input
            let updatedUser
            userList.forEach(user => {
                user.id === id && (user.username = userName);
                updatedUser = user

            })
            return updatedUser
        },

       
    } 

}

module.exports = { resolvers}