﻿using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mapping
{
    public class ReservationMap : Profile
    {
        public ReservationMap()
        {
            CreateMap<Reservation, ReservationDTO>();
        }
    }
}
