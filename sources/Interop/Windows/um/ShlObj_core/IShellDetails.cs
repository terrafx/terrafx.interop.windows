// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214EC-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellDetails : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellDetails
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellDetails*, Guid*, void**, int>)(lpVtbl[0]))((IShellDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellDetails*, uint>)(lpVtbl[1]))((IShellDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellDetails*, uint>)(lpVtbl[2]))((IShellDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* pDetails)
        {
            return ((delegate* unmanaged<IShellDetails*, ITEMIDLIST*, uint, SHELLDETAILS*, int>)(lpVtbl[3]))((IShellDetails*)Unsafe.AsPointer(ref this), pidl, iColumn, pDetails);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ColumnClick(uint iColumn)
        {
            return ((delegate* unmanaged<IShellDetails*, uint, int>)(lpVtbl[4]))((IShellDetails*)Unsafe.AsPointer(ref this), iColumn);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDetails*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDetails*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDetails*, uint> Release;

            [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT, SHELLDETAILS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDetails*, ITEMIDLIST*, uint, SHELLDETAILS*, int> GetDetailsOf;

            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellDetails*, uint, int> ColumnClick;
        }
    }
}
