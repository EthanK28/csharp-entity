using System;
using System.Web;



public class Path
{
    public string GetFilePath()
    {
        return HttpContext.Current.Server.MapPath("/UploadedFiles");
    }

    public static void Main()
    {
        Path path = new Path();
        //System.Console.WriteLine(path.GetFilePath());
        System.Console.WriteLine("Hello");
    }
}
