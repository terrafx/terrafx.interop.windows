// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E1D6009-C9F3-442D-8C51-A42D2D49452F")]
    [NativeTypeName("struct IMFMediaSourceTopologyProvider : IUnknown")]
    public unsafe partial struct IMFMediaSourceTopologyProvider
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSourceTopologyProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSourceTopologyProvider*, uint>)(lpVtbl[1]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSourceTopologyProvider*, uint>)(lpVtbl[2]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaSourceTopology([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("IMFTopology **")] IMFTopology** ppTopology)
        {
            return ((delegate* stdcall<IMFMediaSourceTopologyProvider*, IMFPresentationDescriptor*, IMFTopology**, int>)(lpVtbl[3]))((IMFMediaSourceTopologyProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor, ppTopology);
        }
    }
}
