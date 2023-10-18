using System.ComponentModel;

namespace Entities.Enums
{
    public enum BmiStatus
    {
        [Description("Zayıf")]
        UnderWeight,

        [Description("İdeal Kilo")]
        NormalWeight,

        [Description("Fazla Kilolu")]
        Overweight,
        
        [Description("Obez")]
        Obesity,

    }
}
