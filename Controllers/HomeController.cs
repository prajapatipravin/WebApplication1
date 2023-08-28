using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }

        //public HttpContent Privacy()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Thread.Sleep(2000);
        //    }
        //    return OkResult();
        //}

        //public HttpResponseMessage Get(int id)
        // {
        //     Student stud = GetStudentFromDB(id);

        //     if (stud == null)
        //     {
        //         return Request.CreateResponse(HttpStatusCode.NotFound, id);
        //     }

        //     return Request.CreateResponse(HttpStatusCode.OK, stud);
        // }
        public IHttpActionResult SomeAction()
        {
            IHttpActionResult response;
            //we want a 303 with the ability to set location
            HttpResponseMessage responseMsg = new HttpResponseMessage();
            responseMsg.StatusCode = HttpStatusCode.OK;
            responseMsg.Headers.Location = new Uri("http://customLocation.blah");
            responseMsg.Content. = "any result";
            return Ok( response);
        }
        //public HttpResponseMessage Get(int id)

        //{
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //    var result = "hello worlds";

        //    if (result != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, result);

        //    return Request.CreateResponse(HttpStatusCode.NotFound);

        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}