using Entity_Framework_Coreda_amaliyot.Model;

namespace Entity_Framework_Coreda_amaliyot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            //Console.WriteLine("Hello, World!");
            //Query();
            //QuerySubject();
            Teachers();
        }
        public static void Query()
        {
            // Vaqtni qabul qilmasa qabulqildirish kodi
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            EkundalikContext context = new EkundalikContext();
            Subject English = new();

            English.SubjectName = "Dasturlash";
            context.Subjects.Add(English);
            context.SaveChanges();
            Console.WriteLine("Amaliyot bajarildi");
            Console.Read();
        }
        public static void QuerySubject()
        {
            EkundalikContext context = new EkundalikContext();
            List<Subject> Allsubjects = context.Subjects.ToList();
            foreach (Subject subject in Allsubjects)
            {
                if(subject.SubjectName == "Dasturlash")
                {
                    context.Subjects.Remove(subject);
                }
                Console.WriteLine(subject.SubjectName);
            }
            context.SaveChanges();
            Console.Read();
        }
        public static void Teachers()
        {
            EkundalikContext context = new EkundalikContext();
            List<Teacher> AllTeachers = context.Teachers.ToList();
            foreach(Teacher teacher in AllTeachers)
            {
                Console.WriteLine($"Teachers: {teacher.ToString()}");
            }
        }
    }
}
