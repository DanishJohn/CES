using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParcelDelivery.Data;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Services.Impl
{
    public class SegmentServieImp : ISegmentService
    {

        ApplicationDbContext _context;

        public SegmentServieImp(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Segment> FindAllSegments()
        {
            return _context.Segment.Include(s => s.From).Include(s => s.To)
                .ToList();
        }
    }
}
