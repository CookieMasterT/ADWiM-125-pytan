using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ADWiM__125_tasks_
{
    public interface IZadanie
    {
        int ID { get; set; }
        string Text { get; set; }
        void Execute();
    }
}
