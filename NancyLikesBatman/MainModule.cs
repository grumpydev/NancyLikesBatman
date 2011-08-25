namespace NancyLikesBatman
{
    using Nancy;

    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => View["alfred"];
        }
    }
}