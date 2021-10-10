// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("10339516-2894-11D2-9039-00C04F8EEB3E")]
    [NativeTypeName("struct ICommDlgBrowser2 : ICommDlgBrowser")]
    [NativeInheritance("ICommDlgBrowser")]
    public unsafe partial struct ICommDlgBrowser2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, Guid*, void**, int>)(lpVtbl[0]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, uint>)(lpVtbl[1]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, uint>)(lpVtbl[2]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnDefaultCommand(IShellView* ppshv)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, IShellView*, int>)(lpVtbl[3]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), ppshv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnStateChange(IShellView* ppshv, [NativeTypeName("ULONG")] uint uChange)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, IShellView*, uint, int>)(lpVtbl[4]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), ppshv, uChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IncludeObject(IShellView* ppshv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[5]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), ppshv, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Notify(IShellView* ppshv, [NativeTypeName("DWORD")] uint dwNotifyType)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, IShellView*, uint, int>)(lpVtbl[6]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), ppshv, dwNotifyType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultMenuText(IShellView* ppshv, [NativeTypeName("LPWSTR")] ushort* pszText, int cchMax)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, IShellView*, ushort*, int, int>)(lpVtbl[7]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), ppshv, pszText, cchMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ICommDlgBrowser2*, uint*, int>)(lpVtbl[8]))((ICommDlgBrowser2*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
