﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSystem.Entities
{
    public class AuctionPicture:BaseEntity
    {
        public int AuctionID { get; set; }
        public int PictureID { get; set; } 
        public Picture Picture { get; set; }
    }
}
