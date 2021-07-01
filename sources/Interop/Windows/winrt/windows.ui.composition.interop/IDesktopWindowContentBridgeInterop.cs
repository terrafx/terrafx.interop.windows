// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37642806-F421-4FD0-9F82-23AE7C776182")]
    [NativeTypeName("struct IDesktopWindowContentBridgeInterop : IUnknown")]
    public unsafe partial struct IDesktopWindowContentBridgeInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, uint>)(lpVtbl[1]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, uint>)(lpVtbl[2]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("Windows::UI::Composition::ICompositor *")] void* compositor, [NativeTypeName("HWND")] IntPtr parentHwnd)
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, void*, IntPtr, int>)(lpVtbl[3]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), compositor, parentHwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Hwnd([NativeTypeName("HWND *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, IntPtr*, int>)(lpVtbl[4]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppliedScaleFactor(float* value)
        {
            return ((delegate* unmanaged<IDesktopWindowContentBridgeInterop*, float*, int>)(lpVtbl[5]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
