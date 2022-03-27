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
            /*O projeto trata-se da funcionalidade de um elevador, onde � solicitado quantos andares existem no pr�dio, a quantidade de pessoas suportadas,quantos andares existem no pr�dio, se deseja subir ou descer e
            qual andar deseja parar, s�o passadas informa��es de quando entra ou quando sai uma pessoa, e a quantidade m�xima existente no momento.*/

            /*Para utiliza-lo � bem simples, ser� solicitado ao usu�rio as informa��es acima, de acordo com a capacidade e quantidade de andares no pr�dio, antes de come�ar a utilizar o elevador, ele ir� ler os seus comandos e 
            identificar se algum dos itens excedeu o limite, ou se foi selecionado um andar inexistente, caso alguma informa��o seja inserida de forma incorreta ou execeda o limite, ele ir� informar*/

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
