// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5730A90-1A2C-11CF-8C23-00AA006B6814")]
    [NativeTypeName("struct IAMExtDevice : IUnknown")]
    public unsafe partial struct IAMExtDevice
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMExtDevice*, Guid*, void**, int>)(lpVtbl[0]))((IAMExtDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMExtDevice*, uint>)(lpVtbl[1]))((IAMExtDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMExtDevice*, uint>)(lpVtbl[2]))((IAMExtDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCapability([NativeTypeName("long")] int Capability, [NativeTypeName("long *")] int* pValue, [NativeTypeName("double *")] double* pdblValue)
        {
            return ((delegate* stdcall<IAMExtDevice*, int, int*, double*, int>)(lpVtbl[3]))((IAMExtDevice*)Unsafe.AsPointer(ref this), Capability, pValue, pdblValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ExternalDeviceID([NativeTypeName("LPOLESTR *")] ushort** ppszData)
        {
            return ((delegate* stdcall<IAMExtDevice*, ushort**, int>)(lpVtbl[4]))((IAMExtDevice*)Unsafe.AsPointer(ref this), ppszData);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ExternalDeviceVersion([NativeTypeName("LPOLESTR *")] ushort** ppszData)
        {
            return ((delegate* stdcall<IAMExtDevice*, ushort**, int>)(lpVtbl[5]))((IAMExtDevice*)Unsafe.AsPointer(ref this), ppszData);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_DevicePower([NativeTypeName("long")] int PowerMode)
        {
            return ((delegate* stdcall<IAMExtDevice*, int, int>)(lpVtbl[6]))((IAMExtDevice*)Unsafe.AsPointer(ref this), PowerMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DevicePower([NativeTypeName("long *")] int* pPowerMode)
        {
            return ((delegate* stdcall<IAMExtDevice*, int*, int>)(lpVtbl[7]))((IAMExtDevice*)Unsafe.AsPointer(ref this), pPowerMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Calibrate([NativeTypeName("HEVENT")] nuint hEvent, [NativeTypeName("long")] int Mode, [NativeTypeName("long *")] int* pStatus)
        {
            return ((delegate* stdcall<IAMExtDevice*, nuint, int, int*, int>)(lpVtbl[8]))((IAMExtDevice*)Unsafe.AsPointer(ref this), hEvent, Mode, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_DevicePort([NativeTypeName("long")] int DevicePort)
        {
            return ((delegate* stdcall<IAMExtDevice*, int, int>)(lpVtbl[9]))((IAMExtDevice*)Unsafe.AsPointer(ref this), DevicePort);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DevicePort([NativeTypeName("long *")] int* pDevicePort)
        {
            return ((delegate* stdcall<IAMExtDevice*, int*, int>)(lpVtbl[10]))((IAMExtDevice*)Unsafe.AsPointer(ref this), pDevicePort);
        }
    }
}
