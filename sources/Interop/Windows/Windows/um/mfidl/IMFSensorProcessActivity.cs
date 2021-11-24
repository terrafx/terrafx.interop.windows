// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("39DC7F4A-B141-4719-813C-A7F46162A2B8")]
[NativeTypeName("struct IMFSensorProcessActivity : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorProcessActivity : IMFSensorProcessActivity.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public HRESULT GetProcessId([NativeTypeName("ULONG *")] uint* pPID)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity*, uint*, int>)(lpVtbl[3]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pPID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStreamingState(BOOL* pfStreaming)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity*, BOOL*, int>)(lpVtbl[4]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pfStreaming);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamingMode(MFSensorDeviceMode* pMode)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity*, MFSensorDeviceMode*, int>)(lpVtbl[5]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReportTime(FILETIME* pft)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity*, FILETIME*, int>)(lpVtbl[6]))((IMFSensorProcessActivity*)Unsafe.AsPointer(ref this), pft);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetProcessId([NativeTypeName("ULONG *")] uint* pPID);

        [VtblIndex(4)]
        HRESULT GetStreamingState(BOOL* pfStreaming);

        [VtblIndex(5)]
        HRESULT GetStreamingMode(MFSensorDeviceMode* pMode);

        [VtblIndex(6)]
        HRESULT GetReportTime(FILETIME* pft);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, uint*, int> GetProcessId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, BOOL*, int> GetStreamingState;

        [NativeTypeName("HRESULT (MFSensorDeviceMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, MFSensorDeviceMode*, int> GetStreamingMode;

        [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFSensorProcessActivity*, FILETIME*, int> GetReportTime;
    }
}
