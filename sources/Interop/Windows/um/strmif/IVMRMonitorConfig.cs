// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CF0B1B6-FBAA-4B7F-88CF-CF1F130A0DCE")]
    [NativeTypeName("struct IVMRMonitorConfig : IUnknown")]
    public unsafe partial struct IVMRMonitorConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, uint>)(lpVtbl[1]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, uint>)(lpVtbl[2]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[3]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitor([NativeTypeName("VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[4]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[5]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultMonitor([NativeTypeName("VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[6]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableMonitors([NativeTypeName("VMRMONITORINFO *")] VMRMONITORINFO* pInfo, [NativeTypeName("DWORD")] uint dwMaxInfoArraySize, [NativeTypeName("DWORD *")] uint* pdwNumDevices)
        {
            return ((delegate* unmanaged[Stdcall]<IVMRMonitorConfig*, VMRMONITORINFO*, uint, uint*, int>)(lpVtbl[7]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pInfo, dwMaxInfoArraySize, pdwNumDevices);
        }
    }
}
