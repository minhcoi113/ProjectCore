

using DTC.DefaultRepository.Models.Base;
using DTC.T;

namespace Project.Net8.Models.Core;

public class LoggingModel : Audit, TEntity<string>
{
    
    public string? DonVi { get; set; }

    public string? API { get; set; } // EActionLog
    
    public string? Content { get; set; }

    public int? Status { get; set; }
}




