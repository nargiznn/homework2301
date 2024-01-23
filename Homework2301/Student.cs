using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Homework2301
{
	public class Student
	{
		public Student()
		{
		}
        private string _name;
        private string _surname;
        private string _fullname;
        private string _groupNo;
        private byte _age;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public byte Age
        {
            get => _age;
            set => _age = value;
        }

        public string Fullname
        {
            get => _fullname;
            set
            {
                if (CheckFullname(Name, Surname))
                    _fullname = value;
                _fullname = Name + " " + Surname;
            }
        }
 
		public string GroupNo
		{
			get => _groupNo;
			set
			{
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }

		}

       public static bool CheckGroupNo(string groupNo)
        {
           
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4) return false;
            if (!char.IsUpper(groupNo[0]))
                return false;
            if (!char.IsLetter(groupNo[0])) return false;
			 for (int i = 1; i < 4; i++)
        {
            if (!char.IsDigit(groupNo[i])) return false;
        }
            return true;
		}

        public static bool CheckFullname(string name,string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                return false;

            for (int i = 0; i < name.Length; i++)
			{
				if (!char.IsLetter(name[i])) return false;

			}
            for (int i = 0; i < surname.Length; i++)
            {
                if (!char.IsLetter(surname[i])) return false;

            }
          
            return true;

        }
		
    }
}

