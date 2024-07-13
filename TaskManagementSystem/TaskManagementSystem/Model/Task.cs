// Task.cs
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public string Notes { get; set; }

    public int AssignedToUserId { get; set; }
    public User AssignedToUser { get; set; }

    public List<Document> Documents { get; set; } = new List<Document>();
}

// User.cs
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } // e.g., "Employee", "Manager", "Admin"

    public int TeamId { get; set; }
    public Team Team { get; set; }
}

// Team.cs
public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<User> Members { get; set; } = new List<User>();
}

// Document.cs
public class Document
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public byte[] Content { get; set; }

    public int TaskId { get; set; }
    public Task Task { get; set; }
}
