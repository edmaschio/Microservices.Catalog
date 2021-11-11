using Catalog.Core.Entities.Interfaces;
using System;

namespace Catalog.Core.Entities.Base
{
    public abstract record Document : IDocument
    {
        public Guid Id { get; init; }
    }
}
