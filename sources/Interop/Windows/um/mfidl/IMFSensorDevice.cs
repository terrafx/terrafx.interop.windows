// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FB9F48F2-2A18-4E28-9730-786F30F04DC4")]
    [NativeTypeName("struct IMFSensorDevice : IUnknown")]
    public unsafe partial struct IMFSensorDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorDevice*, uint>)(lpVtbl[1]))((IMFSensorDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorDevice*, uint>)(lpVtbl[2]))((IMFSensorDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceId([NativeTypeName("ULONGLONG *")] ulong* pDeviceId)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, ulong*, int>)(lpVtbl[3]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), pDeviceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceType(MFSensorDeviceType* pType)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, MFSensorDeviceType*, int>)(lpVtbl[4]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("ULONGLONG *")] ulong* pFlags)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, ulong*, int>)(lpVtbl[5]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSymbolicLink([NativeTypeName("LPWSTR")] ushort* SymbolicLink, [NativeTypeName("LONG")] int cchSymbolicLink, [NativeTypeName("LONG *")] int* pcchWritten)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, ushort*, int, int*, int>)(lpVtbl[6]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), SymbolicLink, cchSymbolicLink, pcchWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceAttributes(IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, IMFAttributes**, int>)(lpVtbl[7]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttributesCount(MFSensorStreamType eType, [NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, MFSensorStreamType, uint*, int>)(lpVtbl[8]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), eType, pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttributes(MFSensorStreamType eType, [NativeTypeName("DWORD")] uint dwIndex, IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, MFSensorStreamType, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), eType, dwIndex, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSensorDeviceMode(MFSensorDeviceMode eMode)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, MFSensorDeviceMode, int>)(lpVtbl[10]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), eMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSensorDeviceMode(MFSensorDeviceMode* peMode)
        {
            return ((delegate* unmanaged<IMFSensorDevice*, MFSensorDeviceMode*, int>)(lpVtbl[11]))((IMFSensorDevice*)Unsafe.AsPointer(ref this), peMode);
        }
    }
}
