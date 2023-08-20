const http = require("http");

const port = 3000;

const server = http.createServer((req, res) => {
    //console.log(req);

    res.setHeader("Content-Type", "text/html");
    res.write("<html>");
    res.write("<head><title>Server Response HTML</title></head>");
    res.write("<body><h1>Hello, I'm the server. How are you doing?</h1></body>");
    res.write("</html>");
});

server.listen(port);