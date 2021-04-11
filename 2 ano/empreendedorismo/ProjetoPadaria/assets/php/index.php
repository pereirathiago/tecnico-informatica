<?php
    include_once('./connect.php');

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
        mysqli_query($connect,"INSERT INTO `padaria` (nome,email,telefone,mensagem) VALUES('$nome','$email','$telefone','$msg')");
        echo "<script>var ok = alert('Enviado com sucesso!')
        if(ok == undefined){
            window.history.back()
        }
        </script>";
    } else {
        echo"<script>var ok = alert('Preencha todos os campos!')
        if(ok == undefined){
            window.history.back()
        }
        </script>";
    }
?>