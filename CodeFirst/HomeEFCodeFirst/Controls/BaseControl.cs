using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeEFCodeFirst.DBCodeFirst;
using System.Windows.Forms;

namespace HomeEFCodeFirst.Controls
{
    public abstract class BaseControl<T>
    {
        protected Data dbAll;
        protected BindingSource source;

        public BaseControl()
        {
            this.dbAll = new Data();
            this.source = new BindingSource();
        }

        public BindingSource GetSource()
        {
            return this.source;
        }

        abstract public List<T> GetList();
        abstract public void Insert(T obj);
        abstract public void Update(T obj);
        virtual public void UpdateSource()
        {
            return;
        }
    }
}
