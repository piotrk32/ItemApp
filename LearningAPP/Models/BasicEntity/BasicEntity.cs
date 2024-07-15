using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningAPP.Models.BasicEntity;

public class BasicEntity
{
    
    private const string SEQUENCE_NAME = "id_seq";

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }

    [Required]
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("modified_at")]
    public DateTime? ModifiedAt { get; set; }
    
    
}