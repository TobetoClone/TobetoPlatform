﻿using System;
namespace Business.Dtos.Requests.DeleteRequests
{
    public class DeleteExamResultRequest
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid ExamId { get; set; }
        public int CorrectOptionCount { get; set; }
        public int IncorrectOptionCount { get; set; }
        public int EmptyOptionCount { get; set; }
        public int Result { get; set; }
    }
}

