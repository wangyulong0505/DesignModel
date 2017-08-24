using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> lists = new List<Observer>();

        private void Attach(Observer observer)
        {
            lists.Add(observer);
        }

        private void Detach(Observer observer)
        {
            lists.Remove(observer);
        }

        private void Notify(Observer observer)
        {
            foreach (Observer o in lists)
            {
                o.Update();
            }
        }
    }
}
