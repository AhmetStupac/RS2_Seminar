using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services.Database
{
    public class NutritionPlan
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(PersonalTrainer))]
        public int TrainerId { get; set; }
        public PersonalTrainer Trainer { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TotalCalories { get; set; }
        public string Protein { get; set; }
        public string Carbs { get; set; }
        public int Fats { get; set; }
        public float Price { get; set; }
        public DateOnly CreatedAt { get; set; }
    }
}
