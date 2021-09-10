// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("02997C3B-8E1B-460E-9270-545E0DE9563E")]
    [NativeTypeName("struct IVideoEncoder : IEncoderAPI")]
    [NativeInheritance("IEncoderAPI")]
    public unsafe partial struct IVideoEncoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IVideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoEncoder*, uint>)(lpVtbl[1]))((IVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoEncoder*, uint>)(lpVtbl[2]))((IVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, int>)(lpVtbl[3]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, int>)(lpVtbl[4]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[7]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[8]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[9]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }
    }
}
