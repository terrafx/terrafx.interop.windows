// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB533D5D-2DB6-40F8-97A9-494692014F07")]
    [NativeTypeName("struct IMFDXGIDeviceManager : IUnknown")]
    public unsafe partial struct IMFDXGIDeviceManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, uint>)(lpVtbl[1]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, uint>)(lpVtbl[2]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloseDeviceHandle([NativeTypeName("HANDLE")] IntPtr hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, int>)(lpVtbl[3]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoService([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppService)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, Guid*, void**, int>)(lpVtbl[4]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppService);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockDevice([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppUnkDevice, [NativeTypeName("BOOL")] int fBlock)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, Guid*, void**, int, int>)(lpVtbl[5]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppUnkDevice, fBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenDeviceHandle([NativeTypeName("HANDLE *")] IntPtr* phDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr*, int>)(lpVtbl[6]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), phDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetDevice(IUnknown* pUnkDevice, [NativeTypeName("UINT")] uint resetToken)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IUnknown*, uint, int>)(lpVtbl[7]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), pUnkDevice, resetToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TestDevice([NativeTypeName("HANDLE")] IntPtr hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, int>)(lpVtbl[8]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockDevice([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("BOOL")] int fSaveState)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, int, int>)(lpVtbl[9]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, fSaveState);
        }
    }
}
