using System;
using System.Collections.Generic;
using System.Linq;
using FileData;
using Microsoft.AspNetCore.Components;
using Models;

namespace BlazorAssignment.Pages
{
    public partial class AdultPage
    {
        [Parameter]
        public string Id { get; set; }
        private IList<Adult> _adultList;
        private Adult _adultModel;
      

        [Inject] private IFileContext FileContextProvider { get; set; }

        public void HandleValidSubmit()
        {
            Console.WriteLine(_adultModel.FirstName);
        }
        
        protected override void OnInitialized()
        {
      
            if (!string.IsNullOrEmpty(Id))
            {
                var id = -1;
                try
                {
                    int.TryParse(Id, out id);
                }
                catch (Exception)
                {
                    Console.WriteLine("Cannot parse");
                }
                finally
                {
                    if (id != -1)
                    {
                        _adultList = FileContextProvider.Adults;
                        _adultModel = _adultList.FirstOrDefault(adult => adult.Id == id);
                     
                    }
                }
                
            }
            else
            {
                _adultModel = new Adult();
            }
           StateHasChanged();
        }
        
    }
    

}