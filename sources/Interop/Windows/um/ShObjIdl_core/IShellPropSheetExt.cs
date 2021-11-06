// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E9-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellPropSheetExt : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellPropSheetExt : IShellPropSheetExt.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellPropSheetExt*, Guid*, void**, int>)(lpVtbl[0]))((IShellPropSheetExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellPropSheetExt*, uint>)(lpVtbl[1]))((IShellPropSheetExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellPropSheetExt*, uint>)(lpVtbl[2]))((IShellPropSheetExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPages([NativeTypeName("LPFNSVADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfnAddPage, LPARAM lParam)
        {
            return ((delegate* unmanaged<IShellPropSheetExt*, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int>)(lpVtbl[3]))((IShellPropSheetExt*)Unsafe.AsPointer(ref this), pfnAddPage, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReplacePage([NativeTypeName("EXPPS")] uint uPageID, [NativeTypeName("LPFNSVADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfnReplaceWith, LPARAM lParam)
        {
            return ((delegate* unmanaged<IShellPropSheetExt*, uint, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int>)(lpVtbl[4]))((IShellPropSheetExt*)Unsafe.AsPointer(ref this), uPageID, pfnReplaceWith, lParam);
        }

        public interface Interface : IUnknown.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellPropSheetExt*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellPropSheetExt*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellPropSheetExt*, uint> Release;

            [NativeTypeName("HRESULT (LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellPropSheetExt*, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int> AddPages;

            [NativeTypeName("HRESULT (EXPPS, LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellPropSheetExt*, uint, delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>, LPARAM, int> ReplacePage;
        }
    }
}
