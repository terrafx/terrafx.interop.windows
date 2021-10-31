// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E1D6009-C9F3-442D-8C51-A42D2D49452F")]
    [NativeTypeName("struct IMFMediaSourceTopologyProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaSourceTopologyProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, uint>)(lpVtbl[1]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, uint>)(lpVtbl[2]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetMediaSourceTopology(IMFPresentationDescriptor* pPresentationDescriptor, IMFTopology** ppTopology)
        {
            return ((delegate* unmanaged<IMFMediaSourceTopologyProvider*, IMFPresentationDescriptor*, IMFTopology**, int>)(lpVtbl[3]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor, ppTopology);
        }
    }
}
