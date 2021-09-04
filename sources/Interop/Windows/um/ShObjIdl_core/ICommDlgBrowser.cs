// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214F1-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICommDlgBrowser : IUnknown")]
    public unsafe partial struct ICommDlgBrowser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, Guid*, void**, int>)(lpVtbl[0]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, uint>)(lpVtbl[1]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, uint>)(lpVtbl[2]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDefaultCommand(IShellView* ppshv)
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, int>)(lpVtbl[3]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStateChange(IShellView* ppshv, [NativeTypeName("ULONG")] uint uChange)
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, uint, int>)(lpVtbl[4]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv, uChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IncludeObject(IShellView* ppshv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<ICommDlgBrowser*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[5]))((ICommDlgBrowser*)Unsafe.AsPointer(ref this), ppshv, pidl);
        }
    }
}
