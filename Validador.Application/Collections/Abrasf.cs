﻿namespace Validador.Application
{
    public class Abrasf : Collection
    {
        public Abrasf() : base("Abrasf") { }

        protected override void SetSchemas()
        {
            Schema.Add(null, Path.Combine(SchemaDirectoryPath, "nfse_v2-03 2016.xsd"));
            Schema.Add(null, Path.Combine(SchemaDirectoryPath, "xmldsig-core-schema20020212.xsd"));
        }
    }
}
