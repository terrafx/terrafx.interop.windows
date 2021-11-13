// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("EB533D5D-2DB6-40F8-97A9-494692014F07")]
    [NativeTypeName("struct IMFDXGIDeviceManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFDXGIDeviceManager : IMFDXGIDeviceManager.Interface
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
        public HRESULT CloseDeviceHandle(HANDLE hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, int>)(lpVtbl[3]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetVideoService(HANDLE hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppService)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, Guid*, void**, int>)(lpVtbl[4]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppService);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT LockDevice(HANDLE hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppUnkDevice, BOOL fBlock)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, Guid*, void**, BOOL, int>)(lpVtbl[5]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, riid, ppUnkDevice, fBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OpenDeviceHandle(HANDLE* phDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE*, int>)(lpVtbl[6]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), phDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ResetDevice(IUnknown* pUnkDevice, uint resetToken)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, IUnknown*, uint, int>)(lpVtbl[7]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), pUnkDevice, resetToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT TestDevice(HANDLE hDevice)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, int>)(lpVtbl[8]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT UnlockDevice(HANDLE hDevice, BOOL fSaveState)
        {
            return ((delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, BOOL, int>)(lpVtbl[9]))((IMFDXGIDeviceManager*)Unsafe.AsPointer(ref this), hDevice, fSaveState);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CloseDeviceHandle(HANDLE hDevice);

            [VtblIndex(4)]
            HRESULT GetVideoService(HANDLE hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppService);

            [VtblIndex(5)]
            HRESULT LockDevice(HANDLE hDevice, [NativeTypeName("const IID &")] Guid* riid, void** ppUnkDevice, BOOL fBlock);

            [VtblIndex(6)]
            HRESULT OpenDeviceHandle(HANDLE* phDevice);

            [VtblIndex(7)]
            HRESULT ResetDevice(IUnknown* pUnkDevice, uint resetToken);

            [VtblIndex(8)]
            HRESULT TestDevice(HANDLE hDevice);

            [VtblIndex(9)]
            HRESULT UnlockDevice(HANDLE hDevice, BOOL fSaveState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, uint> Release;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, int> CloseDeviceHandle;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, Guid*, void**, int> GetVideoService;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, Guid*, void**, BOOL, int> LockDevice;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE*, int> OpenDeviceHandle;

            [NativeTypeName("HRESULT (IUnknown *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, IUnknown*, uint, int> ResetDevice;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, int> TestDevice;

            [NativeTypeName("HRESULT (HANDLE, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFDXGIDeviceManager*, HANDLE, BOOL, int> UnlockDevice;
        }
    }
}
