//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OptumBots
{
    using System;
    using System.Collections.Generic;
    
    public partial class SymptomsCaus
    {
        public SymptomsCaus()
        {
            this.DiseaseSymptoms = new HashSet<DiseaseSymptom>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SymptomID { get; set; }
        public Nullable<int> CauseID { get; set; }
    
        public virtual Cause Cause { get; set; }
        public virtual ICollection<DiseaseSymptom> DiseaseSymptoms { get; set; }
        public virtual Symptom Symptom { get; set; }
    }
}