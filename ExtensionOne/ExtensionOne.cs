using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;

namespace ExtensionOne
{
    class App : IExternalApplication
    {
        // define a method that will create our tab and button
        static void AddRibbonPanel(UIControlledApplication application)
        {
            // Create a custom ribbon tab
            String tabName = "ExtensionOne";
            application.CreateRibbonTab(tabName);

            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel(tabName, "PanelOne");

            // Get dll assembly path
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            // Create push button for Hello!
            PushButtonData b1Data = new PushButtonData(
                "Hello!",
                "Hello!!",
                thisAssemblyPath,
                "ExtensionOne.PushButtonOneCommand");

            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Say Hello!";
            BitmapImage pb1Image = new BitmapImage(new Uri("C:/Revit API/ExtensionOne/ExtensionOne/Resources/icon1.png"));
            pb1.LargeImage = pb1Image;

            // Create push button for Document Selection!
            PushButtonData b2Data = new PushButtonData(
                "Element Selection!",
                "Element Selection!!",
                thisAssemblyPath,
                "ExtensionOne.PushButtonTwoCommand");

            PushButton pb2 = ribbonPanel.AddItem(b2Data) as PushButton;
            pb2.ToolTip = "Retrieve element IDs of selected elements.";
            BitmapImage pb2Image = new BitmapImage(new Uri("C:/Revit API/ExtensionOne/ExtensionOne/Resources/icon2.png"));
            pb2.LargeImage = pb2Image;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            // Do nothing
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // Call our method that will load up our toolbar
            AddRibbonPanel(application);
            return Result.Succeeded;
        }
    }
}