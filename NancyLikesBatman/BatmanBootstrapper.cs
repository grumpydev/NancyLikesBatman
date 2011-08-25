namespace NancyLikesBatman
{
    using System.Collections.Generic;

    using Nancy;
    using Nancy.Bootstrapper;

    public class BatmanBootstrapper : DefaultNancyBootstrapper
    {
        protected override void InitialiseInternal(TinyIoC.TinyIoCContainer container)
        {
            base.InitialiseInternal(container);
        }
    }
}