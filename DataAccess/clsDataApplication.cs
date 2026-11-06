using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsDataApplication
    {
        public static eResult GetApplicationTypes(DataTable dataTable)
        {
            string Query = "Select * from LicensingServices";
            return clsDataHelper.LoadTable(Query, dataTable);
        }

        public static eResult UpdateApplicationType(int ID, string ApplicationType, int Fees)
        {
            string query = @"Update LicensingServices
                             set 
                             Service = @Service,
                             Fee = @Fee
                             Where ID = @ID";

            return clsDataHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Service", ApplicationType);
                cmd.Parameters.AddWithValue("@Fee", Fees);
                cmd.Parameters.AddWithValue("@ID", ID);
            },
            out _
            );
        }

        public static eResult GetTestTypes(DataTable dataTable)
        {
            string Query = "Select * from TestTypes";
            return clsDataHelper.LoadTable(Query, dataTable);
        }

        public static eResult UpdateTestTypes(int ID, string Type, int Fees)
        {
            string query = @"Update TestTypes
                             set 
                             Type = @Type,
                             Fee = @Fee
                             Where ID = @ID";

            return clsDataHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Fee", Fees);
                cmd.Parameters.AddWithValue("@ID", ID);
            },
            out _
            );
        }

        public static eResult GetLicenseTypes(DataTable dataTable)
        {
            string query = "select * from LicenseTypes";
            return clsDataHelper.LoadTable(query, dataTable);
        }

        private static clsLicenseType ConvertReaderToLicense(SqlDataReader reader)
        {
            return new clsLicenseType
                (
                Convert.ToInt32(reader["ID"]),
                reader["Type"].ToString(),
                reader["Description"].ToString(),
                Convert.ToInt32(reader["AgeRestriction"]),
                Convert.ToInt32(reader["Fee"]),
                Convert.ToInt32(reader["LicenseDuration"])
                );
        }

        public static eResult GetLicenseByID(int ID, out clsLicenseType license)
        {
            string query = "select * from LicenseTypes Where ID = @ID";
            return clsDataHelper.LoadEntity<clsLicenseType>
                (
                query,
                cmd => cmd.Parameters.AddWithValue("@ID", ID),
                ConvertReaderToLicense,
                out license
                );
        }

        public static eResult GetLicenseServiceFee(out int Fee, eLicenseServices service)
        {
            Fee = -1;
            string query = "select fee from LicensingServices where ID = @ID";
            eResult result = clsDataHelper.ExecuteScalar(query, cmd => cmd.Parameters.AddWithValue("@ID", service), out object DbFee);
            if (result == eResult.Success)
                Fee = Convert.ToInt32(DbFee);

            return result;
        }

        public static eResult InsertLicenseServiceOrder(int PersonID, int UserID, int ServiceID, int LicenseID, int Amount, string ServiceDescripation)
        {
            string query = @"BEGIN TRY
                                 BEGIN TRANSACTION;

                                 INSERT INTO Payment (Amount, DateOfPaid, ServiceDescription)
                                 VALUES (@Amount, GETDATE(), @ServiceDescription);
                             
                                 DECLARE @PaymentID INT = SCOPE_IDENTITY();
                             
                                 INSERT INTO LicensingServicesOrders (OrderDate, PersonID, ServiceTypeID, LicensingTypeID, StatusID, PaymentID, CreatedByUserID)
                                 VALUES (GETDATE(), @PersonID, @ServiceID, @LicensingID, 1, @PaymentID, @UserID);
                             
                                 DECLARE @OrderID INT = SCOPE_IDENTITY();
                             
                                 UPDATE Payment
                                 SET serviceID = @OrderID
                                 WHERE ID = @PaymentID;
                             
                                 COMMIT TRANSACTION;
                            END TRY
                            BEGIN CATCH

                                 IF @@TRANCOUNT > 0
                                     ROLLBACK TRANSACTION;
                             
                                 THROW;
                            END CATCH
                             ";

            return clsDataHelper.ExecuteNonQuery
                (
                query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@ServiceDescription", ServiceDescripation);
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                    cmd.Parameters.AddWithValue("@LicensingID", LicenseID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                },
                out _
                );
  
        }

        public static eResult GetManageIssueLocalLicenseTable(DataTable dataTable)
        {
            string query = "select * from ManageIssueLocalLicense";
            return clsDataHelper.LoadTable(query, dataTable);
        }

        public static eResult CancelIssueLocalLicense(int ID)
        {
            string query = @"update LicensingServicesOrders
                             set StatusID = 2
                             where ID = @ID";

            return clsDataHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@ID", ID), out _);
        }

        public static clsTestType ConvertReaderToTestType(SqlDataReader reader)
        {
            return new clsTestType
                (
                Convert.ToInt32(reader["ID"]),
                reader["Type"].ToString(),
                Convert.ToInt32(reader["Fee"])
                );
        }

        public static eResult GetTestType(int ID, out clsTestType TestType)
        {
            string Query = "Select * from TestTypes Where ID = @ID";
            return clsDataHelper.LoadEntity<clsTestType>(Query, cmd => cmd.Parameters.AddWithValue("@ID", ID), ConvertReaderToTestType, out TestType);
        }

        public static eResult InsertTakeTest(int PersonID, int OrderID, int TestTypeID, int UserID, int Amount, string Notes, string ServiceDescription)
        {
            string Query = @"begin try
	                         begin transaction
		                         insert into Payment (Amount, DateOfPaid, ServiceDescription)
		                         values
		                         (@Amount, Getdate(), @ServiceDescription);
                   
		                         Declare @PaymentID int = Scope_Identity();
                   
		                         insert into Tests (PersonID, TestTypeID, OrderID, CreationDate, PaymentID, CreatedByUserID, Notes) 
		                         values
		                         (@PersonID, @TestTypeID, @OrderID, GETDATE(), @PaymentID, @UserID, @Notes);
                                    
                                 Declare @TestID int = Scope_Identity();

                                 Update Payment
                                 Set ServiceID = @TestID
                                 Where ID = @PaymentID;

		                         commit Transaction;
	                         end Try
	                         Begin Catch
		                         if @@TRANCOUNT > 0
			                         Rollback Transaction;
                   
                                 Throw
	                         end Catch";

            return clsDataHelper.ExecuteNonQuery
                (
                Query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                    cmd.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);
                },
                out _
                );
        }

        public static eResult GetDrivers(DataTable dataTable)
        {
            string query = "Select * from MasterDrivers";
            return clsDataHelper.LoadTable(query, dataTable);
        }

        public static eResult GetPayments(DataTable dataTable)
        {
            string query = "Select * from Payment";
            return clsDataHelper.LoadTable(query, dataTable);
        }
        private static clsServiceType _ConvertReaderToService(SqlDataReader reader)
        {
            return new clsServiceType
                (
                Convert.ToInt32(reader["ID"]),
                reader["Service"].ToString(),
                Convert.ToInt32(reader["Fee"])
                );
        }
        public static eResult GetService(int ID, out Models.clsServiceType serviceType)
        {
            string query = "Select * from LicensingServices Where ID = @ID";
            return clsDataHelper.LoadEntity<clsServiceType>
                (
                query,
                cmd => cmd.Parameters.AddWithValue("@ID", ID),
                _ConvertReaderToService,
                out serviceType
                );
        }
    }
}
