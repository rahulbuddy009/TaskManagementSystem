Task Management System Overview
The Task Management System is a web-based application designed to facilitate task tracking and management within an organization. It helps employees, team leaders, and company admins to efficiently manage and monitor tasks, ensuring productivity and accountability across different levels of the organization.

Key Features
Employee Task Management:

Task Tracking: Employees can track their respective tasks, view task details, and monitor progress.
Task Actions: Employees can perform various actions on tasks such as attaching documents, adding notes, and marking tasks as completed.
Manager/Team Leader Oversight:

Team Task Tracking: Managers or Team Leaders can view and track the tasks assigned to their respective team members.
Performance Monitoring: Allows managers to monitor the performance of their team in terms of task completion and deadlines.
Admin Reporting:

Performance Reports: Company admins can fetch reports to analyze how each team is performing. Reports can show task completion statistics for a week, a month, or any specified period.
Overall Monitoring: Provides a high-level overview of task management across the organization.
Technical Components
.NET Core Web API:

The backend of the application is built using .NET Core Web API. It provides RESTful endpoints for managing tasks, notes, documents, and employees.
Entity Framework Core:

Used for data access and database management. EF Core allows the application to perform CRUD operations on the database in an efficient manner.
Swagger:

Integrated Swagger UI for API documentation and testing. It provides a user-friendly interface to interact with the API endpoints, making it easier to test and debug the application.
System Architecture
Models:

Task: Represents a task with properties such as Name, Description, DueDate, IsCompleted, and relationships with Notes, Documents, and Employees.
Note: Represents a note attached to a task.
Document: Represents a document attached to a task.
Employee: Represents an employee with properties such as Name and relationships with tasks and other employees (team members).
Database Context:

TaskContext: Defines the DbSet properties for tasks, notes, documents, and employees. Configured to use SQL Server for data storage.
Controllers:

TasksController: Implements API endpoints for managing tasks. It includes endpoints for creating, retrieving, updating, and deleting tasks, as well as managing task notes and documents.
Example API Endpoints
GET /api/tasks: Retrieve all tasks.
GET /api/tasks/{id}: Retrieve a specific task by ID.
POST /api/tasks: Create a new task.
PUT /api/tasks/{id}: Update an existing task.
DELETE /api/tasks/{id}: Delete a task.
