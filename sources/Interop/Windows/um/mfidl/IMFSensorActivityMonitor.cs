// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("D0CEF145-B3F4-4340-A2E5-7A5080CA05CB")]
    [NativeTypeName("struct IMFSensorActivityMonitor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSensorActivityMonitor : IMFSensorActivityMonitor.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSensorActivityMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSensorActivityMonitor*, uint>)(lpVtbl[1]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSensorActivityMonitor*, uint>)(lpVtbl[2]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Start()
        {
            return ((delegate* unmanaged<IMFSensorActivityMonitor*, int>)(lpVtbl[3]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IMFSensorActivityMonitor*, int>)(lpVtbl[4]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Start();

            [VtblIndex(4)]
            HRESULT Stop();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorActivityMonitor*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorActivityMonitor*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorActivityMonitor*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorActivityMonitor*, int> Start;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSensorActivityMonitor*, int> Stop;
        }
    }
}
