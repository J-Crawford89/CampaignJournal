using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Character : Entity
    {
        [Required]
        public Guid OwnerId { get; set; }
        [ForeignKey("Race")]
        [Required]
        public int RaceId { get; set; }
        public virtual Race Race { get; set; }
        [ForeignKey("Class")]
        [Required]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        [ForeignKey("Background")]
        [Required]
        public int BackgroundId { get; set; }
        public virtual Background Background { get; set; }
        [Required]
        public string CharacterAlignment { get; set; }
        [Required]
        public int CharacterLevel { get; set; }
        [Required]
        public int CharacterExperience { get; set; }
        [Required]
        public int StrengthScore { get; set; }
        [Required]
        public int DexterityScore { get; set; }
        [Required]
        public int ConstitutionScore { get; set; }
        [Required]
        public int IntelligenceScore { get; set; }
        [Required]
        public int WisdomScore { get; set; }
        [Required]
        public int CharismaScore { get; set; }
        [Required]
        public int ProficiencyBonus { get; set; }
        [Required]
        public int CharacterArmorClass { get; set; }
        [Required]
        public int CharacterMaxHitPoints { get; set; }
        [Required]
        public ICollection<string> SkillProficiencies { get; set; }
        [ForeignKey("Campaign")]
        public int? CampaignId { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}