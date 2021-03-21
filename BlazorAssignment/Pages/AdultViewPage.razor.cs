using FileData;
using Microsoft.AspNetCore.Components;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Pages
{

    public partial class AdultViewPage
    {
        [Inject] private IFileContext FileContextProvider { get; set; }

        public Adult _adultModel;
        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            var _adultList = FileContextProvider.Adults;

            _adultModel = _adultList.FirstOrDefault(x => x.Id == Id);
   
            
        }
    }
}
