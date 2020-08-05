// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29E691FA-4567-4DCA-B319-D0F207EB6807")]
    [NativeTypeName("struct ICompositorDesktopInterop : IUnknown")]
    public unsafe partial struct ICompositorDesktopInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICompositorDesktopInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICompositorDesktopInterop*, uint>)(lpVtbl[1]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICompositorDesktopInterop*, uint>)(lpVtbl[2]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDesktopWindowTarget([NativeTypeName("HWND")] IntPtr hwndTarget, [NativeTypeName("BOOL")] int isTopmost, [NativeTypeName("ABI::Windows::UI::Composition::Desktop::IDesktopWindowTarget **")] void** result)
        {
            return ((delegate* stdcall<ICompositorDesktopInterop*, IntPtr, int, void**, int>)(lpVtbl[3]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), hwndTarget, isTopmost, result);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnsureOnThread([NativeTypeName("DWORD")] uint threadId)
        {
            return ((delegate* stdcall<ICompositorDesktopInterop*, uint, int>)(lpVtbl[4]))((ICompositorDesktopInterop*)Unsafe.AsPointer(ref this), threadId);
        }
    }
}
