using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qui_2021_1_Lacos
{
    class Suporte
    {
        public String DiaSemana(int dia)
        {
            String[] sDias = { "Domingo", "Segunda",
                "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
            return sDias[dia - 1];
        }

        public String MesExtenso(int mes)
        {
            String[] sMeses = { "Janeiro", "Fevereiro",
                "Março", "Abril", "Maio", "Junho", "Julho",
                "Agosto","Setembro","Outubro","Novembro","Dezembro"};
            return sMeses[mes - 1];
        }
    }
}
