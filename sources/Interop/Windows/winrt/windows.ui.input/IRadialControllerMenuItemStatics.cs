// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("249E0887-D842-4524-9DF8-E0D647EDC887")]
    [NativeTypeName("struct IRadialControllerMenuItemStatics : IInspectable")]
    public unsafe partial struct IRadialControllerMenuItemStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, uint>)(lpVtbl[1]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, uint>)(lpVtbl[2]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromIcon([NativeTypeName("HSTRING")] IntPtr displayText, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* icon, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, IntPtr, IRandomAccessStreamReference*, IRadialControllerMenuItem**, int>)(lpVtbl[6]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), displayText, icon, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromKnownIcon([NativeTypeName("HSTRING")] IntPtr displayText, [NativeTypeName("ABI::Windows::UI::Input::RadialControllerMenuKnownIcon")] RadialControllerMenuKnownIcon value, [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")] IRadialControllerMenuItem** result)
        {
            return ((delegate* unmanaged<IRadialControllerMenuItemStatics*, IntPtr, RadialControllerMenuKnownIcon, IRadialControllerMenuItem**, int>)(lpVtbl[7]))((IRadialControllerMenuItemStatics*)Unsafe.AsPointer(ref this), displayText, value, result);
        }
    }
}
