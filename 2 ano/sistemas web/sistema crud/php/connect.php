<?php
    try {
        $db = mysqli_connect("localhost", "root", "vertrigo");
        mysqli_select_db($db, "escola");
        echo "<script>console.log('Conectou!)'</script>";
    } catch (Exception $e) {
        echo "<script>console.log('Nao conectou, erro $e')</script>";
    }
    
    function mysql_result($res, $row, $field = "")
    {
        $res->data_seek($row);
        $datarow = $res->fetch_array();
        return $datarow[$field];
    }
?>