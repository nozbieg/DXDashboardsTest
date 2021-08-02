using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXDashboardsTest.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class List : XPObject
    {
        public List(Session session) : base(session)
        { }


        Master master;
        string listName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ListName
        {
            get => listName;
            set => SetPropertyValue(nameof(ListName), ref listName, value);
        }

        [Association("Master-Lists")]
        public Master Master
        {
            get => master;
            set => SetPropertyValue(nameof(Master), ref master, value);
        }
    }
}
