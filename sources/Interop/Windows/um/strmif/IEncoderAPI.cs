// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70423839-6ACC-4B23-B079-21DBF08156A5")]
    [NativeTypeName("struct IEncoderAPI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEncoderAPI
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, void**, int>)(lpVtbl[0]))((IEncoderAPI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEncoderAPI*, uint>)(lpVtbl[1]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEncoderAPI*, uint>)(lpVtbl[2]))((IEncoderAPI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, int>)(lpVtbl[3]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, int>)(lpVtbl[4]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[7]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[8]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IEncoderAPI*, Guid*, VARIANT*, int>)(lpVtbl[9]))((IEncoderAPI*)Unsafe.AsPointer(ref this), Api, Value);
        }
    }
}
