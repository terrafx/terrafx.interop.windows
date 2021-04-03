// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56181D2D-E221-4ADB-B1C8-3CEE6A53F76F")]
    [NativeTypeName("struct IMFMetadataProvider : IUnknown")]
    public unsafe partial struct IMFMetadataProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMetadataProvider*, Guid*, void**, int>)(lpVtbl[0]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMetadataProvider*, uint>)(lpVtbl[1]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMetadataProvider*, uint>)(lpVtbl[2]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMFMetadata(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint dwFlags, IMFMetadata** ppMFMetadata)
        {
            return ((delegate* unmanaged<IMFMetadataProvider*, IMFPresentationDescriptor*, uint, uint, IMFMetadata**, int>)(lpVtbl[3]))((IMFMetadataProvider*)Unsafe.AsPointer(ref this), pPresentationDescriptor, dwStreamIdentifier, dwFlags, ppMFMetadata);
        }
    }
}
