using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate.Data.Enum;

namespace WPFTemplate.Data.Model;

public class ViewsDataModel
{
    public int Index { get; set; }

    public string Name { get; set; }

    public bool IsSelected { get; set; }

    public string Remark { get; set; }

    public ViewsType Type { get; set; }

    public string ImgPath { get; set; }

    public List<ViewsDataModel> DataList { get; set; }
}