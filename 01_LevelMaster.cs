
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RevitFreeFormElement = Autodesk.Revit.DB.FreeFormElement;
using View = Autodesk.Revit.DB.View;


namespace Utilities
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class ParameterExtract : IExternalCommand
    {

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)

        {

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


            using (Transaction Info = new Transaction(ActiveDoc, "Add IfcParameters"))
            {
                Info.Start();         
                
                foreach (Element E in ElementsToProcess)
                {

                    //// Ifc Level
                    try
                    {                   
                        {

                            String Level = RevitLibary.DataTools.GetElementLevel(E, ActiveDoc);
                            Parameter ParameterToBeSet = E.LookupParameter("IfcLevel");

                            if (ParameterToBeSet.HasValue)
                            {

                                string S = RevitLibary.DataTools.GetParameterValueByName(E, "IfcLevel");
                                if (S.Length == 0)
                                {
                                    ParameterToBeSet.Set(Level);
                                }
                            }
                            else
                            {
                                ParameterToBeSet.Set(Level);
                            }
                        }
                    }
                    catch (Exception)
                    {


                    }
                    ////IfcGuid
                    try
                    {
                        
                        {

                            String IfcGuid = E.UniqueId;
                            Parameter ParameterToBeSet = E.LookupParameter("Backup.Assemble.Guid");
                            ParameterToBeSet.Set(IfcGuid);
                        }
                    }
                    catch (Exception)
                    {
                     
                    }
                    ////IfcVolume1
                    try
                    {

                        Parameter ParameterToGet = E.LookupParameter("Area");
                        double ParameterValue = ParameterToGet.AsDouble();

                        Parameter ParameterToBeSet = E.LookupParameter("IfcArea");
                        ParameterToBeSet.Set(ParameterValue);
                    }
                    catch (Exception)
                    {


                    }
                    ///IfcVolume
                    try
                    {
                        List<ElementId> MaterialID = E.GetMaterialIds(false) as List<ElementId>;
                        Double Volume = 0;

                        foreach (ElementId MI in MaterialID)
                        {
                            Volume = Volume + E.GetMaterialVolume(MI);
                        }

                        Parameter ParameterToBeSet = E.LookupParameter("IfcVolume");
                        ParameterToBeSet.Set(Volume);
                    }
                    catch (Exception)
                    {
                      
                    }
                    ///IfcArea
                    try
                    {

                        Parameter ParameterToGet = E.LookupParameter("Volume");
                        double ParameterValue = ParameterToGet.AsDouble();

                        Parameter ParameterToBeSet = E.LookupParameter("IfcVolume");
                        ParameterToBeSet.Set(ParameterValue);
                    }
                    catch (Exception)
                    {


                    }



                    ////PipeLength
                    try
                    {

                        Parameter ParameterToGet = E.LookupParameter("Length");
                        double ParameterValue = ParameterToGet.AsDouble();

                        Parameter ParameterToBeSet = E.LookupParameter("IfcLength");
                        ParameterToBeSet.Set(ParameterValue);
                    }
                    catch (Exception)
                    {


                    }
                    //// PipeSize
                    try
                    {
                        Parameter ParameterToGet = E.LookupParameter("Diameter");
                        double ParameterValue = ParameterToGet.AsDouble();

                        Parameter ParameterToBeSet = E.LookupParameter("IfcPipeSize");
                        ParameterToBeSet.Set(ParameterValue.ToString());
                    }
                    catch (Exception)
                    {


                    }
                }
                Info.Commit();
            }


            TaskDialog.Show("IfcParamterAdder", "Ifc Parameter Added");
            return Result.Succeeded;

        }


        static void SetInstanceParamVaryBetweenGroupsBehaviour(Document doc,Guid guid,bool allowVaryBetweenGroups = true)
        {
            try // last resort
            {
                SharedParameterElement sp
                  = SharedParameterElement.Lookup(doc, guid);

                // Should never happen as we will call 
                // this only for *existing* shared param.

                if (null == sp) return;

                InternalDefinition def = sp.GetDefinition();

                if (def.VariesAcrossGroups != allowVaryBetweenGroups)
                {
                    // Must be within an outer transaction!

                    def.SetAllowVaryBetweenGroups(doc, allowVaryBetweenGroups);
                }
            }
            catch { } // ideally, should report something to log...
        }


    }
}