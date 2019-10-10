namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;
        public TodoItem (string Titulo, string Nota){ // construtor tem que ter o nome igual da classe. Construtor não tem tipo de retorno, pois ele instancia uma classe e retorna o objeto
            this.Titulo = Titulo;
            this.Nota = Nota;
        }
    }
}