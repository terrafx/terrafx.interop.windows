// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510413-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IWPCBlockedUrls : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWPCBlockedUrls : IWPCBlockedUrls.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWPCBlockedUrls*, Guid*, void**, int>)(lpVtbl[0]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWPCBlockedUrls*, uint>)(lpVtbl[1]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWPCBlockedUrls*, uint>)(lpVtbl[2]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IWPCBlockedUrls*, uint*, int>)(lpVtbl[3]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetUrl([NativeTypeName("DWORD")] uint dwIdx, [NativeTypeName("BSTR *")] ushort** pbstrUrl)
        {
            return ((delegate* unmanaged<IWPCBlockedUrls*, uint, ushort**, int>)(lpVtbl[4]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), dwIdx, pbstrUrl);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(4)]
            HRESULT GetUrl([NativeTypeName("DWORD")] uint dwIdx, [NativeTypeName("BSTR *")] ushort** pbstrUrl);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWPCBlockedUrls*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWPCBlockedUrls*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWPCBlockedUrls*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWPCBlockedUrls*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWPCBlockedUrls*, uint, ushort**, int> GetUrl;
        }
    }
}
