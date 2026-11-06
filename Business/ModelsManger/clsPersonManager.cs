using Business.GlobalData;
using Business.ModelsManger;
using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class clsPersonManager
    {
        public static eResult FillAllPeople(DataTable dt)
        {
            return DataAccess.clsDataPerson.FillAllPeople(dt); 
        }

        public static eResult FindByID(int personID, out clsPerson person)
        {
            return DataAccess.clsDataPerson.FindByID(personID, out person);
        }

        public static eResult FindByNationalID(int nationalID, out clsPerson person)
        {
            return DataAccess.clsDataPerson.FindByNationalID(nationalID, out person);
        }



        private static eResult Insert(Models.clsPerson person)
        {
            return clsManagerHelper.Operation<clsPerson>(person, opr => clsDataPerson.Insert(opr), Ropr => clsdtPeople.AddRow(Ropr));
        }
        private static eResult Update(Models.clsPerson person)
        {
            return clsManagerHelper.Operation<clsPerson>(person, opr => clsDataPerson.Update(opr), Ropr => clsdtPeople.UpdateRow(Ropr));
        }

        public static eResult Save(Models.clsPerson person)
        {
            if (person.PersonID == -1) return Insert(person);
            
            return Update(person);
            
        }
        public static eResult Delete(int PersonID)
        {
            return clsManagerHelper.Operation<int>(PersonID, opr => clsDataPerson.Delete(opr), Ropr => clsdtPeople.DeleteRow(Ropr));
        }

        public static eResult IsExistByID(int PersonID)
        {
            return clsDataPerson.IsExistByID(PersonID);
        }
        public static eResult IsExistByNationalID(int NationalID)
        {
            return clsDataPerson.IsExistByNationalID(NationalID);
        }
    }
}
