using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Application.Commons
{
    public class Response
    {
        public int status { get; private set; }
        public object obj { get; private set; }


        public Response(int status, object obj)
        {
            this.status = status;
            this.obj = obj;
        }

    }
}
