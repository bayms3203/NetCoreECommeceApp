
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestMVCApp.libs.Application;
using TestMVCApp.libs.Data.Contexts;
using TestMVCApp.libs.Data.Entities;
using TestMVCApp.libs.Data.Repositories;
using TestMVCApp.Models;

namespace TestMVCApp.Controllers
{

    // dotnet new mvc --name=TestMVC --no-https => mvc proje açma komut
    // dotnet new web --name=TestRazorApp --no-https =>  razorpages proje açma komut


    // MVC LifeCyle
    // ilk istek controller a düşer
    // sonrasında ekranda yani view de (html,js,css olduğu sayfada) ekranda gösterilecek olan dinamik veriler (model) ile sayfalarımızı oluştururuz.

    // Home/Index
    // Home/Privacy
    // Home/Error
    // Controller/Action/Id

    public class TestController : Controller
    {



    }
}
