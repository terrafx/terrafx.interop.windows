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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int OnItemClick(IShellItem* psi, [NativeTypeName("NSTCEHITTEST")] uint nstceHitTest, [NativeTypeName("NSTCECLICKTYPE")] uint nstceClickType)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[3]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstceHitTest, nstceClickType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnPropertyItemCommit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[4]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int OnItemStateChanging(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[5]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int OnItemStateChanged(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisState)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, uint, uint, int>)(lpVtbl[6]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int OnSelectionChanged(IShellItemArray* psiaSelection)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItemArray*, int>)(lpVtbl[7]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psiaSelection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyboardInput([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, uint, nuint, nint, int>)(lpVtbl[8]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int OnBeforeExpand(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[9]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int OnAfterExpand(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[10]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int OnBeginLabelEdit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[11]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndLabelEdit(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[12]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int OnGetToolTip(IShellItem* psi, [NativeTypeName("LPWSTR")] ushort* pszTip, int cchTip)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, ushort*, int, int>)(lpVtbl[13]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pszTip, cchTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int OnBeforeItemDelete(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[14]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int OnItemAdded(IShellItem* psi, BOOL fIsRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int>)(lpVtbl[15]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int OnItemDeleted(IShellItem* psi, BOOL fIsRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, BOOL, int>)(lpVtbl[16]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, fIsRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int OnBeforeContextMenu(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, Guid*, void**, int>)(lpVtbl[17]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int OnAfterContextMenu(IShellItem* psi, IContextMenu* pcmIn, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, IContextMenu*, Guid*, void**, int>)(lpVtbl[18]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, pcmIn, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int OnBeforeStateImageChange(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int>)(lpVtbl[19]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int OnGetDefaultIconIndex(IShellItem* psi, int* piDefaultIcon, int* piOpenIcon)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlEvents*, IShellItem*, int*, int*, int>)(lpVtbl[20]))((INameSpaceTreeControlEvents*)Unsafe.AsPointer(ref this), psi, piDefaultIcon, piOpenIcon);
        }
    }
}
