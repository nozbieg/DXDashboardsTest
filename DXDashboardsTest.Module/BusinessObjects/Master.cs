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
    public class Master : XPObject
    {
        public Master(Session session) : base(session)
        { }




        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [Association("Master-Lists"), Aggregated]
        public XPCollection<List> Lists
        {
            get
            {
                return GetCollection<List>(nameof(Lists));
            }
        }
    }
}
