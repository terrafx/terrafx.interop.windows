// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("59EFF8B9-938C-4A26-82F2-95CB84CDC837")]
    [NativeTypeName("struct IMediaBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMediaBuffer : IMediaBuffer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMediaBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaBuffer*, uint>)(lpVtbl[1]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaBuffer*, uint>)(lpVtbl[2]))((IMediaBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetLength([NativeTypeName("DWORD")] uint cbLength)
        {
            return ((delegate* unmanaged<IMediaBuffer*, uint, int>)(lpVtbl[3]))((IMediaBuffer*)Unsafe.AsPointer(ref this), cbLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
        {
            return ((delegate* unmanaged<IMediaBuffer*, uint*, int>)(lpVtbl[4]))((IMediaBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetBufferAndLength(byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbLength)
        {
            return ((delegate* unmanaged<IMediaBuffer*, byte**, uint*, int>)(lpVtbl[5]))((IMediaBuffer*)Unsafe.AsPointer(ref this), ppBuffer, pcbLength);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetLength([NativeTypeName("DWORD")] uint cbLength);

            [VtblIndex(4)]
            HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength);

            [VtblIndex(5)]
            HRESULT GetBufferAndLength(byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pcbLength);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, uint, int> SetLength;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, uint*, int> GetMaxLength;

            [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaBuffer*, byte**, uint*, int> GetBufferAndLength;
        }
    }
}
