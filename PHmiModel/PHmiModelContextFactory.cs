﻿using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Reflection;
using Npgsql;
using PHmiModel.Interfaces;

namespace PHmiModel
{
    public class PHmiModelContextFactory : IModelContextFactory
    {
        public IModelContext Create(string connectionString, bool startTrackingChanges)
        {
            var context = new PHmiModelContext(connectionString);
            if (startTrackingChanges)
                context.StartTrackingChanges();
            return context;
        }
    }
}
