<?php
    include_once('connect.php');
    $matricula = "";
    $nome = "";
    $nota = "";
    if (isset($_POST["matricula"]))
        $matricula = mysqli_real_escape_string($db, $_POST["matricula"]);
    if (isset($_POST["nome"]))
        $nome = mysqli_real_escape_string($db, $_POST["nome"]);
    if (isset($_POST["nota"]))
        $nota = mysqli_real_escape_string($db, $_POST["nota"]);
    if ($nome && $nota)
        mysqli_query($db, "insert into alunos (nome, nota) values ('$nome','$nota')");
    header('Location: ./cadastros.php')
?>