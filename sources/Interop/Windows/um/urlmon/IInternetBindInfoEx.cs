// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3E015B7-A82C-4DCD-A150-569AEEED36AB")]
    [NativeTypeName("struct IInternetBindInfoEx : IInternetBindInfo")]
    [NativeInheritance("IInternetBindInfo")]
    public unsafe partial struct IInternetBindInfoEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, uint>)(lpVtbl[1]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, uint>)(lpVtbl[2]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, uint*, BINDINFO*, int>)(lpVtbl[3]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] ushort** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched)
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, uint, ushort**, uint, uint*, int>)(lpVtbl[4]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), ulStringType, ppwzStr, cEl, pcElFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* unmanaged<IInternetBindInfoEx*, uint*, BINDINFO*, uint*, uint*, int>)(lpVtbl[5]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, uint*, BINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (ULONG, LPOLESTR *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, uint, ushort**, uint, uint*, int> GetBindString;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetBindInfoEx*, uint*, BINDINFO*, uint*, uint*, int> GetBindInfoEx;
        }
    }
}
