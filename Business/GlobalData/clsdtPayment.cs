using Business.ModelsManger;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.GlobalData
{
    public static class clsdtPayment
    {
        public static DataTable dtPayment = new DataTable();

        public static void Initialize()
        {
            dtPayment.Columns.Add(new DataColumn("ID", typeof(int)) { Caption = "ID" });
            dtPayment.Columns.Add(new DataColumn("Amount", typeof(int)) { Caption = "Amount" });
            dtPayment.Columns.Add(new DataColumn("DateOfPaid", typeof(string)) { Caption = "Date Of Paid" });
            dtPayment.Columns.Add(new DataColumn("ServiceDescription", typeof(string)) { Caption = "Service Description" });
            dtPayment.Columns.Add(new DataColumn("ServiceID", typeof(int)) { Caption = "Service ID" });
        }

        public static eResult FillDtPayment()
        {
            return clsApplicationManager.GetPayments(dtPayment);
        }

    }
}
