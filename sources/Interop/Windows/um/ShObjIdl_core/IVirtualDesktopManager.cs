// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5CD92FF-29BE-454C-8D04-D82879FB3F1B")]
    [NativeTypeName("struct IVirtualDesktopManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVirtualDesktopManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, uint>)(lpVtbl[1]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, uint>)(lpVtbl[2]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IsWindowOnCurrentVirtualDesktop([NativeTypeName("HWND")] IntPtr topLevelWindow, BOOL* onCurrentDesktop)
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, IntPtr, BOOL*, int>)(lpVtbl[3]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, onCurrentDesktop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindowDesktopId([NativeTypeName("HWND")] IntPtr topLevelWindow, [NativeTypeName("GUID *")] Guid* desktopId)
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, IntPtr, Guid*, int>)(lpVtbl[4]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, desktopId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveWindowToDesktop([NativeTypeName("HWND")] IntPtr topLevelWindow, [NativeTypeName("const GUID &")] Guid* desktopId)
        {
            return ((delegate* unmanaged<IVirtualDesktopManager*, IntPtr, Guid*, int>)(lpVtbl[5]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, desktopId);
        }
    }
}
