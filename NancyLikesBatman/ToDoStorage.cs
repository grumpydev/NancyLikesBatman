namespace NancyLikesBatman
{
    using System.Collections.Generic;
    using System.Linq;

    using NancyLikesBatman.Models;

    public class ToDoStorage : IToDoStorage
    {
        private IList<ToDo> database = new List<ToDo>();

        public ToDoStorage()
        {
            this.database.Add(new ToDo { id = 1, body = "Server added", isDone = false });
        }

        public IEnumerable<ToDo> GetAll()
        {
            return this.database.AsEnumerable();
        }

        public ToDo GetById(int id)
        {
            return this.database.Where(t => t.id == id).FirstOrDefault();
        }

        public ToDo Add(ToDo newItem)
        {
            newItem.id = this.database.Max(t => t.id) + 10;
            this.database.Add(newItem);
            return newItem;
        }

        public ToDo Update(ToDo updatedItem)
        {
            var item = this.database.Where(t => t.id == updatedItem.id).FirstOrDefault();

            if (item == null)
            {
                return null;
            }

            item.body = updatedItem.body;
            item.isDone = updatedItem.isDone;

            return item;
        }
    }
}