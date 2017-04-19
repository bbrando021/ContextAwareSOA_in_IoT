using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT
{
    abstract class AbsThing : AbsElements
    {
        private string objectName;
        private string brand;
        private string model;
        private string objectDescription;
        private string serviceName;
        private string serviceDesc;
        private List<string> inputName = new List<string>();
        private List<string> inputType = new List<string>();
        private string output;
        private string exampleOutput;

        private double cost;
        private string interopBool;
        private string interopOtherService;
        private string security;
        private int scalabilityNum;
        private double performTime;
        private string performUnits;
        private double availability;
        private string accessibilityLink;

        
        public string ObjectName
        {
            get
            {
                return objectName;
            }

            set
            {
                objectName = value;
            }
        }


        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string ServiceName
        {
            get
            {
                return serviceName;
            }

            set
            {
                serviceName = value;
            }
        }

        public string ServiceDesc
        {
            get
            {
                return serviceDesc;
            }

            set
            {
                serviceDesc = value;
            }
        }

        public List<string> InputName
        {
            get
            {
                return inputName;
            }

            set
            {
                inputName = value;
            }
        }

        public List<string> InputType
        {
            get
            {
                return inputType;
            }

            set
            {
                inputType = value;
            }
        }

        public string Output
        {
            get
            {
                return output;
            }

            set
            {
                output = value;
            }
        }

        public string ExampleOutput
        {
            get
            {
                return exampleOutput;
            }

            set
            {
                exampleOutput = value;
            }
        }

        public string InteropBool
        {
            get
            {
                return InteropBool;
            }

            set
            {
                InteropBool = value;
            }
        }

        public string InteropOtherService
        {
            get
            {
                return interopOtherService;
            }

            set
            {
                interopOtherService = value;
            }
        }

        public string Security
        {
            get
            {
                return security;
            }

            set
            {
                security = value;
            }
        }

        public int ScalabilityNum
        {
            get
            {
                return scalabilityNum;
            }

            set
            {
                scalabilityNum = value;
            }
        }

        public double PerformTime
        {
            get
            {
                return performTime;
            }

            set
            {
                performTime = value;
            }
        }

        public string PerformUnits
        {
            get
            {
                return performUnits;
            }

            set
            {
                performUnits = value;
            }
        }

        public double Availability
        {
            get
            {
                return availability;
            }

            set
            {
                availability = value;
            }
        }

        public string AccessibilityLink
        {
            get
            {
                return accessibilityLink;
            }

            set
            {
                accessibilityLink = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public string ObjectDescription
        {
            get
            {
                return objectDescription;
            }

            set
            {
                objectDescription = value;
            }
        }

        public string InteropBool1
        {
            get
            {
                return interopBool;
            }

            set
            {
                interopBool = value;
            }
        }
    }
}
