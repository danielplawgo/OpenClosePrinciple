using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public interface ISettingsView
    {
        string Title { get; }

        double OrderNumber { get; }

        void Show();

        bool CanShow(ApplicationContext context);
    }
}
