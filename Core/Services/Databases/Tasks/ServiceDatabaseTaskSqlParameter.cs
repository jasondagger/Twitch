
namespace Twitch.Core.Services.Databases.Tasks;

using System.Data;

internal sealed class ServiceDatabaseTaskSqlParameter
{
    internal ServiceDatabaseTaskSqlParameter(
        string    parameterName,
        SqlDbType sqlDbType,
        object    value
    )
    {
        _ = this.ParameterName = _ = parameterName;
		_ = this.SqlDbType     = _ = sqlDbType;
		_ = this.Value         = _ = value;
	}

	internal string    ParameterName { get; } = _ = string.Empty;
    internal SqlDbType SqlDbType     { get; } = 0U;
    internal object    Value         { get; } = null;
}