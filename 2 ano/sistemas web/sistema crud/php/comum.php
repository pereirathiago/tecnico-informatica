<?php
    include_once('connect.php');
    $matricula = "";
    $nome = "";
    $nota = "";
    $sel = "";
    $oper = "";
    if (isset($_POST["matricula"]))
        $matricula = mysqli_real_escape_string($db, $_POST["matricula"]);
    if (isset($_POST["nome"]))
        $nome = mysqli_real_escape_string($db, $_POST["nome"]);
    if (isset($_POST["nota"]))
        $nota = mysqli_real_escape_string($db, $_POST["nota"]);
    if (isset($_POST["oper"]))
        $oper = $_POST["oper"];
    if (isset($_POST["sel"]))
        $sel = $_POST["sel"];

    switch ($oper) {
        case 'Alterar':
            if ($sel) {
                $lista = mysqli_query($db, "Select * from alunos where matricula=$sel");
                $matricula = mysql_result($lista, 0, "matricula");
                $nome = mysql_result($lista, 0, "nome");
                $nota = mysql_result($lista, 0, "nota");
                if ($oper == "Alterar") {
                    echo "<form action='comum.php' method='post'>";
                    echo "matricula<input type='text' name='matricula' value='$matricula' readonly><br>";
                    echo "Nome<input type='text' name='nome' value='$nome'><br>";
                    echo "nota<input type='text' name='nota' value='$nota'><br>";
                    echo "<input type='submit' name='oper' value='Altera'>";
                    echo "</form>";
                }
            } else {
                $oper = "";
            }
            break;

        case "Altera":
            mysqli_query($db, "update alunos set nome='$nome',nota='$nota' where matricula=$matricula");
            header('Location: ./cadastros.php');
            break;
        
        case 'Excluir':
            mysqli_query($db, "delete from alunos where matricula= $sel");
            header('Location: ./cadastros.php');
            break;

        default:
            break;
    }
?>
<button onclick="window.location.href='./cadastros.php'">Voltar</button>