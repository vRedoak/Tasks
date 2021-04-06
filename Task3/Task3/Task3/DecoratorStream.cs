using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    abstract class DecoratorStream : Stream
    {
        protected Stream stream;
         
        public DecoratorStream(Stream stream)
        {
            
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }
    }
}
