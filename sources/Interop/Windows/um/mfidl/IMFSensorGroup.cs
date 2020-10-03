// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4110243A-9757-461F-89F1-F22345BCAB4E")]
    [NativeTypeName("struct IMFSensorGroup : IUnknown")]
    public unsafe partial struct IMFSensorGroup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint>)(lpVtbl[1]))((IMFSensorGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint>)(lpVtbl[2]))((IMFSensorGroup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("LONG")] int cchSymbolicLink, [NativeTypeName("LONG *")] int* pcchWritten)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, ushort*, int, int*, int>)(lpVtbl[3]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), SymbolicLink, cchSymbolicLink, pcchWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, ulong*, int>)(lpVtbl[4]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSensorGroupAttributes([NativeTypeName("IMFAttributes **")] IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, IMFAttributes**, int>)(lpVtbl[5]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSensorDeviceCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint*, int>)(lpVtbl[6]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSensorDevice([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFSensorDevice **")] IMFSensorDevice** ppDevice)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint, IMFSensorDevice**, int>)(lpVtbl[7]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), dwIndex, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSensorDeviceIndex([NativeTypeName("DWORD")] uint dwIndex)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint, int>)(lpVtbl[8]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), dwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultSensorDeviceIndex([NativeTypeName("DWORD *")] uint* pdwIndex)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, uint*, int>)(lpVtbl[9]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), pdwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaSource([NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppSource)
        {
            return ((delegate* unmanaged<IMFSensorGroup*, IMFMediaSource**, int>)(lpVtbl[10]))((IMFSensorGroup*)Unsafe.AsPointer(ref this), ppSource);
        }
    }
}
