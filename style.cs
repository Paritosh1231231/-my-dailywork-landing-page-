body {
    margin: 0;
    font-family: Arial, sans-serif;
    color: #333;
}

header {
    background: url('header-bg.jpg') no-repeat center center/cover;
    height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    color: #fff;
}

header .container {
    max-width: 600px;
}

header h1 {
    font-size: 3em;
    margin: 0;
}

header p {
    font-size: 1.5em;
}

header .btn {
    background: #ff9800;
    color: #fff;
    padding: 10px 20px;
    text-decoration: none;
    border-radius: 5px;
    margin-top: 20px;
    display: inline-block;
}

header .btn:hover {
    background: #e68900;
}

section {
    padding: 60px 20px;
}

section .container {
    max-width: 1000px;
    margin: 0 auto;
    text-align: center;
}

.services h2, .contact h2 {
    font-size: 2.5em;
    margin-bottom: 20px;
}

.services .service {
    margin-bottom: 20px;
}

.contact form {
    display: flex;
    flex-direction: column;
    align-items: center;
}

.contact input, .contact textarea {
    width: 100%;
    max-width: 500px;
    padding: 10px;
    margin-bottom: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
}

.contact button {
    background: #ff9800;
    color: #fff;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
}

.contact button:hover {
    background: #e68900;
}

footer {
    background: #333;
    color: #fff;
    padding: 20px 0;
    text-align: center;
}

footer .container {
    max-width: 1000px;
    margin: 0 auto;
}