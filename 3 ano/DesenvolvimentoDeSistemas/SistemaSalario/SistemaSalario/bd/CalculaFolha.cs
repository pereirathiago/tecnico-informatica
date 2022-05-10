using SistemaSalario.vo;

namespace SistemaSalario.bd
{
    internal class CalculaFolha
    {
        private Funcionario funcionario;
        private Tabela tabela;
        private double inss;
        private double sf;
        private double vt;
        private double salliq;
        private double irrf;

        public void calcula()
        {
            //Cálculo do Vale Transporte
            if (funcionario.Vt.Equals("S"))
            {
                vt = funcionario.Salario * 6 / 100;
            }
            else
            {
                vt = 0;
            }
            //Cálculo do Salário Família
            if (funcionario.Salario <= tabela.Tsf)
            {
                sf = funcionario.Dep14 * tabela.Vsf;
            }
            else
            {
                sf = 0;
            }
            //Cálculo do INSS
            if (funcionario.Salario <= tabela.Tinss1)
            {
                inss = funcionario.Salario * tabela.Ainss1 / 100;
            }
            else
            {
                if (funcionario.Salario <= tabela.Tinss2)
                {

                    inss = tabela.Tinss1 * tabela.Ainss1 / 100 + (funcionario.Salario - tabela.Tinss1) * tabela.Ainss2 / 100;
                }
                else
                {
                    if (funcionario.Salario <= tabela.Tinss3)
                    {

                        inss = tabela.Tinss1 * tabela.Ainss1 / 100 + (tabela.Tinss2 - tabela.Tinss1) * 
                            tabela.Ainss2 / 100 + (funcionario.Salario - tabela.Tinss2) * tabela.Ainss3 / 100;

                    }
                    else
                    {
                        if (funcionario.Salario <= tabela.Tinss4)
                        {
                            inss = tabela.Tinss1 * tabela.Ainss1 / 100 + (tabela.Tinss2 - tabela.Tinss1) *
                                tabela.Ainss2 / 100 + (tabela.Tinss3 - tabela.Tinss2) * tabela.Ainss3 / 100 + 
                                (funcionario.Salario - tabela.Tinss3) * tabela.Ainss4 / 100;

                        }
                        else
                        {

                            inss = tabela.Tinss1 * tabela.Ainss1 / 100 + (tabela.Tinss2 - tabela.Tinss1) *
                                tabela.Ainss2 / 100 + (tabela.Tinss3 - tabela.Tinss2) * tabela.Ainss3 / 100 +
                                (tabela.Tinss4 - tabela.Tinss3) * tabela.Ainss4 / 100;

                        }
                    }
                }
            }
            //Cálculo do IRRF
            double bc = funcionario.Salario - inss - (funcionario.Depir * tabela.Dedpdep);
            if (bc <= tabela.Tirrf1)
            {
                irrf = 0;
            }
            else
            {
                if (bc <= tabela.Tirrf2)
                {
                    irrf = bc * (tabela.Airrf2 / 100) - tabela.Dirrf2;
                }
                else
                {
                    if (bc <= tabela.Tirrf3)
                    {
                        irrf = bc * (tabela.Airrf3 / 100) - tabela.Dirrf3;
                    }
                    else
                    {
                        if (bc <= tabela.Tirrf4)
                        {
                            irrf = bc * (tabela.Airrf4 / 100) - tabela.Dirrf4;
                        }
                        else
                        {
                            irrf = bc * (tabela.Airrf5 / 100) - tabela.Dirrf5;
                        }
                    }
                }
            }
            //Cálculo do Salário Líquido
            salliq = funcionario.Salario - inss + sf - vt - irrf;
        }


        public double Inss { get => inss; set => inss = value; }
        public double Sf { get => sf; set => sf = value; }
        public double Vt { get => vt; set => vt = value; }
        public double Salliq { get => salliq; set => salliq = value; }
        public double Irrf { get => irrf; set => irrf = value; }
        internal Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        internal Tabela Tabela { get => tabela; set => tabela = value; }
    }
}
