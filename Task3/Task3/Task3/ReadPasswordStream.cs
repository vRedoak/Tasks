using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class ReadPasswordStream :Stream
    {
        protected Stream stream;
        string StreamPassword { get; set; }
        string UserPassword { get; set; }

        public ReadPasswordStream (Stream stream, string password)
        {
            StreamPassword = "1111";
            UserPassword = password;
            this.stream = stream;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (StreamPassword == UserPassword)
                return stream.Read(buffer, offset, count);
            throw new InvalidOperationException("Неверный пароль!");
        }
        
        public override bool CanRead
        {
            get { return stream.CanRead; }
        }

        public override bool CanSeek 
        {
            get { return stream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return stream.CanWrite; }
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
