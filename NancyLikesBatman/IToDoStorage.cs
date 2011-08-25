namespace NancyLikesBatman
{
    using System.Collections.Generic;

    using NancyLikesBatman.Models;

    public interface IToDoStorage
    {
        IEnumerable<ToDo> GetAll();

        ToDo GetById(int id);

        ToDo Add(ToDo newItem);

        ToDo Update(ToDo updatedItem);
    }
}