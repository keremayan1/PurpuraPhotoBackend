using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Album : Entity
    {
        public Guid UserId { get; set; }
        public string AlbumName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PhotographerNote { get; set; }
        public string Note { get; set; }
        public int SelectedCount { get; set; }
        public bool IsDraft { get; set; }
        public bool IsSend { get; set; }
        public bool IsViewed { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsCompleted { get; set; }

    }
}
