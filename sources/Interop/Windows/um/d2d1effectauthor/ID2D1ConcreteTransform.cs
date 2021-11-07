// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1A799D8A-69F7-4E4C-9FED-437CCC6684CC")]
    [NativeTypeName("struct ID2D1ConcreteTransform : ID2D1TransformNode")]
    [NativeInheritance("ID2D1TransformNode")]
    public unsafe partial struct ID2D1ConcreteTransform : ID2D1ConcreteTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1ConcreteTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1ConcreteTransform*, uint>)(lpVtbl[1]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1ConcreteTransform*, uint>)(lpVtbl[2]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<ID2D1ConcreteTransform*, uint>)(lpVtbl[3]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth)
        {
            return ((delegate* unmanaged<ID2D1ConcreteTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int>)(lpVtbl[4]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetCached(BOOL isCached)
        {
            ((delegate* unmanaged<ID2D1ConcreteTransform*, BOOL, void>)(lpVtbl[5]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), isCached);
        }

        public interface Interface : ID2D1TransformNode.Interface
        {
            [VtblIndex(4)]
            HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);

            [VtblIndex(5)]
            void SetCached(BOOL isCached);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, uint> Release;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, uint> GetInputCount;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, D2D1_BUFFER_PRECISION, D2D1_CHANNEL_DEPTH, int> SetOutputBuffer;

            [NativeTypeName("void (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1ConcreteTransform*, BOOL, void> SetCached;
        }
    }
}
