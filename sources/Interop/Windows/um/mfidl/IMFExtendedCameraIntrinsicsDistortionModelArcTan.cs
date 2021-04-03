// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("812D5F95-B572-45DC-BAFC-AE24199DDDA8")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsicsDistortionModelArcTan : IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsicsDistortionModelArcTan
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDistortionModel(MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelArcTan *")] MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }
    }
}
