﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skud.Models
{
    /// <summary>
    /// Рабочая смена
    /// </summary>
    public class WorkShift
    {
        public int Id { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }

        /// <summary>
        /// Дата и время прихода
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Дата и время ухода
        /// </summary>
        public DateTime LeavingTime { get; set; }
    }
}
