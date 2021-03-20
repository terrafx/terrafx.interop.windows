// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DEC4C6C4-93E8-4F7C-BE27-CEFAA1AF68A7")]
    [NativeTypeName("struct ICoreWindowFlyoutFactory : IInspectable")]
    public unsafe partial struct ICoreWindowFlyoutFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, uint>)(lpVtbl[1]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, uint>)(lpVtbl[2]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("ABI::Windows::Foundation::Point")] Point position, [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")] ICoreWindowFlyout** coreWindowFlyout)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, Point, ICoreWindowFlyout**, int>)(lpVtbl[6]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), position, coreWindowFlyout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithTitle([NativeTypeName("ABI::Windows::Foundation::Point")] Point position, [NativeTypeName("HSTRING")] IntPtr title, [NativeTypeName("ABI::Windows::UI::Core::ICoreWindowFlyout **")] ICoreWindowFlyout** coreWindowFlyout)
        {
            return ((delegate* unmanaged<ICoreWindowFlyoutFactory*, Point, IntPtr, ICoreWindowFlyout**, int>)(lpVtbl[7]))((ICoreWindowFlyoutFactory*)Unsafe.AsPointer(ref this), position, title, coreWindowFlyout);
        }
    }
}
