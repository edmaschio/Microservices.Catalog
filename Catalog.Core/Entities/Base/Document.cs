using Catalog.Core.Entities.Interfaces;
using MongoDB.Bson;
using System;

namespace Catalog.Core.Entities.Base
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
