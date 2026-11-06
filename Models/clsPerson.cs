using System;
using System.Linq;

namespace Models
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public int NationalID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int CountryID { get; set; }
        public string PicturePath { get; set; }

        public clsPerson(
               int personID,
               int nationalID,
               string firstName,
               string secondName,
               string thirdName,
               string lastName,
               DateTime dateOfBirth,
               char gender,
               string address,
               string phone,
               string email,
               string country,
               int countryID,
               string picturePath
           )
        {
            PersonID = personID;
            NationalID = nationalID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            Country = country;
            CountryID = countryID;
            PicturePath = picturePath;
        }

        public clsPerson(clsPerson person)
        {
            PersonID = person.PersonID;
            NationalID = person.NationalID;
            FirstName = person.FirstName;
            SecondName = person.SecondName;
            ThirdName = person.ThirdName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
            Gender = person.Gender;
            Address = person.Address;
            Phone = person.Phone;
            Email = person.Email;
            Country = person.Country;
            CountryID = person.CountryID;
            PicturePath = person.PicturePath;
        }
        public string GetFullName()
        {
            return string.Join(" ", new[] { FirstName, SecondName, ThirdName, LastName }
                .Where(s => !string.IsNullOrWhiteSpace(s))).Trim();
        }
    }
}
