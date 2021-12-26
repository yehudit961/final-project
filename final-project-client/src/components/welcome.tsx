import { Button } from '@material-ui/core'
import React from 'react'
import { Link } from 'react-router-dom'


export const Welcome =()=>{
    
    return(
        <>
        <h1>welcome to amusement park</h1>
        <Link to='/Register'>Register</Link>
        <br/>
        <Link to='/Login'>Login</Link>
        </>
    )
}
