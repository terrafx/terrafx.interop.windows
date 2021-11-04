// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09F656A2-41AF-480C-88F7-16CC0D164615")]
    [NativeTypeName("struct ISearchContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISearchContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISearchContext*, Guid*, void**, int>)(lpVtbl[0]))((ISearchContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISearchContext*, uint>)(lpVtbl[1]))((ISearchContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISearchContext*, uint>)(lpVtbl[2]))((ISearchContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSearchUrl([NativeTypeName("BSTR *")] ushort** pbstrSearchUrl)
        {
            return ((delegate* unmanaged<ISearchContext*, ushort**, int>)(lpVtbl[3]))((ISearchContext*)Unsafe.AsPointer(ref this), pbstrSearchUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSearchText([NativeTypeName("BSTR *")] ushort** pbstrSearchText)
        {
            return ((delegate* unmanaged<ISearchContext*, ushort**, int>)(lpVtbl[4]))((ISearchContext*)Unsafe.AsPointer(ref this), pbstrSearchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSearchStyle([NativeTypeName("DWORD *")] uint* pdwSearchStyle)
        {
            return ((delegate* unmanaged<ISearchContext*, uint*, int>)(lpVtbl[5]))((ISearchContext*)Unsafe.AsPointer(ref this), pdwSearchStyle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, ushort**, int> GetSearchUrl;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, ushort**, int> GetSearchText;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ISearchContext*, uint*, int> GetSearchStyle;
        }
    }
}
