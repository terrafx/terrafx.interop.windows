// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("17C3779E-3CDE-4EDE-8C60-3899F5F53AD6")]
    [NativeTypeName("struct IMFSinkWriterEncoderConfig : IUnknown")]
    public unsafe partial struct IMFSinkWriterEncoderConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint>)(lpVtbl[1]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint>)(lpVtbl[2]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTargetMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pTargetMediaType, IMFAttributes* pEncodingParameters)
        {
            return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint, IMFMediaType*, IMFAttributes*, int>)(lpVtbl[3]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), dwStreamIndex, pTargetMediaType, pEncodingParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PlaceEncodingParameters([NativeTypeName("DWORD")] uint dwStreamIndex, IMFAttributes* pEncodingParameters)
        {
            return ((delegate* unmanaged<IMFSinkWriterEncoderConfig*, uint, IMFAttributes*, int>)(lpVtbl[4]))((IMFSinkWriterEncoderConfig*)Unsafe.AsPointer(ref this), dwStreamIndex, pEncodingParameters);
        }
    }
}
