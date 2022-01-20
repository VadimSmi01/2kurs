﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_cinema
{
    public partial class Session
    {
        public Session()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int SessionId { get; set; }
        public int HallsId { get; set; }
        public int FilmsId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public Session(int hallsId, int filmId, DateTime date, TimeSpan time)
        {
            this.HallsId = hallsId;
            this.FilmsId = filmId;
            this.Date = date;
            this.Time = time;
            Halls = new Hall();
            Films = new Film();
            Tickets = new List<Ticket>();
        }

        

        public virtual Film Films { get; set; }
        public virtual Hall Halls { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
