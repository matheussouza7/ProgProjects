var mysql = require('mysql2')

const conn = mysql.createConnection({
    host: 'localhost',
    database: 'pessoa',
    user: 'root',
    password: ''
})

conn.connect(function(error){
    if(error){
        throw error
    } else{
        console.log('Foi')
    }
})

conn.query('select*from pessoa', function(error, results, field){
    if (error)
    throw error

    results.forEach(result => {
        console.log(result)
    })
})

conn.end()