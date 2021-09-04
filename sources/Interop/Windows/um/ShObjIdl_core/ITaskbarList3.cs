// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1AFB91-9E28-4B86-90E9-9E9F8A5EEFAF")]
    [NativeTypeName("struct ITaskbarList3 : ITaskbarList2")]
    public unsafe partial struct ITaskbarList3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITaskbarList3*, Guid*, void**, int>)(lpVtbl[0]))((ITaskbarList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[1]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITaskbarList3*, uint>)(lpVtbl[2]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HrInit()
        {
            return ((delegate* unmanaged<ITaskbarList3*, int>)(lpVtbl[3]))((ITaskbarList3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[4]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[5]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateTab([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[6]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveAlt([NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[7]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MarkFullscreenWindow([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int fFullscreen)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int, int>)(lpVtbl[8]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, fFullscreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressValue([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("ULONGLONG")] ulong ullCompleted, [NativeTypeName("ULONGLONG")] ulong ullTotal)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, ulong, ulong, int>)(lpVtbl[9]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, ullCompleted, ullTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressState([NativeTypeName("HWND")] IntPtr hwnd, TBPFLAG tbpFlags)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, TBPFLAG, int>)(lpVtbl[10]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, tbpFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterTab([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[11]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterTab([NativeTypeName("HWND")] IntPtr hwndTab)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, int>)(lpVtbl[12]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabOrder([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndInsertBefore)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[13]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndInsertBefore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabActive([NativeTypeName("HWND")] IntPtr hwndTab, [NativeTypeName("HWND")] IntPtr hwndMDI, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, uint, int>)(lpVtbl[14]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwndTab, hwndMDI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarAddButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[15]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarUpdateButtons([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint cButtons, [NativeTypeName("LPTHUMBBUTTON")] THUMBBUTTON* pButton)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, uint, THUMBBUTTON*, int>)(lpVtbl[16]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, cButtons, pButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ThumbBarSetImageList([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HIMAGELIST")] IntPtr himl)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, int>)(lpVtbl[17]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, himl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayIcon([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("LPCWSTR")] ushort* pszDescription)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, IntPtr, ushort*, int>)(lpVtbl[18]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, hIcon, pszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailTooltip([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszTip)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, ushort*, int>)(lpVtbl[19]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, pszTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailClip([NativeTypeName("HWND")] IntPtr hwnd, RECT* prcClip)
        {
            return ((delegate* unmanaged<ITaskbarList3*, IntPtr, RECT*, int>)(lpVtbl[20]))((ITaskbarList3*)Unsafe.AsPointer(ref this), hwnd, prcClip);
        }
    }
}
