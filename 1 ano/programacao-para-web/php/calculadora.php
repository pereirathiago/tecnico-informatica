<html>
	<head>
		<style type="text/css">
			form fieldset {
	   			margin: 10px auto 10px auto;
	   			width: 40%;
	   			border: solid black 1px;
	   			padding: 1%;
	   			margin-bottom: 10px;
			}
		</style>
	</head>
	<body>
		<form name="fCalculadora" method="post" action="operacao.php">
			<fieldset>
				<legend>Calculadora</legend>
				<label>Valor 1:</label>
				<input type="text" name="fValor1" id="iValor1">
				<br><br>
				<label>Valor 2:</label>
				<input type="text" name="fValor2" id="iValor2">
				<br><br>
				<label>Selecione a operação:</label>
				<select name="operacao" id="operacao">
		        	<option value="somar">Somar</option>
		        	<option value="subtrair">Subtrair</option>
		        	<option value="multiplicar">Multiplicar</option>
		        	<option value="dividir">Dividir</option>

	      		</select>

				<br><br>

				<input type="submit" name="bCalcular" value="Calcular">
				<input type="reset" name="bLimpar" value="Limpar">
			</fieldset>
		</form>
	</body>
</html>