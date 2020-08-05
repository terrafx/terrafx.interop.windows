// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("683F7A5E-4A19-43CD-B1A9-DBF4AB3F7777")]
    [NativeTypeName("struct IMFSensorActivitiesReport : IUnknown")]
    public unsafe partial struct IMFSensorActivitiesReport
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, uint>)(lpVtbl[1]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, uint>)(lpVtbl[2]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("ULONG *")] uint* pcCount)
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, uint*, int>)(lpVtbl[3]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetActivityReport([NativeTypeName("ULONG")] uint Index, [NativeTypeName("IMFSensorActivityReport **")] IMFSensorActivityReport** sensorActivityReport)
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, uint, IMFSensorActivityReport**, int>)(lpVtbl[4]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), Index, sensorActivityReport);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetActivityReportByDeviceName([NativeTypeName("LPCWSTR")] ushort* SymbolicName, [NativeTypeName("IMFSensorActivityReport **")] IMFSensorActivityReport** sensorActivityReport)
        {
            return ((delegate* stdcall<IMFSensorActivitiesReport*, ushort*, IMFSensorActivityReport**, int>)(lpVtbl[5]))((IMFSensorActivitiesReport*)Unsafe.AsPointer(ref this), SymbolicName, sensorActivityReport);
        }
    }
}
