using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT
{
    abstract class AbsElements
    {
        private double cost;
        private List<string> objContextTag = new List<string>();
        private List<string> objContextDesc = new List<string>();
        private List<string> objPropertiesTag = new List<string>();
        private List<string> objPropertiesDesc = new List<string>();
        private List<string> ServContextTag = new List<string>();
        private List<string> servContextDesc = new List<string>();
        private List<string> servPropertiesTag = new List<string>();
        private List<string> servPropertiesDesc = new List<string>();
        private List<string> searchTags = new List<string>();

        public List<string> ObjContextTag
        {
            get
            {
                return objContextTag;
            }

            set
            {
                objContextTag = value;
            }
        }

        public List<string> ObjContextDesc
        {
            get
            {
                return objContextDesc;
            }

            set
            {
                objContextDesc = value;
            }
        }

        public List<string> ObjPropertiesTag
        {
            get
            {
                return objPropertiesTag;
            }

            set
            {
                objPropertiesTag = value;
            }
        }

        public List<string> ObjPropertiesDesc
        {
            get
            {
                return objPropertiesDesc;
            }

            set
            {
                objPropertiesDesc = value;
            }
        }

        public List<string> ServContextTag1
        {
            get
            {
                return ServContextTag;
            }

            set
            {
                ServContextTag = value;
            }
        }

        public List<string> ServContextDesc
        {
            get
            {
                return servContextDesc;
            }

            set
            {
                servContextDesc = value;
            }
        }

        public List<string> ServPropertiesTag
        {
            get
            {
                return servPropertiesTag;
            }

            set
            {
                servPropertiesTag = value;
            }
        }

        public List<string> ServPropertiesDesc
        {
            get
            {
                return servPropertiesDesc;
            }

            set
            {
                servPropertiesDesc = value;
            }
        }

        public List<string> SearchTags
        {
            get
            {
                return searchTags;
            }

            set
            {
                searchTags = value;
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
    }
}