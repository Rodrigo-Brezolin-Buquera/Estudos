export const toModelCharacter = (char:any): TCharater => {
    return {
        id: char.id,
        name: char.name,
        gender:  char.gender ,
        species:  char.species ,
        status:  char.status ,
        image:  char.image ,
        type:  char.type ,
        location: char.location.name,
        origin: char.origin.name,
    }
}

export type TCharater = {
    id: string,
    name: string,
    gender:  string,
    species:  string,
    status:  string ,
    image:  string,
    type: string ,
    location: string
    origin: string,

}

export type TResult = {
    info: {
        next: string,
        prev: string
    },
    list: TCharater[]
}