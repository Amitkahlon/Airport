﻿using Airport_Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Airport_DAL.DatabaseModels
{
    public class PlaneLog
    {
        [Key]
        public int Id{ get; set; }
        public DbPlane PlaneId { get; set; }
        public DbStation StationId { get; set; }
        public DateTime Time { get; set; }
    }
}
