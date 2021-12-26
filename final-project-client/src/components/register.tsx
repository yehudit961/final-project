import { Box, Button, FilledInput, FormControl, makeStyles, TextField } from '@material-ui/core'
import React, { useState } from 'react'
import userAPI from '../apis/userAPI'
import User from '../models/user'

const useStyles = makeStyles({
    div:{
        height:'10px'
    },
    textField:{
    },
    root:{
        fontFamily:'Roboto'

    }
})
const Register = () => {

    const initialUser: User = {
        password: "",
        email: "",
        firstName: "",
        lastName: "",
        age: 0,
        userType:2
    }

    const [user, setUser] = useState<User>(initialUser)
    const classes = useStyles()
    const handleInputChange = (event: any) => {
        const { name, value } = event.target
        setUser({...user,[name]:value})
    }

    const postUser = ()=>{
        userAPI.register(user)
    }
    return (
        <Box component="form" className={classes.root} style={{display:'flex', flexDirection:'column',width:'50%', justifyItems:'center'}}>
            <TextField className={classes.textField}  name="firstName" label="first name" variant='outlined' onChange={handleInputChange}/>
            <div className={classes.div}></div>
            <TextField className={classes.textField} name="lastName" label="last name" variant='outlined' onChange={handleInputChange} />
            <div className={classes.div}></div>
            <TextField className={classes.textField} name="email" label="email" variant='outlined' onChange={handleInputChange}/>
            <div className={classes.div}></div>
            <TextField className={classes.textField} name="age" label="age" variant='outlined' onChange={handleInputChange}/>
            <div className={classes.div}></div>
            <Button   style={{backgroundColor:'lightgray'}} onClick={postUser}>Register</Button>
        </Box>
    )
}

export default Register