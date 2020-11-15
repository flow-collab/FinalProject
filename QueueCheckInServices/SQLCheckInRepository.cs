using QueueCheckIns.Model;
using QueueCheckIn.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace QueueCheckIn.Services
{
    public class SQLCheckInRepository : ICheckInRepository
    {
        private readonly AppDbContext context;
        public SQLCheckInRepository(AppDbContext context)
        {
            this.context = context;
        }

        public CheckIn Add(CheckIn newCheckIn)
        {
            newCheckIn.CheckInDate = DateTime.Today;
            newCheckIn.CheckInTime = DateTime.Now;
            newCheckIn.Status = Status.Waiting;
            if (newCheckIn.Category == Category.Adult)
            {
                newCheckIn.CategoryTime = (int)Category.Adult;
            }
            else if (newCheckIn.Category == Category.Child)
            {
                newCheckIn.CategoryTime = (int)Category.Child;
            }
            else if (newCheckIn.Category == Category.OAP)
            {
                newCheckIn.CategoryTime = (int)Category.OAP;
            }
            else if (newCheckIn.Category == Category.Teen)
            {
                newCheckIn.CategoryTime = (int)Category.Teen;
            }
            context.CheckIns.Add(newCheckIn);
            context.SaveChanges();
            return newCheckIn;
        }

        public IEnumerable<QueueCount> CountWaiting(Status? status)
        {
            IEnumerable<CheckIn> query = context.CheckIns;
            if (status.HasValue)
            {
                query = query.Where(c => c.Status == status.Value && c.CheckInDate == DateTime.Today);

                return query.GroupBy(e => e.Status)
                                       .Select(g => new QueueCount()
                                       {
                                           Status = g.Key.Value,
                                           Count = g.Count()
                                       }).ToList();
            }
            else
            {
                query = query.Where(c => c.CheckInDate == DateTime.Today);
                return query.GroupBy(e => e.Status)
                                       .Select(g => new QueueCount()
                                       {
                                           Status = g.Key.Value,
                                           Count = g.Count()
                                       }).ToList();
            }
            
        }

        public IEnumerable<QueueTime> TimeToWait(Status? status)
        {
            IEnumerable<CheckIn> query = context.CheckIns;
            {
                int AverageProcessingWait = 15;
                query = query.Where(c => c.Status == Status.Waiting && c.CheckInDate == DateTime.Today);
                var total = query.Sum(x => x.CategoryTime);

                return query.GroupBy(e=>e.Status).Select(g => new QueueTime()
                {
                    Status = g.Key.Value,
                    Count = g.Count(),
                    TotalWait = (total + AverageProcessingWait)
                }).ToList();
            }
        }

        
        public CheckIn Delete(int id)
        {
            CheckIn checkIn = context.CheckIns.Find(id);
            if (checkIn != null)
            {
                context.CheckIns.Remove(checkIn);
                context.SaveChanges();
            }
            return checkIn;
        }

        public IEnumerable<CheckIn> GetAllCheckIns()
        {
            return context.CheckIns;
        }

        public IEnumerable<CheckIn> GetAllCheckInsPast30Days()
        {
            
            return context.CheckIns.Where(w => w.CheckInDate >= DateTime.Now.AddDays(-30));
        }

        public IEnumerable<CheckIn> GetAllCheckInsPast14Days()
        {

            return context.CheckIns.Where(w => w.CheckInDate >= DateTime.Now.AddDays(-14));
        }

        public CheckIn GetCheckIn(int id)
        {
            return context.CheckIns.Find(id);
        }

        public CheckIn Update(CheckIn updatedCheckIn)
        {
            //var checkIn = context.CheckIns.Attach(updatedCheckIn);
            var checkIn = context.CheckIns.Find(updatedCheckIn.Id);
            checkIn.Status = updatedCheckIn.Status;
            context.SaveChanges();
            return updatedCheckIn;
        }

        
    }
}
