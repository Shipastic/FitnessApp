using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Controller
{
   public abstract class ControllerBase
    {
        protected void Save(string fileNAme, object item)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(fileNAme, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }

        protected T Load<T>(string fileNAme)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(fileNAme, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is T items)
                {
                    return items;
                }
                else
                {
                    return default(T);
                }
            }
        }
    }
}
