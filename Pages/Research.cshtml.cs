using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_RazorPages.Models;

namespace NET_RazorPages.Pages
{
    public class Research : PageModel
    {
        //Properties
        public List<ResearchModel> ResearchList;
        public bool IsLoading;

        public void OnGet(int page=1)
        {
            //Create list
            ResearchList = new List<ResearchModel>();

            //
            ResearchList.Add(new ResearchModel() { Title = "Depressief", Author = "Marc Vertonghen", Url = "htttp://fcdekampioenen/Depressief",Pages=73});
            ResearchList.Add(new ResearchModel() { Title = "De nieuwe kampioen", Author = "Oscar Crucke", Url = "htttp://fcdekampioenen/denieuwekampioen",Pages=94});
            ResearchList.Add(new ResearchModel() { Title = "De elfde man", Author = "Bieke Crucke", Url = "htttp://fcdekampioenen/deelfdeman",Pages=45});
            ResearchList.Add(new ResearchModel() { Title = "De schat", Author = "Dimitri De Tremmerie", Url = "htttp://fcdekampioenen/deschat",Pages=23});
            ResearchList.Add(new ResearchModel() { Title = "Besmet", Author = "Balthasar boma", Url = "htttp://fcdekampioenen/besmet",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "De motorfiets", Author = "Marc Vertonghen", Url = "htttp://fcdekampioenen/demotorfiets",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "FC Championettes", Author = "Balthasar boma", Url = "htttp://fcdekampioenen/fcdechampionettes",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "Verwisselingen", Author = "Fernand Costermans", Url = "htttp://fcdekampioenen/verwisselingen",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "De aanranding", Author = "Oscar crucke", Url = "htttp://fcdekampioenen/deaanranding",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "DDT niet oke", Author = "Xavier Waterslaeghers", Url = "htttp://fcdekampioenen/Ddtnietoke",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "Carmens wasmachine", Author = "Pico coppens", Url = "htttp://fcdekampioenen/Carmenswasmachine",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "Bieke solo", Author = "Carmen Waterslaeghers", Url = "htttp://fcdekampioenen/Biekesolo",Pages=72});
            ResearchList.Add(new ResearchModel() { Title = "Pol in de put", Author = "Pascal De Backer", Url = "htttp://fcdekampioenen/Polindeput",Pages=72});


        }





    }
}
