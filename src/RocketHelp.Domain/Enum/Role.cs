using System.ComponentModel;

namespace RocketHelp.Domain.Enum;

public enum Role
{
    [Description("manager")]
    Manager = 1,
    
    [Description("employee")]
    Employee = 2
}
