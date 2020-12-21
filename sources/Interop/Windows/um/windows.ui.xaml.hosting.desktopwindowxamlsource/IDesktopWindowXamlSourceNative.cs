// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3CBCF1BF-2F76-4E9C-96AB-E84B37972554")]
    [NativeTypeName("struct IDesktopWindowXamlSourceNative : IUnknown")]
    public unsafe partial struct IDesktopWindowXamlSourceNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative*, uint>)(lpVtbl[1]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative*, uint>)(lpVtbl[2]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AttachToWindow([NativeTypeName("HWND")] IntPtr parentWnd)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative*, IntPtr, int>)(lpVtbl[3]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), parentWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WindowHandle([NativeTypeName("HWND *")] IntPtr* hWnd)
        {
            return ((delegate* unmanaged[Stdcall]<IDesktopWindowXamlSourceNative*, IntPtr*, int>)(lpVtbl[4]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), hWnd);
        }
    }
}
