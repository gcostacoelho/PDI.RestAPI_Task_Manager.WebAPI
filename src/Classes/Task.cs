namespace PDI.RestAPI_Task_Manager.WebAPI.src.Classes
{
    public class Task
    {
        public int id { get; set; }
        public String nome_tarefa { get; set; }
        public String descricao { get; set; }
        public DateOnly data_entrega { get; set; }
        public DateOnly data_conclusao { get; set; }
        public Boolean concluido { get; set; }
    }
}