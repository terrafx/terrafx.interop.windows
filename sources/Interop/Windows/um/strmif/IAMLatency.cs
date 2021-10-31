// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62EA93BA-EC62-11D2-B770-00C04FB6BD3D")]
    [NativeTypeName("struct IAMLatency : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMLatency
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMLatency*, Guid*, void**, int>)(lpVtbl[0]))((IAMLatency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMLatency*, uint>)(lpVtbl[1]))((IAMLatency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMLatency*, uint>)(lpVtbl[2]))((IAMLatency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
        {
            return ((delegate* unmanaged<IAMLatency*, long*, int>)(lpVtbl[3]))((IAMLatency*)Unsafe.AsPointer(ref this), prtLatency);
        }
    }
}
