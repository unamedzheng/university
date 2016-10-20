
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ContosoUniversity.Helpers;
namespace ContosoUniversity.Models
{
    public class FilesViewModel
    {
        public ViewDataUploadFilesResult[] Files { get; set; }
    }
}