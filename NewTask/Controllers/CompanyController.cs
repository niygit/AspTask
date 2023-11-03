using Microsoft.AspNetCore.Mvc;
using NewTask.Models;
using NewTask.ViewModels;
using System;

namespace NewTask.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            Company company = new Company()
            {
                CompanyName = "Azersun",
                Descripton = "Description1",
                Founded = DateTime.Now,
                CompanyAdress = "Baku"
            };
            Partner partners = new Partner()
            {
                Name="QarabagFK",
                Adress="Zerbaijan,Agdam"
            };

            CompanyViewModel companyViewModel = new CompanyViewModel()
            {
                company=company,
                partner=partners
            };


            return View(companyViewModel);
        }
    }
}
