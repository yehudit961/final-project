import { Button, TextField } from '@material-ui/core'
import React, { useState } from 'react'
import userAPI from '../apis/userAPI'
import User from '../models/user'


export const Login = () => {
    const [id, setId] = useState(0)
    const [user, setUser] = useState<User>()
    const getUser = async () => {
        console.log(id,"-----")
        const user = await userAPI.login(id)
        setUser(user)
    }
    return (<>
        <TextField placeholder='enter id' onChange={(event: any) => { console.log(event.target.value);setId(event.target.value)}} />
        <button onClick={getUser}>click me</button>
        <div>user: {user?.email}</div>
    </>
    )
}