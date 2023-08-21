const http = require("http");
const fs = require("fs");

const port = 3000;

const server = http.createServer((req, res) => {
    //console.log(req);
    if (req.url === '/') {
        res.setHeader("Content-Type", "text/html");
        res.write("<html>");
        res.write("<head><title>Enter a Message</title></head>");
        res.write('<body><form action="/message" method="POST"><input type="text" name="Message"><button type="submit">Send</button></form></body>');
        res.write("</html>");
        return res.end();
    }

    if (req.url === "/message" && req.method === "POST") {
        const body = [];
        req.on("data", (chunk) => { //listen for each incoming piece of data and then
            console.log(chunk);
            body.push(chunk); //push each piece of data into the array "body".
        });
        req.on("end", () => { //when data is completely parsed ...
            const parsedBody = Buffer.concat(body).toString(); //buffer the data. i.e. accumilate the data and parse them.
            const message = parsedBody.split("=")[1];
            console.log(parsedBody);
            fs.writeFileSync("message.txt", message);
        });
        res.statusCode = 302;
        res.setHeader("Location", "/");
        return res.end();
    }

    res.setHeader("Content-Type", "text/html");
    res.write("<html>");
    res.write("<head><title>Server Response HTML</title></head>");
    res.write("<body><h1>Hello, I'm the server. How are you doing?</h1></body>");
    res.write("</html>");

});

server.listen(port);