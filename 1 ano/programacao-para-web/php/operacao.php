<?php
    $valor_1 = $_POST['fValor1'];
    $valor_2 = $_POST['fValor2'];
    $operacao = $_POST['operacao'];
    $resultado;

    switch($operacao){
        case "somar":
            $resultado = $valor_1 + $valor_2;
            echo "O resultado de $valor_1 + $valor_2 é igual a $resultado";
            break;
        case "subtrair":
            $resultado = $valor_1 - $valor_2;
            echo "O resultado de $valor_1 - $valor_2 é igual a $resultado";
            break;
        case "multiplicar":
            $resultado = $valor_1 * $valor_2;
            echo "O resultado de $valor_1 * $valor_2 é igual a $resultado";
            break;
        case "dividir":
            if($valor_2 == 0) {
                echo "Digite um valor diferente de zero no Valor 2";
            } else {
                $resultado = $valor_1 / $valor_2;
                echo "O resultado de $valor_1 / $valor_2 é igual a $resultado";
            }
            break;
    }

    echo '<br><br>';
    echo '<a href="JavaScript: window.history.back();">Voltar</a>';
?>