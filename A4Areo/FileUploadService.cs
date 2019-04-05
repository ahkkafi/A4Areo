using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo
{
 public class FileUploadService 
    {
        //private string Directory { get; set; }
        //public void LoadDirectory(string directory)
        //{
        //    Directory = directory;
        //}

        //public string UploadFile(System.Web.HttpPostedFileBase file, string fileName = null)
        //{
        //    try
        //    {
        //        if (file != null)
        //        {
        //            if (string.IsNullOrEmpty(fileName))
        //            {
        //                fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        //            }
        //            var path = Path.Combine(HostingEnvironment.MapPath(this.Directory), fileName);
        //            file.SaveAs(path);
        //            return fileName;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    return null;
        //}

        //public bool DeleteFile(string fileName)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(fileName))
        //            return false;
        //        var path = Path.Combine(HostingEnvironment.MapPath(this.Directory), fileName);
        //        FileInfo file = new FileInfo(path);

        //        if (file.Exists)
        //        {
        //            file.Delete();
        //            return true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    return false;
        //}
    }
}
