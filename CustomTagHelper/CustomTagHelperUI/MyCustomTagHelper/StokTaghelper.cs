using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelperUI.MyCustomTagHelper
{
    [HtmlTargetElement("Stok-Durum")]
    public class StokTaghelper : TagHelper
    {
        public int Stok { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";

            string renk;
            string mesaj;

            if (Stok > 20)
            {
                renk = "green";
                mesaj = $"Stok Durumu {Stok} adet - yeterli Adet var";
            }
            else if (Stok > 10)
            {
                renk = "orange";
                mesaj = $"Stok Durumu {Stok} adet - Kritik Durumda";
            }
            else
            {
                renk = "red";
                mesaj = $"Stok Durumu {Stok} adet - Bitti bitecek";
            }
            output.Attributes.SetAttribute("style", $"color:{renk}");
            output.Content.SetContent(mesaj);
        }

    }
}

