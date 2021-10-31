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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFDXGIDeviceManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, uint>)(lpVtbl[1]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, uint>)(lpVtbl[2]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CloseDeviceHandle([NativeTypeName("HANDLE")] IntPtr hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, int>)(lpVtbl[3]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetVideoService([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppService)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, Guid*, void**, int>)(lpVtbl[4]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppService);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT LockDevice([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppUnkDevice, BOOL fBlock)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, Guid*, void**, BOOL, int>)(lpVtbl[5]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppUnkDevice, fBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OpenDeviceHandle([NativeTypeName("HANDLE *")] IntPtr* phDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr*, int>)(lpVtbl[6]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), phDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResetDevice(IUnknown* pUnkDevice, [NativeTypeName("UINT")] uint resetToken)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IUnknown*, uint, int>)(lpVtbl[7]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), pUnkDevice, resetToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT TestDevice([NativeTypeName("HANDLE")] IntPtr hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, int>)(lpVtbl[8]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT UnlockDevice([NativeTypeName("HANDLE")] IntPtr hDevice, BOOL fSaveState)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IntPtr, BOOL, int>)(lpVtbl[9]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, fSaveState);
        }
    }
}
