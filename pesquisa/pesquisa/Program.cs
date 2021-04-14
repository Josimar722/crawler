using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace pesquisa
{
    class Program
    {
       

        static void Main(string[] args)
        {
            startPesquisasync();
            Console.ReadLine();
        }
        private static async Task startPesquisasync()
        {
            var url = "https://www.giraffas.com.br/cardapio/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var produtos = new List<Produto>();
            var divs =
                htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("l-menu__categories-item c-highlight-box c-highlight-box--category")).ToList();

            foreach (var div in divs)
            {
                var Produto = new Produto
                {
                    Model = div.Descendants("h2").FirstOrDefault().InnerText,
                    Img = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value
                };
                produtos.Add(Produto);
            }
        }
    }


}
