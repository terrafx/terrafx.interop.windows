// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B22BCBF-2586-4AF0-8583-205D391B807C")]
    [NativeTypeName("struct IDeviceSpecificProperty : IUnknown")]
    public unsafe partial struct IDeviceSpecificProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, uint>)(lpVtbl[1]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, uint>)(lpVtbl[2]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("VARTYPE *")] ushort* pVType)
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, ushort*, int>)(lpVtbl[3]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pVType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("void *")] void* pvValue, [NativeTypeName("DWORD *")] uint* pcbValue)
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, void*, uint*, int>)(lpVtbl[4]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, pcbValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("void *")] void* pvValue, [NativeTypeName("DWORD")] uint cbValue, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, void*, uint, Guid*, int>)(lpVtbl[5]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, cbValue, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Get4BRange([NativeTypeName("LONG *")] int* plMin, [NativeTypeName("LONG *")] int* plMax, [NativeTypeName("LONG *")] int* plStepping)
        {
            return ((delegate* stdcall<IDeviceSpecificProperty*, int*, int*, int*, int>)(lpVtbl[6]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), plMin, plMax, plStepping);
        }
    }
}
