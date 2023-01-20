using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace BRSK.Models
{
    public class PageModel
    {
      public int PageModelId { get; set; }
      public  SelectList BrandList { get; set; }

      public string ModelName { get; set; }
      public int SelectedBrand { get; set; }
      public bool Activity { get; set; }
    }
}
