namespace TODO_List_MVC.Models
{
    //класс модели для представления свойств списка дел
    public class ToDo
    {
        

        public int? Id { get; set; } //индефикатор дела
        public string? Name { get; set; } //Имя, кто создает задачу
        public string? Description { get; set; } // описание задачи

        public TimeOnly Time;
        public DateOnly Date;
        public DateTime dateTime { get; set; }

    }
}
