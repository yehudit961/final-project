import User from "../models/user"

const userAPI = {
    async register(user:User):Promise<void>{
        const result =  fetch(`http://localhost:50907/api/user`,
        {
            method:'POST',
            body:JSON.stringify(user),
            headers: { 'Content-Type': 'application/json' },
        })
        
    },

    async login(email:number):Promise<User>{
        const result = await fetch(`http://localhost:50907/api/user/${email}`,
        {
            method:'GET',
            headers: { 'Content-Type': 'application/json' },
        })
        var body = await result.json()
        var user = body as User
        return user
        
    }
}

export default userAPI