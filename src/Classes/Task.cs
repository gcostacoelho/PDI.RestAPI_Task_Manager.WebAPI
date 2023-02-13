namespace PDI.RestAPI_Task_Manager.WebAPI.src.Classes
{
    public class Task
    {
        public Task(int id, String nome_tarefa, String descricao, DateOnly data_entrega, Boolean concluido = false)
        {
            this.id = id;
            this.nome_tarefa = nome_tarefa;
            this.descricao = descricao;
            this.data_entrega = data_entrega;

            this.concluido = concluido;
        }
        public int id { get; set; }
        public String nome_tarefa { get; set; }
        public String descricao { get; set; }
        public DateOnly data_entrega { get; set; }
        public Boolean concluido { get; set; }
    }
}