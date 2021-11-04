// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4110243A-9757-461F-89F1-F22345BCAB4E")]
    [NativeTypeName("struct IMFSensorGroup : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSensorGroup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint>)(lpVtbl[1]))((IMFSensorGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint>)(lpVtbl[2]))((IMFSensorGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("LONG")] int cchSymbolicLink, [NativeTypeName("LONG *")] int* pcchWritten)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, ushort*, int, int*, int>)(lpVtbl[3]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), SymbolicLink, cchSymbolicLink, pcchWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, ulong*, int>)(lpVtbl[4]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSensorGroupAttributes(IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, IMFAttributes**, int>)(lpVtbl[5]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetSensorDeviceCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint*, int>)(lpVtbl[6]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSensorDevice([NativeTypeName("DWORD")] uint dwIndex, IMFSensorDevice** ppDevice)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint, IMFSensorDevice**, int>)(lpVtbl[7]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), dwIndex, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDefaultSensorDeviceIndex([NativeTypeName("DWORD")] uint dwIndex)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint, int>)(lpVtbl[8]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), dwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDefaultSensorDeviceIndex([NativeTypeName("DWORD *")] uint* pdwIndex)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint*, int>)(lpVtbl[9]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pdwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateMediaSource(IMFMediaSource** ppSource)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, IMFMediaSource**, int>)(lpVtbl[10]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), ppSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR, LONG, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, ushort*, int, int*, int> GetSymbolicLink;

            [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, ulong*, int> GetFlags;

            [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, IMFAttributes**, int> GetSensorGroupAttributes;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint*, int> GetSensorDeviceCount;

            [NativeTypeName("HRESULT (DWORD, IMFSensorDevice **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint, IMFSensorDevice**, int> GetSensorDevice;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint, int> SetDefaultSensorDeviceIndex;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, uint*, int> GetDefaultSensorDeviceIndex;

            [NativeTypeName("HRESULT (IMFMediaSource **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorGroup*, IMFMediaSource**, int> CreateMediaSource;
        }
    }
}
