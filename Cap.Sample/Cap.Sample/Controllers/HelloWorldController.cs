namespace Cap.Sample.Controllers
{
    using DotNetCore.CAP;
    using Microsoft.AspNetCore.Mvc;
    using MongoDB.Driver;
    using System;

    [Route("[controller]")]
    [ApiController]

    public class HelloWorldController : ControllerBase
    {
        private readonly IMongoClient _client;
        private readonly ICapPublisher _capBus;

        public HelloWorldController(IMongoClient client, ICapPublisher capBus)
        {
            _client = client;
            _capBus = capBus;
        }

        public IActionResult Get()
        {
            _capBus.PublishAsync("HelloWorld", DateTime.Now);
            return Ok(DateTime.Now);
        }
    }
}
