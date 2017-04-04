using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DynamicData_FieldTemplates_Image_Edit : System.Web.DynamicData.FieldTemplateUserControl
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

    protected override void ExtractValues(IOrderedDictionary dictionary)
    {
        dictionary[Column.Name] = Convert.FromBase64String(Image1.ImageUrl.Split(',').Last());
    }

    public override Control DataControl
    {
        get
        {
            return Image1;
        }
    }

    protected void btnUpload_OnClick(object sender, EventArgs e)
    {
        if (ImageFileUpload1.HasFile)
        {
            byte[] imageBytes = null;
            using (var binaryReader = new BinaryReader(ImageFileUpload1.PostedFile.InputStream))
            {
                imageBytes = binaryReader.ReadBytes(ImageFileUpload1.PostedFile.ContentLength);
            }

            Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(imageBytes);
        }
    }
}