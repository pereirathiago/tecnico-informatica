<?php
    include_once('connect.php');
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastrados</title>
</head>
<body>
    <form action="comum.php" method="post">
        <table border="1">
            <tr>
                <th></th>
                <th>Matricula</th>
                <th>Nome</th>
                <th>Nota</th>
            </tr>
            <?php
                $lista = mysqli_query($db, "Select * from alunos order by matricula");
                $linhas = $lista ? mysqli_num_rows($lista) : 0;
                for ($i=0; $i < $linhas; $i++) { 
            ?>        
                    <tr>
                        <td><input type='radio' name='sel' value='<?=mysql_result($lista, $i, "matricula")?>'></td>
                        <td><?=mysql_result($lista, $i, "matricula")?></td>
                        <td><?=mysql_result($lista, $i, "nome")?></td>
                        <td><?=mysql_result($lista, $i, "nota")?></td>
                    </tr>
            <?php
                }
            ?>
        </table>
        <br>
        <input type="submit" name="oper" value="Alterar">
        <input type="submit" name="oper" value="Excluir">
    </form>
    <button onclick="window.location.href='../index.html'">Voltar</button>
</body>
</html>