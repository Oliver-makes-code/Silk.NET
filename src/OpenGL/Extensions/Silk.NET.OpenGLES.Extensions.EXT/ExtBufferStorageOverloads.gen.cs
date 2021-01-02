// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtBufferStorageOverloads
    {
        public static unsafe void BufferStorage<T0>(this ExtBufferStorage thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferStorage(target, size, in data.GetPinnableReference(), flags);
        }

        public static unsafe void BufferStorage<T0>(this ExtBufferStorage thisApi, [Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferStorage(target, size, in data.GetPinnableReference(), flags);
        }

    }
}

