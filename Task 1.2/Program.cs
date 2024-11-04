using System;


    public interface ITask
    {
        void Start();
        void Complete();
        string GetTaskInfo();
    }

    public class WorkTask : ITask
    {
        public string Title { get; set; }
        public bool IsStarted { get; private set; }
        public bool IsCompleted { get; private set; }

        public WorkTask(string title)
        {
            Title = title;
        }

        public void Start()
        {
            IsStarted = true;
            Console.WriteLine($"{Title}: Завдання розпочато.");
        }

        public void Complete()
        {
            if (IsStarted)
            {
                IsCompleted = true;
                Console.WriteLine($"{Title}: Завдання завершено.");
            }
            else
            {
                Console.WriteLine($"{Title}: Завдання не можна завершити, оскільки воно не розпочате.");
            }
        }

        public string GetTaskInfo()
        {
            return $"Work Task: {Title} - Статус: {(IsCompleted ? "Завершено" : IsStarted ? "Розпочато" : "Не розпочато")}";
        }
    }

    public class PersonalTask : ITask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsStarted { get; private set; }
        public bool IsCompleted { get; private set; }

        public PersonalTask(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void Start()
        {
            IsStarted = true;
            Console.WriteLine($"{Title}: Особисте завдання розпочато.");
        }

        public void Complete()
        {
            if (IsStarted)
            {
                IsCompleted = true;
                Console.WriteLine($"{Title}: Особисте завдання завершено.");
            }
            else
            {
                Console.WriteLine($"{Title}: Завдання не можна завершити, оскільки воно не розпочате.");
            }
        }

        public string GetTaskInfo()
        {
            return $"Personal Task: {Title} - {Description} - Статус: {(IsCompleted ? "Завершено" : IsStarted ? "Розпочато" : "Не розпочато")}";
        }
    }

    public class StudyTask : ITask
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public bool IsStarted { get; private set; }
        public bool IsCompleted { get; private set; }

        public StudyTask(string title, string subject)
        {
            Title = title;
            Subject = subject;
        }

        public void Start()
        {
            IsStarted = true;
            Console.WriteLine($"{Title}: Навчальне завдання розпочато.");
        }

        public void Complete()
        {
            if (IsStarted)
            {
                IsCompleted = true;
                Console.WriteLine($"{Title}: Навчальне завдання завершено.");
            }
            else
            {
                Console.WriteLine($"{Title}: Завдання не можна завершити, оскільки воно не розпочате.");
            }
        }

        public string GetTaskInfo()
        {
            return $"Study Task: {Title} - Предмет: {Subject} - Статус: {(IsCompleted ? "Завершено" : IsStarted ? "Розпочато" : "Не розпочато")}";
        }
    }

    public class TaskManagerTest
    {
        public static void Main()
        {
            ITask task1 = new WorkTask("Робоче завдання");
            ITask task2 = new PersonalTask("Особисте завдання", "Придбати продукти");
            ITask task3 = new StudyTask("Навчальне завдання", "Математика");

            task1.Start();
            task1.Complete();
            Console.WriteLine(task1.GetTaskInfo());

            Console.WriteLine();

            task2.Start();
            task2.Complete();
            Console.WriteLine(task2.GetTaskInfo());

            Console.WriteLine();

            task3.Start();
            task3.Complete();
            Console.WriteLine(task3.GetTaskInfo());
        }
    }


