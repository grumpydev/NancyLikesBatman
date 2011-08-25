namespace NancyLikesBatman
{
    using Nancy;
    using Nancy.ModelBinding;

    using NancyLikesBatman.Models;

    public class ToDoModule : NancyModule
    {
        public ToDoModule(IToDoStorage toDoStorage) : base("/todos")
        {
            Get["/"] = _ => Response.AsJson(toDoStorage.GetAll());

            Put["/"] = _ =>
                {
                    ToDo item = this.Bind();

                    if (item == null)
                    {
                        return HttpStatusCode.UnsupportedMediaType;
                    }

                    return Response.AsJson(toDoStorage.Add(item));
                };

            Post["/{id}"] = x =>
                {
                    ToDo item = this.Bind("id");

                    if (item == null)
                    {
                        return HttpStatusCode.UnsupportedMediaType;
                    }

                    item.id = x.id;
                    return Response.AsJson(toDoStorage.Update(item));
                };
        }
    }
}