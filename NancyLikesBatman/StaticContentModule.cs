namespace NancyLikesBatman
{
    using Nancy;

    public class StaticContentModule : NancyModule
    {
        public StaticContentModule()
        {
            Get["/scripts/{file}"] = x => Response.AsJs("Content/Scripts/" + (string)x.file);

            Get["/styles/{file}"] = x => Response.AsCss("Content/Styles/" + (string)x.file);
        }
    }
}