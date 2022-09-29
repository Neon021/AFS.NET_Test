using AFS.NET_Test.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFS.NET_Test.Services
{
    public interface ITranslateService
    {
        Task<TranslateViewModel> Translate(TranslateViewModel _viewModel);
    }
}
