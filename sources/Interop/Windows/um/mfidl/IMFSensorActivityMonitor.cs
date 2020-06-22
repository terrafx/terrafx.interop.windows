// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D0CEF145-B3F4-4340-A2E5-7A5080CA05CB")]
    public unsafe partial struct IMFSensorActivityMonitor
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSensorActivityMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSensorActivityMonitor*, uint>)(lpVtbl[1]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSensorActivityMonitor*, uint>)(lpVtbl[2]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* stdcall<IMFSensorActivityMonitor*, int>)(lpVtbl[3]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IMFSensorActivityMonitor*, int>)(lpVtbl[4]))((IMFSensorActivityMonitor*)Unsafe.AsPointer(ref this));
        }
    }
}
