namespace BigO_Notation.Algorithms
{
    using System;
    using System.Collections.Generic;

    public class HashTableDictionaryExample
    {
        private Dictionary<string, Student> _dictionary;

        public HashTableDictionaryExample()
        {
            _dictionary = new Dictionary<string, Student>();
            AddStudents();
            Display();
        }

        /// <summary>
        /// Removes specific value from the current dictionary
        /// </summary>
        public void Remove()
        {
            Console.WriteLine("\n\n Enter key for Remove: \n");
            string key = Console.ReadLine();
            bool isRemoved = _dictionary.Remove(key);

            if(isRemoved)
            {
                Console.WriteLine(string.Format("Key Remove: {0}",key));
            }
            else
            {
                Console.WriteLine("\n Does not Exist");
            }
            Display();
        }

        /// <summary>
        /// Searches for specific key inside the current dictionary
        /// </summary>
        /// <returns></returns>
        public bool Get()
        {
            Console.WriteLine("\n\n Enter key for Search: \n");
            string key = Console.ReadLine();

            bool isFound = false;
            Student student;

            if(this._dictionary.TryGetValue(key,out student))
            {
                Console.WriteLine(string.Format("Key: {0}, Student FName: {1}, Student LName: {2}, Student Course: {3}", key, student.FirstName, student.LastName, student.CourseID));
                isFound = true;
            }
            else
            {
                Console.WriteLine("\n Does not Exist");
            }

            return isFound;
        }

        /// <summary>
        /// Displays current dictionary key and values
        /// </summary>
        private void Display()
        {
            foreach(KeyValuePair<string,Student> kvp in this._dictionary)
            {
                Console.WriteLine(string.Format("Key: {0}, Student FName: {1}, Student LName: {2}, Student Course: {3}", kvp.Key, kvp.Value.FirstName, kvp.Value.LastName, kvp.Value.CourseID));
            }
        }

        /// <summary>
        /// Pre populates the students objects.
        /// </summary>
        private void AddStudents()
        {
            //prepopulate dictionary with few students
            Student stu = new Student("Tina", "Brownfield","1", "csi-155");
            stu.AddGrade(98);
            stu.AddGrade(89);
            stu.AddGrade(95);
            //Add student to the Dictionary
            this._dictionary.Add(stu.ID, stu);
            stu = new Student("Scott", "Kennedy", "2", "csi-155");
            stu.AddGrade(60);
            stu.AddGrade(79);
            stu.AddGrade(50);
            //Add student to the Dictionary
            this._dictionary.Add(stu.ID, stu);
            stu = new Student("Michele", "Madsen", "3", "csi-155");
            stu.AddGrade(98);
            stu.AddGrade(99);
            stu.AddGrade(90);
            //Add student to the Dictionary
            this._dictionary.Add(stu.ID, stu);
            stu = new Student("Kevin", "Riley", "4", "csi-155");
            stu.AddGrade(93);
            stu.AddGrade(100);
            stu.AddGrade(95);
            //Add student to the Dictionary
            this._dictionary.Add(stu.ID, stu);
        }
    }

    #region Students Class
    public class Student
    {
        private string _firstname;
        private string _lastname;
        private string _id;
        private string _courseid;
        private List<int> _grades;
        //constructor
        public Student(string firstname, string lastname, string id, string courseid)
        {
            this._courseid = courseid;
            this._firstname = firstname;
            this._lastname = lastname;
            this._id = id;
            this._grades = new List<int>();
        }

        //properties
        public string FirstName
        { get { return this._firstname; } }
        public string LastName
        { get { return this._lastname; } }
        public string ID
        { get { return this._id; } }
        public string CourseID
        { get { return this._courseid; } }
        public int[] Grades
        { get { return this._grades.ToArray(); } }
        public int Count
        { get { return this._grades.Count; } }
        //method
        public void AddGrade(int grade)
        {
            _grades.Add(grade);
        }
        //
        public float GetAverageGrade()
        {
            float sum = 0;
            foreach (int g in _grades)
            {
                sum += g;
            }
            return sum / Count;
        }
    }

    #endregion
}
