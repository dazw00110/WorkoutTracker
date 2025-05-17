using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTracker.Models
{
    public class TrainingExercise
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }

        public int Sets { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }
        public TimeSpan? Time { get; set; }

        public bool IsFreeMode { get; set; } // bez liczenia powtórzeń lub czasu wykonywania cwiczenia
        
        public string Note { get; set; }
        public int? RoutineExerciseId { get; set; }
    }
}