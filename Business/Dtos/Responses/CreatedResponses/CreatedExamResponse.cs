﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CreatedResponses
{
    public class CreatedExamResponse
    {
        public Guid QuestionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int QuestionCount { get; set; }
    }
}
