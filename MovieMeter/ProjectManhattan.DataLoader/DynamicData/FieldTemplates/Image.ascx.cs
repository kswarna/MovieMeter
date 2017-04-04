using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DynamicData_FieldTemplates_Image : System.Web.DynamicData.FieldTemplateUserControl
{
    protected override void OnDataBinding(EventArgs e)
    {
        base.OnDataBinding(e);

        object val = FieldValue;
        if (val != null)
        {
            var imageBytes = (byte[])val;
            string base64String = Convert.ToBase64String(imageBytes);
            Image1.ImageUrl = "data:image/png;base64," + base64String;
        }
    }

    public override Control DataControl
    {
        get { return Image1; }
    }
    
}