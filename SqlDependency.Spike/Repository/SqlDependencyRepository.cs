
namespace SqlDependency.Spike.Repository
{
    using global::Spike.Commons;
    using global::Spike.Contracts;
    using Hubs;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    public class SqlDependencyRepository
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["ScheduleConnection"].ConnectionString;

        public DataResponse<Schedules> SqlListener()
        {
            var connection = new SqlConnection(connString);
            connection.Open();

            var command = new SqlCommand(@"SELECT [RaceNo], [HorseName], [Rider], [RaceTime], [Status] FROM [dbo].[Race]", connection);
            command.Notification = null;

            var dependency = new SqlDependency(command);
            dependency.OnChange += new OnChangeEventHandler(Dependency_OnChange);
            var pp = dependency.HasChanges;

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            var reader = command.ExecuteReader();
            var schedules = new List<RaceSchedule>();

            while (reader.Read())
            {
                schedules.Add(new RaceSchedule
                {
                    RaceNo = Convert.ToInt32(reader["RaceNo"]),
                    HorseName = (string)reader["HorseName"],
                    Rider = (string)reader["Rider"],
                    RaceTime = (DateTime)reader["RaceTime"],
                    Status = (string)reader["Status"],
                });
            }

            var mappedData = new Schedules { Data = schedules };

            return new DataResponse<Schedules> { IsSuccessful = true, Data = mappedData };
        }

        public void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                ScheduleHub.UpdateRaceSchedules();
            }
        }
    }
}