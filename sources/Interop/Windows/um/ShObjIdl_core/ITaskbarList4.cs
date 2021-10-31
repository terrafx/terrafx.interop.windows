// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C43DC798-95D1-4BEA-9030-BB99E2983A1A")]
    [NativeTypeName("struct ITaskbarList4 : ITaskbarList3")]
    [NativeInheritance("ITaskbarList3")]
    public unsafe partial struct ITaskbarList4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITaskbarList4*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITaskbarList4*, uint>)(lpVtbl[1]))((ITaskbarList4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITaskbarList4*, uint>)(lpVtbl[2]))((ITaskbarList4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList4*, int>)(lpVtbl[3]))((ITaskbarList4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, int>)(lpVtbl[4]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DeleteTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, int>)(lpVtbl[5]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ActivateTab(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, int>)(lpVtbl[6]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetActiveAlt(HWND hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, int>)(lpVtbl[7]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, BOOL, int>)(lpVtbl[8]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetProgressValue(HWND hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, ulong, ulong, int>)(lpVtbl[9]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, ullCompleted, ullTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetProgressState(HWND hwnd, TBPFLAG tbpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, TBPFLAG, int>)(lpVtbl[10]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, tbpFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RegisterTab(HWND hwndTab, HWND hwndMDI)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, HWND, int>)(lpVtbl[11]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT UnregisterTab(HWND hwndTab)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, int>)(lpVtbl[12]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetTabOrder(HWND hwndTab, HWND hwndInsertBefore)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, HWND, int>)(lpVtbl[13]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndInsertBefore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetTabActive(HWND hwndTab, HWND hwndMDI, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, HWND, uint, int>)(lpVtbl[14]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ThumbBarAddButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, uint, THUMBBUTTON*, int>)(lpVtbl[15]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ThumbBarUpdateButtons(HWND hwnd, uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, uint, THUMBBUTTON*, int>)(lpVtbl[16]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ThumbBarSetImageList(HWND hwnd, HIMAGELIST himl)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, HIMAGELIST, int>)(lpVtbl[17]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, himl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetOverlayIcon(HWND hwnd, HICON hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, HICON, ushort*, int>)(lpVtbl[18]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, hIcon, pszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetThumbnailTooltip(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, ushort*, int>)(lpVtbl[19]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, pszTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetThumbnailClip(HWND hwnd, RECT* prcClip)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, RECT*, int>)(lpVtbl[20]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, prcClip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetTabProperties(HWND hwndTab, STPFLAG stpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList4*, HWND, STPFLAG, int>)(lpVtbl[21]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, stpFlags);
        }
    }
}
