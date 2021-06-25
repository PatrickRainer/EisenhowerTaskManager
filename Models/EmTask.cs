using System;

namespace EisenhowerTaskManager.Models
{
    public class EmTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public EisenhowerType EisenhowerType { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; } = EmTaskStatus.Open;

        public override string ToString()
        {
            return TaskName;
        }
    }

    public struct EmTaskStatus
    {
        public const string Open = "Open";
        public const string InProgress = "In Progress";
        public const string Done = "Done";
    }

    public enum EisenhowerType
    {
        A,
        B,
        C,
        D
    }
}