// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("63AC0B32-BA44-450F-8806-7F4CA1FF2F1B")]
    [NativeTypeName("struct ID2D1BlendTransform : ID2D1ConcreteTransform")]
    public unsafe partial struct ID2D1BlendTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1BlendTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1BlendTransform*, uint>)(lpVtbl[1]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1BlendTransform*, uint>)(lpVtbl[2]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* stdcall<ID2D1BlendTransform*, uint>)(lpVtbl[3]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return ((delegate* stdcall<ID2D1BlendTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(lpVtbl[4]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            ((delegate* stdcall<ID2D1BlendTransform*, int, void>)(lpVtbl[5]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), isCached);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDescription([NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            ((delegate* stdcall<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void>)(lpVtbl[6]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDescription([NativeTypeName("D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            ((delegate* stdcall<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void>)(lpVtbl[7]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }
    }
}
