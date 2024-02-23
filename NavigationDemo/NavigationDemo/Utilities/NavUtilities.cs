using NavigationDemo.MVVM.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.Utilities
{
    public class NavUtilities
    {
        public static void Examine(INavigation navigation)
        {
            StringBuilder builder = new StringBuilder();
            foreach(var page in navigation.NavigationStack)
            {
                builder.AppendLine(page.GetType().Name);
            }

            builder.AppendLine("___________");
            Debug.WriteLine(builder.ToString());   
        }

        public static void InsertPage(INavigation navigation)
        {

            var secondPage = navigation.NavigationStack.ElementAtOrDefault(1);
            if(secondPage!=null)
            {
                navigation.InsertPageBefore(new DemoPage(), secondPage);
            }
        }
    }
}
