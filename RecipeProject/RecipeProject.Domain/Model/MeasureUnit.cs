using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public class MeasureUnit
    {

        public int MeasureUnitId { get; set; }
        public string MeasureUnitValue { get; set; }
        private MeasureUnit()
        {

        }
        public MeasureUnit(string measureUnit)
        {
            MeasureUnitValue = measureUnit;
        }
    }
}
