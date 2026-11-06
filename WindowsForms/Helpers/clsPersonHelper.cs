using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Helpers
{
    public static class clsPersonHelper
    {
        public static Image GetPersonImage(clsPerson person)
        {
            if (!string.IsNullOrWhiteSpace(person.PicturePath) && File.Exists(person.PicturePath))
            {
                try
                {
                    return Image.FromFile(person.PicturePath);
                }
                catch
                {

                }
            }

            return GetGendorImage(person.Gender);
        }
        public static Image GetPersonImage(char gender, string PicturePath)
        {
            if (!string.IsNullOrWhiteSpace(PicturePath) && File.Exists(PicturePath))
            {
                try
                {
                    return Image.FromFile(PicturePath);
                }
                catch
                {

                }
            }

            return GetGendorImage(gender);
        }

        public static string GetGendor(char Gender)
        {
            return (Gender == 'M') ? "Male" : "Female";
        }

        public static string GetGender(bool Gender)
        {
            return (Gender == false) ? "Male" : "Female";
        }

        public static Image GetGendorImage(char Gender)
        {
            return (Gender == 'M') ? Properties.Resources.Man : Properties.Resources.Woman;
        }

        public static Image GetGendorImage(bool Gender)
        {
            return (Gender == false) ? Properties.Resources.Man : Properties.Resources.Woman;
        }
    }
}
