

async function conectar(){
    var mysql = require('mysql2')
    const conn = await mysql.createConnection({
    host: 'localhost',
    database: 'pessoa',
    user: 'root',
    password: ''
})}

async function select(){
    const conn = await conectar()
    const [rows] = await conn.query('select * from pessoa')
    return rows
}
