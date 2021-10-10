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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList4*, int>)(lpVtbl[3]))((ITaskbarList4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int>)(lpVtbl[4]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int>)(lpVtbl[5]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int>)(lpVtbl[6]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveAlt([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int>)(lpVtbl[7]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int MarkFullscreenWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fFullscreen)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int, int>)(lpVtbl[8]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressValue([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, ulong, ulong, int>)(lpVtbl[9]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, ullCompleted, ullTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressState([NativeTypeName("HWND")] IntPtr hwnd, TBPFLAG tbpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, TBPFLAG, int>)(lpVtbl[10]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, tbpFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterTab([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, IntPtr, int>)(lpVtbl[11]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterTab([NativeTypeName("HWND")] IntPtr hwndTab)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, int>)(lpVtbl[12]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabOrder([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndInsertBefore)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, IntPtr, int>)(lpVtbl[13]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndInsertBefore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabActive([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, IntPtr, uint, int>)(lpVtbl[14]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarAddButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[15]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarUpdateButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[16]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarSetImageList([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HIMAGELIST")] IntPtr himl)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, IntPtr, int>)(lpVtbl[17]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, himl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayIcon([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, IntPtr, ushort*, int>)(lpVtbl[18]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, hIcon, pszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailTooltip([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, ushort*, int>)(lpVtbl[19]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, pszTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailClip([NativeTypeName("HWND")] IntPtr hwnd, RECT* prcClip)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, RECT*, int>)(lpVtbl[20]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwnd, prcClip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabProperties([NativeTypeName("HWND")] IntPtr hwndTab, STPFLAG stpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList4*, IntPtr, STPFLAG, int>)(lpVtbl[21]))((ITaskbarList4*)Unsafe.AsPointer(ref this), hwndTab, stpFlags);
        }
    }
}
