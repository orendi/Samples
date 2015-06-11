﻿namespace WebLight
{
    public class MinimalHttpDecoder : HttpMessageDecoder2, IMinimalDecoder
    {
        BufferAdapter _buffer = new BufferAdapter();

        public void Process(byte[] buffer, int offset, int count)
        {
            _buffer.SetBuffer(buffer, offset, count);
            _buffer.BytesTransferred = count;
            ProcessReadBytes(_buffer);
        }
    }
}