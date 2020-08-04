// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37642806-F421-4FD0-9F82-23AE7C776182")]
    public unsafe partial struct IDesktopWindowContentBridgeInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, uint>)(lpVtbl[1]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, uint>)(lpVtbl[2]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("Windows::UI::Composition::ICompositor *")] void* compositor, [NativeTypeName("HWND")] IntPtr parentHwnd)
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, void*, IntPtr, int>)(lpVtbl[3]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), compositor, parentHwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Hwnd([NativeTypeName("HWND *")] IntPtr* value)
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, IntPtr*, int>)(lpVtbl[4]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AppliedScaleFactor([NativeTypeName("float *")] float* value)
        {
            return ((delegate* stdcall<IDesktopWindowContentBridgeInterop*, float*, int>)(lpVtbl[5]))((IDesktopWindowContentBridgeInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
