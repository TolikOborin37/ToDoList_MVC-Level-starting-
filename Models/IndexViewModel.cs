namespace TODO_List_MVC.Models
{
    //модель представления, в нее добавляется другие модели, когда необходимо в представление передавать несколько моделей
    public class IndexViewModel
    {
        public IndexViewModel(IEnumerable<ToDo> todo)
        {
            Todo = todo;
        }

        public IEnumerable<ToDo> Todo { get; set; } = new List<ToDo>();

    }
}
