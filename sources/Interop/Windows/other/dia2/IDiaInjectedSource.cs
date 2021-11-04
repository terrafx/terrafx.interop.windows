// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
    [NativeTypeName("struct IDiaInjectedSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaInjectedSource : IDiaInjectedSource.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, Guid*, void**, int>)(lpVtbl[0]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, uint>)(lpVtbl[1]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, uint>)(lpVtbl[2]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, uint*, int>)(lpVtbl[3]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, ulong*, int>)(lpVtbl[4]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_filename([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, ushort**, int>)(lpVtbl[5]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_objectFilename([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, ushort**, int>)(lpVtbl[6]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_virtualFilename([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, ushort**, int>)(lpVtbl[7]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, uint*, int>)(lpVtbl[8]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_source([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
        {
            return ((delegate* unmanaged<IDiaInjectedSource*, uint, uint*, byte*, int>)(lpVtbl[9]))((IDiaInjectedSource*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(4)]
            HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

            [VtblIndex(5)]
            HRESULT get_filename([NativeTypeName("BSTR *")] ushort** pRetVal);

            [VtblIndex(6)]
            HRESULT get_objectFilename([NativeTypeName("BSTR *")] ushort** pRetVal);

            [VtblIndex(7)]
            HRESULT get_virtualFilename([NativeTypeName("BSTR *")] ushort** pRetVal);

            [VtblIndex(8)]
            HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal);

            [VtblIndex(9)]
            HRESULT get_source([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, uint*, int> get_crc;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, ulong*, int> get_length;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, ushort**, int> get_filename;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, ushort**, int> get_objectFilename;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, ushort**, int> get_virtualFilename;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, uint*, int> get_sourceCompression;

            [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaInjectedSource*, uint, uint*, byte*, int> get_source;
        }
    }
}
