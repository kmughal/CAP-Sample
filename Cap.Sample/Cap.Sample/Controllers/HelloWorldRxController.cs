using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;

namespace Cap.Sample.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HelloWorldRxController : ControllerBase
    {
        [CapSubscribe("HelloWorld")]
        public void Handle(DateTime datetime)
        {
            Console.WriteLine(datetime);
        }
    }
}
