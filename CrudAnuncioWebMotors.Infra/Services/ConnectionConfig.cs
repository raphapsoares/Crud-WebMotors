﻿using CrudAnuncioWebMotors.Domain.Services.Config;

namespace CrudAnuncioWebMotors.Infra.Services
{
    public class ConnectionConfig : IConnectionConfig
    {
        private readonly string _connection;

        public ConnectionConfig(string connection)
        {
            _connection = connection;
        }

        public string GetConnectionString()
        {
            return _connection;
        }
    }
}
