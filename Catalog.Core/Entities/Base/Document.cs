using Catalog.Core.Entities.Interfaces;
using MongoDB.Bson;
using System;

namespace Catalog.Core.Entities.Base
{
    public abstract record Document : IDocument
    {
        public ObjectId Id { get; init; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
