using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess
{
    public static class clsDataHelper
    {

        public static eResult ExecuteDatabaseOperation<T>(string Query, Action<SqlCommand> addParameters, Func<SqlCommand, T> operation, out T Entity)
        {
            Entity = default(T);

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        addParameters?.Invoke(command);
                        connection.Open();
                        Entity = operation(command);
                        return eResult.Success;
                    }
                }
            }
            catch
            {
                Entity = default(T);
                return eResult.Error;
            }

        }
        public static eResult ExecuteScalar(string Query, Action<SqlCommand> addParameters, out Object obj)
        {
            return ExecuteDatabaseOperationWithValidation<object>(Query, addParameters, cmd => cmd.ExecuteScalar(),
                res => res != null && res != DBNull.Value,
                out obj);
        }
        public static eResult ExecuteNonQuery(string Query, Action<SqlCommand> addParameters, out int Rows)
        {
            return ExecuteDatabaseOperationWithValidation<int>(Query, addParameters, cmd => cmd.ExecuteNonQuery(),
                res => res > 0,
                out Rows);
        }

        private static eResult _ConvertCommandToEntityByReader<T>(SqlCommand command, out T Entity, Func<SqlDataReader, T> ConvertReaderToEntityFunc)
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                try
                {
                    if (reader.Read())
                    {
                        Entity = ConvertReaderToEntityFunc(reader);
                        return eResult.Success;
                    }

                    Entity = default(T);
                    return eResult.NotFound;
                }
                catch
                {
                    Entity = default(T);
                    return eResult.Error;
                }
            }
        }

        public static eResult LoadEntity<T>(string Query, Action<SqlCommand> addParameters, Func<SqlDataReader, T> ConvertReaderToEntityFunc, out T Entity)
        {
            Entity = default(T);
            T TempEntity = default(T);

            if  (
                ExecuteDatabaseOperation<eResult>
                (
                Query,
                addParameters,
                cmd => _ConvertCommandToEntityByReader(cmd, out TempEntity, ConvertReaderToEntityFunc),
                out eResult FinalConnectionResult
                ) == eResult.Error
                )
            {
                return eResult.Error;
            }
            Entity = TempEntity;
            return FinalConnectionResult;
        }

        public static eResult LoadTable(string Query, DataTable dt, Action<SqlCommand> addParameters = null)
        {
            dt?.Clear();

            return ExecuteDatabaseOperation<object>(
                Query,
                addParameters,
                cmd =>
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return null;
                },
                out _ 
            );
        }

        public static eResult ExecuteDatabaseOperationWithValidation<T>(string Query, Action<SqlCommand> addParameters, Func<SqlCommand, T> operation,
            Predicate<T> IsValid, out T FinalResult)
        {
            FinalResult = default(T);

            if ( ExecuteDatabaseOperation<T>(Query, addParameters, operation, out T TbResult) == eResult.Success )
            {
                if (IsValid(TbResult))
                {
                    FinalResult = TbResult;
                    return eResult.Success;
                }

                return eResult.NotFound;
            }

            return eResult.Error;
        }

        public static eResult InsertEntity(string Query, Action<SqlCommand> addParametars, out int NewID)
        {
            NewID = -1;

            eResult result = clsDataHelper.ExecuteDatabaseOperationWithValidation<object>
                (
                Query,
                cmd => addParametars(cmd),
                cmd => cmd.ExecuteScalar(),
                res => res != null && res != DBNull.Value,
                out object DbNewID
                );

            if (result == eResult.Success)
                NewID = Convert.ToInt32(DbNewID);

            return result;
        }
    }
}
