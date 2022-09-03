using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Specialized;
using System.Web;

namespace Server_Info.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;       
        public Dictionary<string, string> SelecionadosEnv = new Dictionary<string, string>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }             

        public void OnGet()
        {
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();

            SelecionadosEnv.Add("Machine Name", Environment.MachineName);
            SelecionadosEnv.Add("User Domain Name", Environment.UserDomainName);
            SelecionadosEnv.Add("User Name", Environment.UserName);
            SelecionadosEnv.Add("User Interactive", Environment.UserInteractive.ToString());
            SelecionadosEnv.Add("User OS Version", Environment.OSVersion.ToString());
            SelecionadosEnv.Add("Tick Count", (Environment.TickCount / (1000 * 60 * 60)) + " Hours");

            List<string> logical = Environment.GetLogicalDrives().ToList<string>();
            string result = "";
            foreach (string item in logical)
            {
                result = result + string.Format("{0}, ", item);
            }
            SelecionadosEnv.Add("Logical Drivers", result);
            




            foreach (DictionaryEntry de in environmentVariables)
            {
                if (
                    de.Key.ToString() != "Path"
                    //&& de.Key.ToString() != "PSModulePath"
                    //&& de.Key.ToString() != "DOTNET_STARTUP_HOOKS"
                    && de.Key.ToString() != "ASPNETCORE_AUTO_RELOAD_WS_KEY"
                    )
                {
                    SelecionadosEnv.Add(de.Key.ToString(), de.Value.ToString());

                    //EnvVariables.Add(string.Format("{0} = {1};", de.Key, de.Value));
                }

                //EnvVariables.Add(string.Format("{0} = {1};", de.Key, de.Value));
            }
        }



    }
}