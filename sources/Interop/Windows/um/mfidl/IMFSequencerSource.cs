// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("197CD219-19CB-4DE1-A64C-ACF2EDCBE59E")]
    [NativeTypeName("struct IMFSequencerSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSequencerSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSequencerSource*, uint>)(lpVtbl[1]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSequencerSource*, uint>)(lpVtbl[2]))((IMFSequencerSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTopology(IMFTopology* pTopology, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("MFSequencerElementId *")] uint* pdwId)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, IMFTopology*, uint, uint*, int>)(lpVtbl[3]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pTopology, dwFlags, pdwId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteTopology([NativeTypeName("MFSequencerElementId")] uint dwId)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, uint, int>)(lpVtbl[4]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationContext(IMFPresentationDescriptor* pPD, [NativeTypeName("MFSequencerElementId *")] uint* pId, IMFTopology** ppTopology)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, IMFPresentationDescriptor*, uint*, IMFTopology**, int>)(lpVtbl[5]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), pPD, pId, ppTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTopology([NativeTypeName("MFSequencerElementId")] uint dwId, IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, uint, IMFTopology*, int>)(lpVtbl[6]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTopologyFlags([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFSequencerSource*, uint, uint, int>)(lpVtbl[7]))((IMFSequencerSource*)Unsafe.AsPointer(ref this), dwId, dwFlags);
        }
    }
}
