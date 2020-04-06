namespace BeClassy
{
    public class Grade
    {
        /// <summary>
        /// Public string variable to hold the student's first name
        /// </summary>
        public string fName;
        /// <summary>
        /// public string variable to hold the student's last name
        /// </summary>
        public string lName;
        /// <summary>
        /// public string variable to hold the student's course code
        /// </summary>
        public string courseCode;
        /// <summary>
        /// public string variable to hold the student's letter grade for the course
        /// </summary>
        public string grade;
        /// <summary>

        // Constructor with parameters
        public Grade(string _fName, string lName, string _courseCode, string _grade)
        {
            fName = _fName;         // an approach to assign value to a variable name
            this.lName = lName;     // a clear and straightforward assignment to the variable name in class level.
            courseCode = _courseCode;
            grade = _grade;

        }


        // Default Constructor
        // public Grade()
        // {
        //     fName = "N/A";
        //     lName = "N/A";
        //     courseCode = "N/A";
        //     grade = "N/A";
        // }
    }
}