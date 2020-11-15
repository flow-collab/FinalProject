//using QueueCheckIns.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace QueueCheckIn.Services
//{
//    public class MockCheckInRepository : ICheckInRepository
//    {
//        private List<CheckIn> _checkInList;

//        public MockCheckInRepository()
//        {
//            _checkInList = new List<CheckIn>()
//            {
//                new CheckIn() { Id = 1, Name = "John", PhoneNumber = "0879898789", CheckInDate = DateTime.Now, Status = Status.Waiting},
//                new CheckIn() { Id = 2, Name = "Michael", PhoneNumber = "0862348765", CheckInDate = DateTime.Now, Status = Status.Waiting },
//                new CheckIn() { Id = 3, Name = "Patrick", PhoneNumber = "0832349876", CheckInDate = DateTime.Now, Status = Status.Processing },
//                new CheckIn() { Id = 4, Name = "Ben", PhoneNumber = "0857654387", CheckInDate = DateTime.Now, Status = Status.Processed }
//            };
//        }

//        public CheckIn Add(CheckIn newCheckIn)
//        {
//            newCheckIn.Id = _checkInList.Max(e => e.Id) + 1;
//            newCheckIn.CheckInDate = DateTime.Today;
//            newCheckIn.CheckInTime = DateTime.Now.Date;
//            _checkInList.Add(newCheckIn);
//            return newCheckIn;
//        }

//        public IEnumerable<QueueCount> CountWaiting(Status? status)
//        {
//            throw new NotImplementedException();
//        }

//        public CheckIn Delete(int id)
//        {
//           CheckIn checkInToDelete = _checkInList.FirstOrDefault(c => c.Id == id);
//            if (checkInToDelete != null)
//            {
//                _checkInList.Remove(checkInToDelete);
//            }
//            return checkInToDelete;
//        }

//        public IEnumerable<CheckIn> GetAllCheckIns()
//        {
//            return _checkInList;
//        }

//        public CheckIn GetCheckIn(int id)
//        {
//            return _checkInList.FirstOrDefault(c => c.Id == id);
//        }

//        public IEnumerable<QueueTime> TimeToWait(Status? status)
//        {
//            throw new NotImplementedException();
//        }

//        public CheckIn Update(CheckIn updatedCheckIn)
//        {
//            CheckIn checkin = _checkInList.FirstOrDefault(c => c.Id == updatedCheckIn.Id);
//            if (checkin !=null)
//            {
//                //checkin.Name = updatedCheckIn.Name;
//                //checkin.PhoneNumber = updatedCheckIn.PhoneNumber;
//                checkin.Status = updatedCheckIn.Status;
//            }

//            return checkin;
//        }

//        //public int WaitLength()
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}
