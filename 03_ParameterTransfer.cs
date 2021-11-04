using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

namespace Utilities
{
   
        [TransactionAttribute(TransactionMode.Manual)]
        class PT: IExternalCommand
        {
            public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
            {
          
                UtilityForms.ParameterTransfer PT = new UtilityForms.ParameterTransfer();
                PT.ShowDialog();            

                       

            if (PT.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                
                return Result.Cancelled;
            }


                #region/////Intro

                ////Define Standard Variables
                UIDocument MyDoc = commandData.Application.ActiveUIDocument;
                Document ActiveDoc = MyDoc.Document;
                UIApplication uiApp = commandData.Application;


                ////Define Output Variables
                List<ElementId> ErrorList = new List<ElementId>();

                #endregion



                #region////Collect Elements to Process               

                FilteredElementCollector ElementsToProcess = new FilteredElementCollector(ActiveDoc, ActiveDoc.ActiveView.Id).WhereElementIsNotElementType();

                #endregion

                String ParameterToCopyFrom = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyFrom;
                String ParameterToCopyTo = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterToCopyTo;
                String ProcessGroups = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.Groups;
                String ParameterType = _02_RevitUtilities._01_Resources_Utilities_._03_Settings.ParameterTransfer.Default.ParameterType;



                if (ParameterToCopyFrom != null || ParameterToCopyTo != null)
                {
                    using (Transaction Info = new Transaction(ActiveDoc, "Transfer Parameter"))
                    {
                        Info.Start();

                        foreach (Element E in ElementsToProcess)
                        {                       
                            try
                            {
                           
                            if (ParameterType == "Instance")
                                {
                              

                                if (E.GroupId.IntegerValue == -1 || E.GroupId.IntegerValue != -1 && ProcessGroups == "Yes")
                                    {                                    
                                    String CopiedValue = RevitLibary.DataTools.GetParameterValueByName(E, ParameterToCopyFrom);
                                                                                  


                                    RevitLibary.DataTools.SetParameterByName(E, ParameterToCopyTo, CopiedValue, ActiveDoc);                                    
                                    }



                                }
                                if (ParameterType == "Type")
                                {
                               
                                ElementType ET = ActiveDoc.GetElement(E.GetTypeId()) as ElementType;

                                         String CopiedValue = RevitLibary.DataTools.GetParameterValueByName(ET, ParameterToCopyFrom);
                                        RevitLibary.DataTools.SetParameterByName(ET, ParameterToCopyTo, CopiedValue, ActiveDoc);
                                    
                                }
                            }
                            catch (Exception)
                            {


                           

                            }

                        }
                        Info.Commit();
                    }


                    TaskDialog.Show("Parameter Transferer", "Parameters transferred");
                    return Result.Succeeded;
                }


                return Result.Failed;
            }

        }

   
}
