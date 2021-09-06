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
    public unsafe partial struct IQueryAssociations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryAssociations*, Guid*, void**, int>)(lpVtbl[0]))((IQueryAssociations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint>)(lpVtbl[1]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint>)(lpVtbl[2]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("ASSOCF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, [NativeTypeName("HKEY")] IntPtr hkProgid, [NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ushort*, IntPtr, IntPtr, int>)(lpVtbl[3]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, pszAssoc, hkProgid, hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCSTR, ushort*, ushort*, uint*, int>)(lpVtbl[4]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, str, pszExtra, pszOut, pcchOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKey([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("HKEY *")] IntPtr* phkeyOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCKEY, ushort*, IntPtr*, int>)(lpVtbl[5]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, key, pszExtra, phkeyOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("ASSOCF")] uint flags, ASSOCDATA data, [NativeTypeName("LPCWSTR")] ushort* pszExtra, void* pvOut, [NativeTypeName("DWORD *")] uint* pcbOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCDATA, ushort*, void*, uint*, int>)(lpVtbl[6]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, data, pszExtra, pvOut, pcbOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnum([NativeTypeName("ASSOCF")] uint flags, ASSOCENUM assocenum, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
        {
            return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCENUM, ushort*, Guid*, void**, int>)(lpVtbl[7]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, assocenum, pszExtra, riid, ppvOut);
        }
    }
}
