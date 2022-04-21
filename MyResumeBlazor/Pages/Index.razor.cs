using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MyResumeBlazor.Pages
{
    public partial class Index
    {
        /// <summary>
        /// personal tab
        /// </summary>
        private const int TAB_PERSONAL = 0;

        /// <summary>
        /// experience tab
        /// </summary>
        private const int TAB_EXPERIENCE = 1;

        /// <summary>
        /// Portfolio tab
        /// </summary>
        private const int TAB_PORTFOLIO = 2;

        /// <summary>
        /// Skills tab
        /// </summary>
        private const int TAB_SKILLS = 3;

        /// <summary>
        /// Other
        /// </summary>
        private const int TAB_OTHER = 4;

        /// <summary>
        /// Current tab
        /// </summary>
        private int CurrentTab { get; set; } = TAB_PERSONAL;

        /// <summary>
        /// CV
        /// </summary>
        private CVInfo? CV { get; set; }

        /// <summary>
        /// Indicates if there is an error
        /// </summary>
        private bool IsError { get; set; } = false;

        /// <summary>
        /// Http
        /// </summary>
        [Inject]
        private HttpClient? Http { get; set; }

        /// <summary>
        /// Loading
        /// </summary>
        private bool Loading { get; set; } = false;

        /// <summary>
        /// gets the current tab class
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        private string GetCurrentTabClass(int tab)
        {
            if (CurrentTab == tab)
            {
                return "tab-active";
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// sets the current tab
        /// </summary>
        /// <param name="tab"></param>
        private void SetCurrentTab(int tab)
        {
            if (tab != CurrentTab)
            {
                CurrentTab = tab;
            }
        }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                if (Http != null)
                {
                    CV = await Http.GetFromJsonAsync<CVInfo>("data/cv.json");
                }
            }
            catch
            {
                IsError = true;
            }
            finally
            {
                Loading = false;
                
            }
        }
    }
}
