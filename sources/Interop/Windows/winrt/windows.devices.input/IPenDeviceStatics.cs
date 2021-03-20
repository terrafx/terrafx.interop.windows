// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9DFBBE01-0966-5180-BCB4-B85060E39479")]
    [NativeTypeName("struct IPenDeviceStatics : IInspectable")]
    public unsafe partial struct IPenDeviceStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, uint>)(lpVtbl[1]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, uint>)(lpVtbl[2]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, IntPtr*, int>)(lpVtbl[4]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFromPointerId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::Devices::Input::IPenDevice **")] IPenDevice** result)
        {
            return ((delegate* unmanaged<IPenDeviceStatics*, uint, IPenDevice**, int>)(lpVtbl[6]))((IPenDeviceStatics*)Unsafe.AsPointer(ref this), pointerId, result);
        }
    }
}
