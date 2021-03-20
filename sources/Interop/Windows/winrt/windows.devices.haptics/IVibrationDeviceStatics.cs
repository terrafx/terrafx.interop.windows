// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53E2EDED-2290-4AC9-8EB3-1A84122EB71C")]
    [NativeTypeName("struct IVibrationDeviceStatics : IInspectable")]
    public unsafe partial struct IVibrationDeviceStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, uint>)(lpVtbl[1]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, uint>)(lpVtbl[2]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IntPtr*, int>)(lpVtbl[4]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationAccessStatus_t **")] IAsyncOperation<VibrationAccessStatus>** operation)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IAsyncOperation<VibrationAccessStatus>**, int>)(lpVtbl[6]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceSelector([NativeTypeName("HSTRING *")] IntPtr* result)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IntPtr*, int>)(lpVtbl[7]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FromIdAsync([NativeTypeName("HSTRING")] IntPtr deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindAllAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CHaptics__CVibrationDevice_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IVibrationDeviceStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IVibrationDeviceStatics*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
