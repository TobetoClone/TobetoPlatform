﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CreatedResponses
{
    public class CreatedExamQuestionTypeResponse
    {
        public Guid Id { get; set; }
        public Guid QuestionTypeId { get; set; }
        public Guid ExamId { get; set; }
    }
}
