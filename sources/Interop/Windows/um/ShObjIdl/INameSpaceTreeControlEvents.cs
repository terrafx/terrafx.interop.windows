// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93D77985-B3D8-4484-8318-672CDDA002CE")]
    [NativeTypeName("struct INameSpaceTreeControlEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControlEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint>)(lpVtbl[1]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint>)(lpVtbl[2]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnItemClick(IShellItem* psi, [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest, [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[3]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstceHitTest, nstceClickType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnPropertyItemCommit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[4]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnItemStateChanging(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[5]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnItemStateChanged(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[6]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnSelectionChanged(IShellItemArray* psiaSelection)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItemArray*, int>)(lpVtbl[7]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psiaSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnKeyboardInput(uint uMsg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint, WPARAM, LPARAM, int>)(lpVtbl[8]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnBeforeExpand(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[9]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnAfterExpand(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[10]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT OnBeginLabelEdit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[11]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT OnEndLabelEdit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[12]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT OnGetToolTip(IShellItem* psi, [NativeTypeName("LPWSTR")] ushort* pszTip, int cchTip)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, ushort*, int, int>)(lpVtbl[13]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pszTip, cchTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT OnBeforeItemDelete(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[14]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT OnItemAdded(IShellItem* psi, BOOL fIsRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int>)(lpVtbl[15]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT OnItemDeleted(IShellItem* psi, BOOL fIsRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int>)(lpVtbl[16]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT OnBeforeContextMenu(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, Guid*, void**, int>)(lpVtbl[17]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT OnAfterContextMenu(IShellItem* psi, IContextMenu* pcmIn, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, IContextMenu*, Guid*, void**, int>)(lpVtbl[18]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pcmIn, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT OnBeforeStateImageChange(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[19]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT OnGetDefaultIconIndex(IShellItem* psi, int* piDefaultIcon, int* piOpenIcon)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int*, int*, int>)(lpVtbl[20]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, piDefaultIcon, piOpenIcon);
        }
    }
}
