﻿namespace Urans.Entities
{
    public class TaskAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string fileUrl { get; set; }
        public Task Task { get; set; }
    }
}
