using System;

namespace Recruitment.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public int CopyNumber { get; set; }
    }
}
