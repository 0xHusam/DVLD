using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsDataLicenses
    {
        public static eResult IssueNewLocalLicense(int OrderID, int Restrictions, string ServiceDescription, out clsLicense NewLicense)
        {
            string Query = @"BEGIN TRY
                                BEGIN TRANSACTION;

                                    DECLARE @PersonID INT, @LicenseTypeID INT, @Amount int;

                                    SELECT 
                                        @PersonID = PersonID, 
                                        @LicenseTypeID = LicensingTypeID
                                    FROM LicensingServicesOrders
                                    WHERE ID = @OrderID;

                                    select @Amount = Fee
                                    From LicensingServices

                                    INSERT INTO Payment (Amount, DateOfPaid, ServiceDescription)
                                    VALUES (@Amount, GetDate(), @ServiceDescription);

                                    DECLARE @PaymentID INT = SCOPE_IDENTITY();

                                    UPDATE LicensingServicesOrders
                                    SET StatusID = 3
                                    WHERE ID = @OrderID;
                                    
                                    Declare @DriverID int = (select top 1 ID from Drivers where PersonID = @PersonID)

                                    if (@DriverID is null)
                                    Begin	
	                                    Insert Into Drivers Values (@PersonID);
	                                    Set @DriverID = Scope_Identity();
                                    End

                                    DECLARE @DefaultValidityLength INT;

                                    SELECT @DefaultValidityLength = LicenseDuration 
                                    FROM LicenseTypes
                                    WHERE ID = @LicenseTypeID; 

                                    DECLARE @ExpireDate DATETIME = DATEADD(YEAR, @DefaultValidityLength, GETDATE());

                                    INSERT INTO Licenses (
                                        VersionNumber, 
                                        DriverID, 
                                        LicenseTypeID, 
                                        CreationDate, 
                                        ExpireDate, 
                                        LicenseStatusID, 
                                        IsInternational, 
                                        IsReserved,
                                        Restrictions
                                    )
                                    VALUES (
                                        1, 
                                        @DriverID, 
                                        @LicenseTypeID, 
                                        GETDATE(), 
                                        @ExpireDate, 
                                        1002, 
                                        0, 
                                        0,
                                        @Restrictions
                                    );

                                    DECLARE @IssuedLicenseID INT = SCOPE_IDENTITY();

                                    UPDATE Payment
                                    SET ServiceID = @IssuedLicenseID
                                    WHERE ID = @PaymentID;

                                COMMIT TRANSACTION;
                                select * from MasterLicenses Where ID = @IssuedLicenseID;
                            END TRY
                            BEGIN CATCH
                                IF @@TRANCOUNT > 0
                                    ROLLBACK TRANSACTION;

                                THROW;
                            END CATCH;";

            return clsDataHelper.LoadEntity<clsLicense>
                (
                Query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@Restrictions", Restrictions);
                },
                _ConvertreaderToLicense,
                out NewLicense
                );
        }

        public static eResult GetLicensesTable(DataTable dataTable)
        {
            string query = "Select * from MasterLicenses";
            return clsDataHelper.LoadTable(query, dataTable);
        }

        private static clsLicense _ConvertreaderToLicense(SqlDataReader reader)
        {
            return new clsLicense
                (
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToInt32(reader["VersionNumber"]),
                    reader["LicenseType"].ToString(),
                    reader["CreationDate"].ToString(),
                    reader["ExpireDate"].ToString(),
                    reader["Status"].ToString(),
                    reader["IsInterNational"].ToString(),
                    reader["IsReserved"].ToString(),
                    Convert.ToInt32(reader["DriverID"]),
                    reader["Name"].ToString(),
                    Convert.ToChar(reader["Gender"]),
                    reader["Restrictions"].ToString(),
                    reader["PicturePath"].ToString()
                );
        }

        public static eResult GetLicense(int ID, out clsLicense license)
        {
            string Query = "Select * from MasterLicenses Where ID = @ID";
            return clsDataHelper.LoadEntity<clsLicense>(Query, cmd => cmd.Parameters.AddWithValue("@ID", ID), _ConvertreaderToLicense, out license);
        }
        public static eResult IssueInternationalLicense(int LicenseID, string ServiceDescription, int UserID, out clsLicense license)
        {
            string query = @"begin try
	                             begin transaction		
		                             Declare 
			                             @DriverID int,
			                             @LicenseTypeID int,
			                             @Restrictions int,
			                             @Amount int,
			                             @PersonID int,
			                             @LicenseDuration int,
			                             @ExpireDate Date;
                        
		                             select @DriverID = DriverID, @LicenseTypeID = LicenseTypeID, @Restrictions = Restrictions
		                             from Licenses
		                             Where ID = @LicenseID;
                        
		                             select @Amount = Fee
		                             from LicensingServices
		                             where ID = 6;
                        
		                             select @PersonID = PersonID
		                             from Drivers
		                             where ID = @DriverID;
                        
		                             select @LicenseDuration = LicenseDuration
		                             from LicenseTypes
		                             where ID = @LicenseTypeID;
                        
		                             set @ExpireDate = DATEADD(Year, @LicenseDuration, Getdate());
                        
		                             insert into Payment(Amount, DateOfPaid, ServiceDescription)
		                             values
		                             (@Amount, GetDate(), @ServiceDescription);
                        
		                             Declare @PaymentID int = scope_identity();
                        
		                             insert into LicensingServicesOrders(OrderDate, PersonID, ServiceTypeID, LicensingTypeID, StatusID, PaymentID, CreatedByUserID)
		                             values
		                             (GetDate(), @PersonID, 6, @LicenseTypeID, 3, @PaymentID, @CreatedByUserID);
                        
		                             Declare @OrderID int = scope_identity();
                        
		                             update Payment
		                             set ServiceID = @OrderID
		                             where ID = @PaymentID;
                        
		                             insert into Licenses(VersionNumber, DriverID, LicenseTypeID, CreationDate, ExpireDate, LicenseStatusID, IsInternational, IsReserved, Restrictions)
		                             values
		                             (1, @DriverID, @LicenseTypeID, GetDate(), @ExpireDate, 1002, 1, 0, @Restrictions);
                        
		                             select * 
		                             from MasterLicenses 
		                             where ID = SCOPE_IDENTITY();
                        
	                             commit Transaction
                             end try
                             begin catch
	                             if @@TRANCOUNT > 0
		                             Rollback Transaction
		                
	                             Throw
                             end catch;";

            return clsDataHelper.LoadEntity<clsLicense>
                (
                query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", UserID);
                },
                _ConvertreaderToLicense,
                out license
                );
        }

        public static eResult RenewLicense(int LicenseID, string ServiceDescription, int UserID, out clsLicense license)
        {
            string query = @"begin try
	                             begin transaction		
		                             Declare 
			                             @DriverID int,
			                             @LicenseTypeID int,
			                             @Amount int,
			                             @PersonID int,
			                             @LicenseDuration int,
			                             @ExpireDate Date;
                        
		                             select @DriverID = DriverID, @LicenseTypeID = LicenseTypeID
		                             from Licenses
		                             Where ID = @LicenseID;
                        
		                             select @Amount = Fee
		                             from LicensingServices
		                             where ID = 2;
                        
		                             select @PersonID = PersonID
		                             from Drivers
		                             where ID = @DriverID;
                        
		                             select @LicenseDuration = LicenseDuration
		                             from LicenseTypes
		                             where ID = @LicenseTypeID;
                        
		                             set @ExpireDate = DATEADD(Year, @LicenseDuration, Getdate());
                        
		                             insert into Payment(Amount, DateOfPaid, ServiceDescription)
		                             values
		                             (@Amount, GetDate(), @ServiceDescription);
                        
		                             Declare @PaymentID int = scope_identity();
                        
		                             insert into LicensingServicesOrders(OrderDate, PersonID, ServiceTypeID, LicensingTypeID, StatusID, PaymentID, CreatedByUserID)
		                             values
		                             (GetDate(), @PersonID, 2, @LicenseTypeID, 3, @PaymentID, @CreatedByUserID);
                        
		                             Declare @OrderID int = scope_identity();
                        
		                             update Payment
		                             set ServiceID = @OrderID
		                             where ID = @PaymentID;

                                     Update Licenses
                                     Set licensestatusID = 1003
                                     where ID = @LicenseID;
                        
                                     insert into Licenses(VersionNumber, DriverID, LicenseTypeID, CreationDate, ExpireDate, LicenseStatusID, IsInternational, IsReserved, Restrictions)
                                     select VersionNumber + 1, DriverID, LicenseTypeID, CreationDate, @ExpireDate, 1002, IsInternational, IsReserved, Restrictions
                                     from Licenses
                                     Where ID = @LicenseID;

		                             select * 
		                             from MasterLicenses 
		                             where ID = SCOPE_IDENTITY();
                        
	                             commit Transaction
                             end try
                             begin catch
	                             if @@TRANCOUNT > 0
		                             Rollback Transaction;
		                
	                             Throw
                             end catch;";

            return clsDataHelper.LoadEntity<clsLicense>
                (
                query,
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", UserID);
                },
                _ConvertreaderToLicense,
                out license
                );
        }
    }
}
