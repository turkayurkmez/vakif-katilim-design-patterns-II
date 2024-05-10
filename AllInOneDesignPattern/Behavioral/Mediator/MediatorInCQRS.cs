using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CreateNewProductCommand
    {

    }

    public class CrateNewProductCommandHandler
    {
        public void Handle(CreateNewProductCommand command)
        {
            Console.WriteLine("Ürün Eklendi");
        }
    }
}
