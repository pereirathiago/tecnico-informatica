<?php
    $i = 0;

    // while($i <= 10) {
    //     echo "$i <hr>";

    //     // if($i == 7)
    //     //     break;
    //     $i++;
    // }

    // do {
    //     echo "$i <hr>";
    //     $i++;
    // } while ($i < 10);

    // for($i = 1; $i <= 5; $i++) {
    //     echo "valor de i: $i <hr>";
    // }
    $transporte = array(5);
    $transporte[0] = "Carro";
    $transporte[1] = "Bicicleta";
    $transporte[2] = "Barco";
    $transporte[3] = "Moto";
    $transporte[4] = "Avião";
    /*
    for($i = 0; $i < 5; $i++) {
        echo "Posição $i do vetor: $transporte[$i] <br>";
    }
    
    foreach($transporte as $veiculo) {
        echo "Veiculo: $veiculo <br>";
    }
    */

    function ola(){
        echo "Ola, Aleffer! <hr>";
        return "<br> Programação Para a Web<br>";
    }

    // ola();

    $matriz = array(
        array(2,3),
        array(3,4),
        array(9,5)
    );

    for($i = 0; $i < 3; $i++) {
        for($j = 0; $j < 2; $j++) {
            echo $matriz [$i] [$j]." ";
        }
        echo "<hr>";
    }
?>