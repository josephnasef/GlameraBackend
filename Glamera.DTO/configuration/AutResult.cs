﻿using System.Collections.Generic;

namespace Glamera.DTO.configuration
{
    public class AutResult
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public bool Result { get; set; }
        public List<string> Errors { get; set; }
    }
}
