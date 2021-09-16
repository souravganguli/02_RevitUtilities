using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using System.Reflection;
using Autodesk.Revit.UI;


namespace MNC5D_Solutions
{
    public class UI_Utility : IExternalApplication
    {


        public Result OnStartup(UIControlledApplication application)
        {
            ///ADD Tab

            String Tabname = "5D VDC";
            try
            {
                application.CreateRibbonTab(Tabname);

            }
            catch (Exception)
            {
            }
         
 
            /// 03_Utilities
            {
                var DllPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "03_Utilities.dll");

                RibbonPanel PannelName = application.CreateRibbonPanel(Tabname,"Utility");          

                RevitLibary.UI.AddButton("AddParamters", Assembly.GetExecutingAssembly().Location, "Utilities.ParameterExtract", PannelName, "01_Resources(Utilities)\\02_Images\\I.png");               
                RevitLibary.UI.AddButton("JoinGeometry", Assembly.GetExecutingAssembly().Location, "Utilities.Join", PannelName, "01_Resources(Utilities)\\02_Images\\J.png");
                RevitLibary.UI.AddButton("Transfer", Assembly.GetExecutingAssembly().Location, "Utilities.PT", PannelName, "01_Resources(Utilities)\\02_Images\\T.png");

                PannelName.AddSlideOut();
                RevitLibary.UI.AddButton("Switch Join", Assembly.GetExecutingAssembly().Location, "Utilities.SwitchJoin", PannelName, "01_Resources(Utilities)\\02_Images\\switch.png");

            }

            return Result.Succeeded;

          
            
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            // do nothing
            // return result.succeeded


            return Result.Succeeded;
        }
    }
}
