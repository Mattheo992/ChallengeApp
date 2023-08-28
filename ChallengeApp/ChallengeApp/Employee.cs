namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {

                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Avarage += grade;
                }
            }
            statistics.Avarage = statistics.Avarage / this.grades.Count;
            return statistics;

        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarage += grade;
            }
            statistics.Avarage = statistics.Avarage / this.grades.Count;
            return statistics;
        }
        public Statistics GetStaticticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var grade = 0; grade < this.grades.Count; grade++)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarage += grade;
            }
            statistics.Avarage = statistics.Avarage / this.grades.Count;
            return statistics;
        }

        public Statistics GetStaticticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int grade = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Avarage += this.grades[grade];
                grade++;
            } while (grade < this.grades.Count);
            statistics.Avarage = statistics.Avarage / this.grades.Count;
            return statistics;
        }

        public Statistics GetStaticticsWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int grade = 0;

            while (grade < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Avarage += this.grades[grade];
                grade++;
            }
            statistics.Avarage = statistics.Avarage / this.grades.Count;
            return statistics;
        }
    }
}

