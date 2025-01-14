﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Types ResourceType {  get; set; }
        //Related Tabels
        public int CourseId {  get; set; }
        public Course Course { get; set; }
        public enum Types{
            Video,
            Presentation,
            Document,
            Other
        }
    }
}
