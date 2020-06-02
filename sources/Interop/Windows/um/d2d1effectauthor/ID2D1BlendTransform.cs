// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("63AC0B32-BA44-450F-8806-7F4CA1FF2F1B")]
    public unsafe partial struct ID2D1BlendTransform
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return lpVtbl->GetInputCount((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return lpVtbl->SetOutputBuffer((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        public void SetCached([NativeTypeName("BOOL")] int isCached)
        {
            lpVtbl->SetCached((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), isCached);
        }

        public void SetDescription([NativeTypeName("const D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            lpVtbl->SetDescription((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }

        public void GetDescription([NativeTypeName("D2D1_BLEND_DESCRIPTION *")] D2D1_BLEND_DESCRIPTION* description)
        {
            lpVtbl->GetDescription((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, uint> GetInputCount;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> SetOutputBuffer;

            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, int, void> SetCached;

            [NativeTypeName("void (const D2D1_BLEND_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void> SetDescription;

            [NativeTypeName("void (D2D1_BLEND_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BlendTransform*, D2D1_BLEND_DESCRIPTION*, void> GetDescription;
        }
    }
}
