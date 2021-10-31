// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CF0B1B6-FBAA-4B7F-88CF-CF1F130A0DCE")]
    [NativeTypeName("struct IVMRMonitorConfig : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVMRMonitorConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, uint>)(lpVtbl[1]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, uint>)(lpVtbl[2]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[3]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMonitor(VMRGUID* pGUID)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[4]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDefaultMonitor([NativeTypeName("const VMRGUID *")] VMRGUID* pGUID)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[5]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDefaultMonitor(VMRGUID* pGUID)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, VMRGUID*, int>)(lpVtbl[6]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pGUID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetAvailableMonitors(VMRMONITORINFO* pInfo, [NativeTypeName("DWORD")] uint dwMaxInfoArraySize, [NativeTypeName("DWORD *")] uint* pdwNumDevices)
        {
            return ((delegate* unmanaged<IVMRMonitorConfig*, VMRMONITORINFO*, uint, uint*, int>)(lpVtbl[7]))((IVMRMonitorConfig*)Unsafe.AsPointer(ref this), pInfo, dwMaxInfoArraySize, pdwNumDevices);
        }
    }
}
