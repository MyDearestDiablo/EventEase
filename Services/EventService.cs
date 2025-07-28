using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> _events;

        public EventService()
        {
            _events = GenerateMockEvents();
        }

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(_events);
        }

        public Task<Event?> GetEventByIdAsync(int id)
        {
            var eventItem = _events.FirstOrDefault(e => e.Id == id);
            return Task.FromResult(eventItem);
        }

        private List<Event> GenerateMockEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Annual Tech Conference 2025",
                    Date = new DateTime(2025, 8, 15, 9, 0, 0),
                    Location = "Seattle Convention Center, WA",
                    Description = "Join industry leaders and innovators for the most anticipated tech conference of the year. Featuring keynotes, workshops, and networking opportunities.",
                    Price = 299.99m,
                    MaxAttendees = 1000,
                    ImageUrl = "/images/tech-conference.jpg"
                },
                new Event
                {
                    Id = 2,
                    Name = "Summer Music Festival",
                    Date = new DateTime(2025, 7, 20, 18, 0, 0),
                    Location = "Central Park, New York, NY",
                    Description = "A celebration of music featuring local and international artists across multiple genres. Food trucks and family-friendly activities included.",
                    Price = 75.00m,
                    MaxAttendees = 5000,
                    ImageUrl = "/images/music-festival.jpg"
                },
                new Event
                {
                    Id = 3,
                    Name = "Corporate Leadership Workshop",
                    Date = new DateTime(2025, 8, 5, 8, 30, 0),
                    Location = "Downtown Business Center, Chicago, IL",
                    Description = "Intensive workshop designed for executives and managers to enhance leadership skills and strategic thinking.",
                    Price = 450.00m,
                    MaxAttendees = 50,
                    ImageUrl = "/images/leadership-workshop.jpg"
                },
                new Event
                {
                    Id = 4,
                    Name = "Community Health Fair",
                    Date = new DateTime(2025, 8, 12, 10, 0, 0),
                    Location = "City Community Center, Austin, TX",
                    Description = "Free health screenings, wellness information, and local healthcare provider booths. Open to all community members.",
                    Price = 0m,
                    MaxAttendees = 200,
                    ImageUrl = "/images/health-fair.jpg"
                },
                new Event
                {
                    Id = 5,
                    Name = "Wedding Planning Expo",
                    Date = new DateTime(2025, 9, 10, 11, 0, 0),
                    Location = "Grand Hotel Ballroom, Miami, FL",
                    Description = "Discover the latest trends in wedding planning with vendors, fashion shows, and expert consultations.",
                    Price = 25.00m,
                    MaxAttendees = 300,
                    ImageUrl = "/images/wedding-expo.jpg"
                },
                new Event
                {
                    Id = 6,
                    Name = "Startup Pitch Competition",
                    Date = new DateTime(2025, 8, 28, 13, 0, 0),
                    Location = "Innovation Hub, San Francisco, CA",
                    Description = "Watch emerging startups pitch their ideas to investors and industry experts. Networking reception follows.",
                    Price = 0m,
                    MaxAttendees = 150,
                    ImageUrl = "/images/startup-pitch.jpg"
                }
            };
        }
    }
}
