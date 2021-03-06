﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCO.Readers
{
    using Models;

    /// <summary>
    /// This abstract class for schema reading.
    /// </summary>
    public abstract class SchemaReader : IDisposable
    {
        /// <summary>
        /// Reads the Schema returning all tables in the databse.
        /// </summary>
        public abstract Tables ReadSchema(string connectionString);

        /// <summary>
        /// Disposes of objects
        /// </summary>
        public abstract void Dispose();
    }
}
