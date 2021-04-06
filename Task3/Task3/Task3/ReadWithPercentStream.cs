using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class ReadWithPercentStream : Stream
    {
        protected Stream stream;
        public delegate void Handler(int percent);
        public event Handler PercentRead;
        int limitPercent = 10;


        public ReadWithPercentStream(Stream stream, Handler outputPercent)
        {
            this.stream = stream;
            PercentRead += outputPercent;
        } 
        
        public override int Read(byte[] buffer, int offset, int count)
        {
            int n = limitPercent;
            StreamReader sr = new StreamReader(stream);
            for (int i = 0; i < count; i++)
            {
                buffer[i] = (byte)sr.Read();
                int percent = (int)Math.Round((double)(i * 100 / count), 0);
                if (percent > n)
                {
                    PercentRead?.Invoke(percent);
                    n = n + limitPercent;
                }
            }
            return count;
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
