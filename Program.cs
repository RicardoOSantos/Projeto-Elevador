using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoElevador_Documentacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*O projeto trata-se da funcionalidade de um elevador, onde é solicitado quantos andares existem no prédio, a quantidade de pessoas suportadas,quantos andares existem no prédio, se deseja subir ou descer e
            qual andar deseja parar, são passadas informações de quando entra ou quando sai uma pessoa, e a quantidade máxima existente no momento.*/

            /*Para utiliza-lo é bem simples, será solicitado ao usuário as informações acima, de acordo com a capacidade e quantidade de andares no prédio, antes de começar a utilizar o elevador, ele irá ler os seus comandos e 
            identificar se algum dos itens excedeu o limite, ou se foi selecionado um andar inexistente, caso alguma informação seja inserida de forma incorreta ou execeda o limite, ele irá informar*/

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
