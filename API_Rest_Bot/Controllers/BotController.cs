using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Rest_Bot.Models;

namespace API_Rest_Bot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        [HttpGet]
        public object get()
        {


            var body = new
            {

                MinhaHistoria = new[]
               {
                   new
                   {
                     Part1 = "Era uma vez um menino todo errado, ele andava pela rua de skate todo desastrado, mas certa vez ele parado percebeu uma menina dentro de um carro, então logo veio um estalo, na sua mente que é um baralho lembrou de uma menina que ele era apaixonado então ele ficou todo emocionado chefou perto do carro e logo ela olhou e derrepente tambem lembrou e o sorriso se estampou",
                     EntaoElaFalou = "Nossa a quanto tempo ",
                     part2= "E então meu coração aquece lembrando dos momentos de amizade que sempre me enlouquece, e eu do lado de fora querendo que ela descesse, então seu pai chega aos nervos perguntando quem é esse fedelho e logo me da um medo e logo ele acelare e meu coração se desespera achando que eu nunca mais ha veria    "
                   }
               },
                Moral = new[]
                {
                    new
                    {
                         NãoSeDesespere="Hoje em dia quem diria eu to com ela a mais obra-prima enquanto a mente oprimia Deus logo fazia então pode ate ser fantasia mas é apenas a minha vida"
                    }
                }


            };

            return new JsonResult(body);

        }


        [HttpPost]
        public object post(BotRequest bot)
        {
            var principe = bot.principe;
            var princesa = bot.princesa;
            var vilao2 = bot.vilão;

          


            //var teste = principe + "É Lindo";

            var body = new
            {
                MinhaHistoria = new[]
                {
                   new
                   { 
                       Era_Uma_Vez = "Uma linda princesa que se chama " + princesa + ", e um dia ela conheceu um principe chamado " + principe + ", e eles estavam caminhando pelo pelo bosque quando derrepente uma bruxa apareceu e disse",
                    
                   }
                },




            };

            return new JsonResult(body);


        }
    }
}
