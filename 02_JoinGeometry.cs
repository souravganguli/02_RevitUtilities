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
    class Join : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument MyDoc = commandData.Application.ActiveUIDocument;
            Document ActiveDoc = MyDoc.Document;

            IList <ElementId> IL = MyDoc.Selection.GetElementIds() as IList<ElementId>;

            using (Transaction TT = new Transaction(ActiveDoc, "JoinGeometry"))
            {
                TT.Start();
            

                foreach (ElementId item in IL)
            {
                Element E = ActiveDoc.GetElement(item);

                    IList<Element> IntersectingElements;

                    try
                    {

                   
                     IntersectingElements = RevitLibary.GeometeryTools.SuperGetElementBoundingBox(E, commandData);

                    }
                    catch (Exception)
                    {

                        IntersectingElements = null;
                    }

                    if (IntersectingElements != null)
                    {
                        foreach (Element EI in IntersectingElements)
                        {

                            try
                            {
                                if (_02_RevitUtilities._01_Resources_Utilities_._03_Settings.JoinGeometry.Default.JoinOrder)
                                {

                                    JoinGeometryUtils.JoinGeometry(ActiveDoc, EI, E);
                                    JoinGeometryUtils.SwitchJoinOrder(ActiveDoc, EI, E);
                                }
                                else
                                {

                                    JoinGeometryUtils.JoinGeometry(ActiveDoc, E, EI);
                                }

                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
            }

                TT.Commit();

              
            }

            return Result.Succeeded;
        }

    }

    [TransactionAttribute(TransactionMode.Manual)]
    class SwitchJoin : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

           if(_02_RevitUtilities._01_Resources_Utilities_._03_Settings.JoinGeometry.Default.JoinOrder)
            {
                _02_RevitUtilities._01_Resources_Utilities_._03_Settings.JoinGeometry.Default.JoinOrder = false;
            }
           else
            {
                _02_RevitUtilities._01_Resources_Utilities_._03_Settings.JoinGeometry.Default.JoinOrder = true;
            }


            _02_RevitUtilities._01_Resources_Utilities_._03_Settings.JoinGeometry.Default.Save();


            

            return Result.Succeeded;
        }
    }
}
