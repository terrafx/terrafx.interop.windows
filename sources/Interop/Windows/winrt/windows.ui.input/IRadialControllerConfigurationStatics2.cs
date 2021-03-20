// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53E08B17-E205-48D3-9CAF-80FF47C4D7C7")]
    [NativeTypeName("struct IRadialControllerConfigurationStatics2 : IInspectable")]
    public unsafe partial struct IRadialControllerConfigurationStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, uint>)(lpVtbl[1]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, uint>)(lpVtbl[2]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, IRadialController*, int>)(lpVtbl[6]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppController([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, IRadialController**, int>)(lpVtbl[7]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsAppControllerEnabled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, byte, int>)(lpVtbl[8]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsAppControllerEnabled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRadialControllerConfigurationStatics2*, byte*, int>)(lpVtbl[9]))((IRadialControllerConfigurationStatics2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
