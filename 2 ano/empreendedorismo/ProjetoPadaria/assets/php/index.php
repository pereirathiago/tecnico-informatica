<?php
    include_once('connect.php');

    if(isset($_POST['nome'])){
        $nome = mysqli_real_escape_string($connect,$_POST['nome']);
    }
    if(isset($_POST['email'])){
        $email = mysqli_real_escape_string($connect,$_POST['email']);
    }
    if(isset($_POST['telefone'])){
        $telefone = mysqli_real_escape_string($connect,$_POST['telefone']);
    }
    if(isset($_POST['msg'])){
        $msg = mysqli_real_escape_string($connect,$_POST['msg']);
    }
    if($nome && $email && $telefone && $msg){
        mysqli_query($connect,"INSERT INTO `padaria` (nome,email,telefone,msg) VALUES('$nome','$email','$telefone','$mensagem')");
    }
    header('Location: ../../index.html');
?>