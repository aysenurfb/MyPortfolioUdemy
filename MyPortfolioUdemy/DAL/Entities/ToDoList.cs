namespace MyPortfolioUdemy.DAL.Entities
{
    public class ToDoList
    {
        public int ToDoListId { set; get; }
        public string Tittle { set; get; }
        public string ImageUrl { set; get; }
        public DateTime Date { set; get; }
        public bool Status { set; get; }
    }
}
