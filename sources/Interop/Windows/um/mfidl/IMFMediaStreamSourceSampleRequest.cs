// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("380B9AF9-A85B-4E78-A2AF-EA5CE645C6B4")]
    [NativeTypeName("struct IMFMediaStreamSourceSampleRequest : IUnknown")]
    public unsafe partial struct IMFMediaStreamSourceSampleRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaStreamSourceSampleRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaStreamSourceSampleRequest*, uint>)(lpVtbl[1]))((IMFMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaStreamSourceSampleRequest*, uint>)(lpVtbl[2]))((IMFMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSample(IMFSample* value)
        {
            return ((delegate* unmanaged<IMFMediaStreamSourceSampleRequest*, IMFSample*, int>)(lpVtbl[3]))((IMFMediaStreamSourceSampleRequest*)Unsafe.AsPointer(ref this), value);
        }
    }
}
