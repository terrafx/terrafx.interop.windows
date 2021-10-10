// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("39DC7F4A-B141-4719-813C-A7F46162A2B8")]
    [NativeTypeName("struct IMFSensorProcessActivity : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSensorProcessActivity
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, uint>)(lpVtbl[1]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, uint>)(lpVtbl[2]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcessId([NativeTypeName("ULONG *")] uint* pPID)
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, uint*, int>)(lpVtbl[3]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pPID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamingState([NativeTypeName("BOOL *")] int* pfStreaming)
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, int*, int>)(lpVtbl[4]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pfStreaming);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamingMode(MFSensorDeviceMode* pMode)
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, MFSensorDeviceMode*, int>)(lpVtbl[5]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetReportTime(FILETIME* pft)
        {
            return ((delegate* unmanaged<IMFSensorProcessActivity*, FILETIME*, int>)(lpVtbl[6]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pft);
        }
    }
}
