// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B22BCBF-2586-4AF0-8583-205D391B807C")]
    [NativeTypeName("struct IDeviceSpecificProperty : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDeviceSpecificProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, Guid*, void**, int>)(lpVtbl[0]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, uint>)(lpVtbl[1]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, uint>)(lpVtbl[2]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetType([NativeTypeName("VARTYPE *")] ushort* pVType)
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, ushort*, int>)(lpVtbl[3]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pVType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetValue(void* pvValue, [NativeTypeName("DWORD *")] uint* pcbValue)
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, void*, uint*, int>)(lpVtbl[4]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, pcbValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetValue(void* pvValue, [NativeTypeName("DWORD")] uint cbValue, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, void*, uint, Guid*, int>)(lpVtbl[5]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), pvValue, cbValue, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Get4BRange([NativeTypeName("LONG *")] int* plMin, [NativeTypeName("LONG *")] int* plMax, [NativeTypeName("LONG *")] int* plStepping)
        {
            return ((delegate* unmanaged<IDeviceSpecificProperty*, int*, int*, int*, int>)(lpVtbl[6]))((IDeviceSpecificProperty*)Unsafe.AsPointer(ref this), plMin, plMax, plStepping);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, uint> Release;

            [NativeTypeName("HRESULT (VARTYPE *) __attribute__((stdcall))")]
            public new delegate* unmanaged<IDeviceSpecificProperty*, ushort*, int> GetType;

            [NativeTypeName("HRESULT (void *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, void*, uint*, int> GetValue;

            [NativeTypeName("HRESULT (void *, DWORD, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, void*, uint, Guid*, int> SetValue;

            [NativeTypeName("HRESULT (LONG *, LONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeviceSpecificProperty*, int*, int*, int*, int> Get4BRange;
        }
    }
}
