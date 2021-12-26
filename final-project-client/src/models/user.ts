import internal from "stream";

export default interface User{
    password: string,
    email: string,
    firstName: string,
    lastName: string,
    age: number,
    userType: number
}