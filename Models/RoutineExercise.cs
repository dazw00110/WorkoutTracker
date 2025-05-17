using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker.Models
{
    public class RoutineExercise
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }

        public bool IsFreeMode { get; set; } // bez liczenia powtórzeń lub czasu wykonywania cwiczenia

        
        public TimeSpan? Time { get; set; }
        public string Note { get; set; }
        public int Order { get; set; }
    }
}