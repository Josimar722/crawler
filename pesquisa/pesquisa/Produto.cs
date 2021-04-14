using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pesquisa
{
    [DebuggerDisplay("{Model}, {Img}")]
    class Produto
    {

        public string Model { get; set; }
      /*  public string Price { get; set; }

        public string Comentario { get; set; }*/

        public string Img { get; set; }
    }
}
