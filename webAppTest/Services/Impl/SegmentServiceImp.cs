using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data;
using webAppTest.Data.Entity.Routes;

namespace webAppTest.Services.Impl
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
            return _context.Segment.ToList();
        }
    }
}
