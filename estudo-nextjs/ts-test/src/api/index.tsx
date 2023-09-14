import axios from "axios";
import { TCharater, toModelCharacter, TResult } from "./model";


const api = axios.create({
    baseURL: "https://rickandmortyapi.com/api",
});

export default api;

export const getCharacters = async (query = "?page=1"): Promise<TResult>=> {
    const res = await api.get(`/character${query}`) 
    const modeledList: TCharater[] = res.data.results.map((i:any)=>toModelCharacter(i) )
    const result:TResult = {
        info: {
            next: res.data.info.next,
            prev: res.data.info.prev
        },
        list: modeledList
    }
    return result
};





