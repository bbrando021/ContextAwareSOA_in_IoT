using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT
{
    abstract class AbsRequester : AbsElements
    {
        private double costWeight;
        private List<string> contextRequesterTag = new List<string>();
        private List<string> contextRequesterDesc = new List<string>();
        private double interoperabilityWeight;
        private double securityWeight;
        private double scalabilityWeight;
        private double performanceWeight;
        private double availabilityWeight;
        private double accessibilityWeight;

        
        public double CostWeight
        {
            get
            {
                return costWeight;
            }

            set
            {
                costWeight = value;
            }
        }

        public List<string> ContextRequesterTag
        {
            get
            {
                return contextRequesterTag;
            }

            set
            {
                contextRequesterTag = value;
            }
        }
       

        public double InteroperabilityWeight
        {
            get
            {
                return interoperabilityWeight;
            }

            set
            {
                interoperabilityWeight = value;
            }
        }

        public double SecurityWeight
        {
            get
            {
                return securityWeight;
            }

            set
            {
                securityWeight = value;
            }
        }

        public double ScalabilityWeight
        {
            get
            {
                return scalabilityWeight;
            }

            set
            {
                scalabilityWeight = value;
            }
        }

        public double PerformanceWeight
        {
            get
            {
                return performanceWeight;
            }

            set
            {
                performanceWeight = value;
            }
        }

        public double AvailabilityWeight
        {
            get
            {
                return availabilityWeight;
            }

            set
            {
                availabilityWeight = value;
            }
        }

        public double AccessibilityWeight
        {
            get
            {
                return accessibilityWeight;
            }

            set
            {
                accessibilityWeight = value;
            }
        }

        public List<string> ContextRequesterDesc
        {
            get
            {
                return contextRequesterDesc;
            }

            set
            {
                contextRequesterDesc = value;
            }
        }
    }
}
