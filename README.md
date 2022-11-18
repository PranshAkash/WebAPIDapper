# WebAPIDapper


Steps ==> {
	Package ==> Install these packages using console or nuget package manager
	Migration ==> Special and important to create connection from Database
	class in any folder ==> In my case I have created a Data folder 
	Models
	Interface
	Implementation
}

package ==> {
	Dapper
	Hangfire
	Hangfire.Core
	Microsoft.Extensions.Configuration.Abstractions
	NLog
	System.Configuration.ConfigurationManager
	System.Data.SqlClient
}

Migration ==> {
	Database as Class
}

class ==> {
	ObjectToDictionay ==> To convert data Object to Dictionary manually
}

Models ==> {
	PageSetting
	Parameters
}
Interface ==> {
	IConnectionString
	IDapperRepository
}
Implementation ==> {
	ConnectionString
	DapperRepository
}

Note :- We have to register New Interface and their Implementation Class in startUp as (service.addScoped<INameofInterface, InterfaceImplementation>();)