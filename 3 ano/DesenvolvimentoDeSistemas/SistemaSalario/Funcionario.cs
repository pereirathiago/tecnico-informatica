using System;

public class Funcionario
{
	public Funcionario()
	{
		private int _id;
		private string _nome;
		private int _nFilhos;
		private int _nDepIR;
		private string _valeTransporte;

		public int Id { get => _id; set => _id = value; }
		public string Nome { get => _nome; set => _nome = value; }
		public int NFilhos { get => _nFilhos; set => _nFilhos = value; }
		public int NDepIR { get => _nDepIR; set => _nDepIR = value; }
		public string ValeTransporte { get => _valeTransporte; set => _valeTransporte = value; }
	}
}
