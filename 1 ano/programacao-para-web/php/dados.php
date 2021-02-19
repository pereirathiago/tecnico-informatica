<?php
    /*
    $nome = $_GET['nome'];
    $email = $_GET['email'];

    */
    $nome = $_POST['nome'];
    $email = $_POST['email'];
    echo "Seu nome é $nome e seu e-mail é $email";
    echo "<hr>";
    var_dump($_POST);
?>