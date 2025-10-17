// Three DEMO sections are provided in the code.
// Comment out and uncomment different DEMO Sections to see diffrent outputs.
using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class Example
{
    public static void Main()
    {
        //DEMO1: 
        //DateTime now = DateTime.Now;
        //Console.WriteLine("Current Date and Time: " + now.ToString("F"));

        //DEMO 2:
        DateTime localDate = DateTime.Now;
        String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            Console.WriteLine("{0}: {1}", cultureName,
                              localDate.ToString(culture));
        }

        // DEMO 3:
        //DateTime localDate = DateTime.Now;
        //DateTime utcDate = DateTime.UtcNow;
        //String[] cultureNames = { "en-US", "en-GB", "fr-FR",
        //                        "de-DE", "ru-RU" };

        //foreach (var cultureName in cultureNames)
        //{
        //    var culture = new CultureInfo(cultureName);
        //    Console.WriteLine("{0}:", culture.NativeName);
        //    Console.WriteLine("   Local date and time: {0}, {1:G}",
        //                      localDate.ToString(culture), localDate.Kind);
        //    Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
        //                      utcDate.ToString(culture), utcDate.Kind);
        //}
    }
}