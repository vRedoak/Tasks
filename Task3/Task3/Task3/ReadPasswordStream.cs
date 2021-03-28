using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class ReadPasswordStream : Stream
    {
        Stream Stream { get; set; }
        string StreamPassword { get; set; }
        string UserPassword { get; set; }

        public ReadPasswordStream (Stream stream, string password)
        {
            this.Stream = stream;
            StreamPassword = "1111";
            UserPassword = password;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (StreamPassword == UserPassword)
                return Stream.Read(buffer, offset, count);
            throw new InvalidOperationException("Не верный пароль!");
        }

        public override bool CanRead
        {
            get { return Stream.CanRead; }
        }

        public override bool CanSeek 
        {
            get { return Stream.CanRead; }
        }

        public override bool CanWrite
        {
            get { return Stream.CanRead; }
        }

        public override void Flush()
        {
            Stream.Flush();
        }

        public override long Length
        {
            get { return Stream.Length; }
        }

        public override long Position
        {
            get { return Stream.Position; }
            set { Stream.Position = value; }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return Stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            Stream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            Stream.Write(buffer, offset, count);
        }
    }
}
