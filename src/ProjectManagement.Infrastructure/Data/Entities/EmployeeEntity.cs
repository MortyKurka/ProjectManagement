public class EmployeeEntity
{
    //Первичный ключ
    public int Id { get; set; }
    //Внешний ключ
    public int ProjectId { get; set; }
    //Навигационное свойство 
    //public ProjectEntity Project { get; set; }

    //Простые свойства
    public string? Name { get; set; }
    public string? WorkPass { get; set; }
    public int Role { get; set; }
    public string? Email { get; set; }
    
}