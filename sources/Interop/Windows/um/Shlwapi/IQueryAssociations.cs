// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C46CA590-3C3F-11D2-BEE6-0000F805CA57")]
    [NativeTypeName("struct IQueryAssociations : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQueryAssociations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryAssociations*, Guid*, void**, int>)(lpVtbl[0]))((IQueryAssociations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint>)(lpVtbl[1]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint>)(lpVtbl[2]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Init([NativeTypeName("ASSOCF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, HKEY hkProgid, HWND hwnd)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ushort*, HKEY, HWND, int>)(lpVtbl[3]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, pszAssoc, hkProgid, hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetString([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCSTR, ushort*, ushort*, uint*, int>)(lpVtbl[4]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, str, pszExtra, pszOut, pcchOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetKey([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] ushort* pszExtra, HKEY* phkeyOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCKEY, ushort*, HKEY*, int>)(lpVtbl[5]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, key, pszExtra, phkeyOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetData([NativeTypeName("ASSOCF")] uint flags, ASSOCDATA data, [NativeTypeName("LPCWSTR")] ushort* pszExtra, void* pvOut, [NativeTypeName("DWORD *")] uint* pcbOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCDATA, ushort*, void*, uint*, int>)(lpVtbl[6]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, data, pszExtra, pvOut, pcbOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetEnum([NativeTypeName("ASSOCF")] uint flags, ASSOCENUM assocenum, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCENUM, ushort*, Guid*, void**, int>)(lpVtbl[7]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, assocenum, pszExtra, riid, ppvOut);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint> Release;

            [NativeTypeName("HRESULT (ASSOCF, LPCWSTR, HKEY, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint, ushort*, HKEY, HWND, int> Init;

            [NativeTypeName("HRESULT (ASSOCF, ASSOCSTR, LPCWSTR, LPWSTR, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint, ASSOCSTR, ushort*, ushort*, uint*, int> GetString;

            [NativeTypeName("HRESULT (ASSOCF, ASSOCKEY, LPCWSTR, HKEY *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint, ASSOCKEY, ushort*, HKEY*, int> GetKey;

            [NativeTypeName("HRESULT (ASSOCF, ASSOCDATA, LPCWSTR, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint, ASSOCDATA, ushort*, void*, uint*, int> GetData;

            [NativeTypeName("HRESULT (ASSOCF, ASSOCENUM, LPCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IQueryAssociations*, uint, ASSOCENUM, ushort*, Guid*, void**, int> GetEnum;
        }
    }
}
