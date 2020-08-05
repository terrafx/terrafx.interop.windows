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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDistortionModel([NativeTypeName("MFCameraIntrinsic_DistortionModelArcTan *")] MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelArcTan *")] MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* stdcall<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }
    }
}
