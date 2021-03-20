// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8B89AA1-D1C6-416E-BD8D-5790914DC563")]
    [NativeTypeName("struct IPointerDeviceStatics : IInspectable")]
    public unsafe partial struct IPointerDeviceStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, uint>)(lpVtbl[1]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, uint>)(lpVtbl[2]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, IntPtr*, int>)(lpVtbl[4]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointerDevice([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("ABI::Windows::Devices::Input::IPointerDevice **")] IPointerDevice** pointerDevice)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, uint, IPointerDevice**, int>)(lpVtbl[6]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), pointerId, pointerDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointerDevices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CInput__CPointerDevice_t **")] IVectorView<IntPtr>** pointerDevices)
        {
            return ((delegate* unmanaged<IPointerDeviceStatics*, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((IPointerDeviceStatics*)Unsafe.AsPointer(ref this), pointerDevices);
        }
    }
}
