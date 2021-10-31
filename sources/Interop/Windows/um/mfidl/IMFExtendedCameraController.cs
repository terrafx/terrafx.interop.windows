// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B91EBFEE-CA03-4AF4-8A82-A31752F4A0FC")]
    [NativeTypeName("struct IMFExtendedCameraController : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFExtendedCameraController
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraController*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraController*, uint>)(lpVtbl[1]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraController*, uint>)(lpVtbl[2]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetExtendedCameraControl([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("ULONG")] uint ulPropertyId, IMFExtendedCameraControl** ppControl)
        {
            return ((delegate* unmanaged<IMFExtendedCameraController*, uint, uint, IMFExtendedCameraControl**, int>)(lpVtbl[3]))((IMFExtendedCameraController*)Unsafe.AsPointer(ref this), dwStreamIndex, ulPropertyId, ppControl);
        }
    }
}
