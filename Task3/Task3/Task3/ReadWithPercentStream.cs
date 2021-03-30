using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class ReadWithPercentStream : DecoratorStream
    {

        public ReadWithPercentStream(Stream stream) : base(stream) { }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return (int)Math.Round((double)stream.Read(buffer, offset, count) * 100 / stream.Length , 0);
        }

        public override bool CanRead
        {
            get { return stream.CanRead; }
        }


        public override bool CanSeek
        {
            get { return stream.CanRead; }
        }

        public override bool CanWrite
        {
            get { return stream.CanRead; }
        }

        public override void Flush()
        {
            stream.Flush();
        }

        public override long Length
        {
            get { return stream.Length; }
        }

        public override long Position
        {
            get { return stream.Position; }
            set { stream.Position = value; }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            stream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            stream.Write(buffer, offset, count);
        }
    }
}
