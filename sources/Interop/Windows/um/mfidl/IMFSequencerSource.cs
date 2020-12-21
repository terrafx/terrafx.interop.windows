// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("197CD219-19CB-4DE1-A64C-ACF2EDCBE59E")]
    [NativeTypeName("struct IMFSequencerSource : IUnknown")]
    public unsafe partial struct IMFSequencerSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, uint>)(lpVtbl[1]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, uint>)(lpVtbl[2]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTopology([NativeTypeName("IMFTopology *")] IMFTopology* pTopology, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("MFSequencerElementId *")] uint* pdwId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, IMFTopology*, uint, uint*, int>)(lpVtbl[3]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pTopology, dwFlags, pdwId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteTopology([NativeTypeName("MFSequencerElementId")] uint dwId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, uint, int>)(lpVtbl[4]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationContext([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPD, [NativeTypeName("MFSequencerElementId *")] uint* pId, [NativeTypeName("IMFTopology **")] IMFTopology** ppTopology)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, IMFPresentationDescriptor*, uint*, IMFTopology**, int>)(lpVtbl[5]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pPD, pId, ppTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTopology([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, uint, IMFTopology*, int>)(lpVtbl[6]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTopologyFlags([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSequencerSource*, uint, uint, int>)(lpVtbl[7]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, dwFlags);
        }
    }
}
