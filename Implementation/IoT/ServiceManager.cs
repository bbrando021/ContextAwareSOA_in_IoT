using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT
{
    class ServiceManager
    {
        private static ServiceManager sm;
        private List<Thing> things;
        private Request request;


        private ServiceManager()
        {

        }

        internal List<Thing> Things
        {
            get
            {
                return things;
            }

            set
            {
                things = value;
            }
        }

        internal Request Request
        {
            get
            {
                return request;
            }

            set
            {
                request = value;
            }
        }

        public static ServiceManager getInstance()
        {
            if (sm == null)
            {
                sm = new ServiceManager();
            }
            return sm;
        }
        public void addThings(Thing thing)
        {
            if(things == null)
            {
                things = new List<Thing>();
            }
            //thing.initializeLists();
            things.Add(thing);
        }
        public void deleteLastThing()
        {
            if(this.sizeThings() > 0)
            {
                things.RemoveAt(this.sizeThings() - 1);
            }
        }
        public int sizeThings()
        {
            if(things != null)
            return things.Count;
            return -1;
        }
        public void initializeRequest()
        {
            request = new Request();
        }

        public Thing getThing(int i)
        {
            return things[i];
        }
    }
}
