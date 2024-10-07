using Microsoft.AspNetCore.Components;

namespace MeetingApp.Models
{
    public class Repository()
    {
        private static List<UserInfo> _users = new List<UserInfo>();
        private static string Location { get; set; }
        private static int NumberOfMeetings = _users.Count;
        private static string StartDate = DateTime.Now.ToShortDateString();

        public static List<UserInfo> Users
        {
         get { return _users; }   
        }

        public static void AddUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        
        static Repository()
        {
            Location = "NewYork";
            StartDate = DateTime.Now.ToShortDateString();
            _users.Add(new UserInfo(){Id = 1, Name = "Ali", Email = "ali@gmail.com", Phone = "123456", WillAttend = true});
            _users.Add(new UserInfo(){Id = 2, Name = "Ahmet", Email = "ahmet@gmail.com", Phone = "123456", WillAttend = true});
            _users.Add(new UserInfo(){Id = 3, Name = "Canan", Email = "canan@gmail.com", Phone = "123456", WillAttend = false});
            _users.Add(new UserInfo(){Id = 4, Name = "Eyup", Email = "eyup@gmail.com", Phone = "123456", WillAttend = true});
            NumberOfMeetings = Users.Count;
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public static string getLocation()
        {
            return Location;
        }

        public static int getNumberOfMeetings()
        {
            return NumberOfMeetings;
        }

        public static string getStartDate()
        {
            return StartDate;
        }
    }
}