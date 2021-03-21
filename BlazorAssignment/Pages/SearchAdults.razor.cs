using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Components;
using Models;

namespace BlazorAssignment.Pages
{
    public partial class SearchAdults
    {

        [Inject] private IFileContext FileContextProvider { get; set; }
        
        [Inject] private NavigationManager _navigationManager { get; set; }

        private string _searchInputVal = "";
        private bool _val = true;
        private IList<Adult> _adultList;
        private IList<Adult> _adultListOriginal;

        protected override void OnInitialized()
        {
            _adultList = FileContextProvider.Adults;
            _adultListOriginal = _adultList;
        }

        public void Edit(int id)
        {
            _navigationManager.NavigateTo($"adult/{id.ToString()}");
        }

        private async Task Search()
        {
            var lowerCaseFieldValue = _searchInputVal.ToLower();
            _adultList = _adultListOriginal.Where(adult => adult.FirstName.ToLower().Contains(lowerCaseFieldValue)
                                                           || adult.LastName.ToLower().Contains(lowerCaseFieldValue)).ToList();
            await InvokeAsync(() => StateHasChanged())
                .ConfigureAwait(false);
        }

        public void Delete()
        {
            
        }
        

    }
}