using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmgr
{
    class Process
    {
        
        int pid;
        string name;
        string status;
        //int priority;
        int memory;

        public int getPid()
        {
            return pid;
        }

        public string getName()
        {
            return name;
        }

        public int getMemory()
        {
            return memory;
        }

        public void changeStatus()
        {
            if(this.status == "Active")
            {
                this.status = "Stoped";
            }
            else
            {
                this.status = "Active";
            }
        }

        public void set(int pid, string name, int memory)
        {
            this.pid = pid;
            this.name = name;
            this.memory = memory;
        }
    }
}
