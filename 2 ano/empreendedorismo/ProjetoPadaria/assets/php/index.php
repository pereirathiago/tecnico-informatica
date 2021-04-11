<?php
    include_once('connect.php');

    if(isset($_POST['name'])){
        $nome = mysqli_real_escape_string($connect,$_POST['name']);
    }
    if(isset($_POST['email'])){
        $email = mysqli_real_escape_string($connect,$_POST['email']);
    }
    if(isset($_POST['tel'])){
        $telefone = mysqli_real_escape_string($connect,$_POST['tel']);
    }
    if(isset($_POST['message'])){
        $msg = mysqli_real_escape_string($connect,$_POST['message']);
    }
    if($nome && $email && $telefone && $msg){
        mysqli_query($connect,"INSERT INTO `padaria` (nome,email,telefone,msg) VALUES('$nome','$email','$telefone','$mensagem')");
    }
    header('Location: ../../index.html');
?>