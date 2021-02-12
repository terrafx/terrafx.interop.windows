// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C595E64-4630-4231-855A-12842F733245")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsicModel : IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsicModel
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetModel([NativeTypeName("MFExtendedCameraIntrinsic_IntrinsicModel *")] MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetModel([NativeTypeName("const MFExtendedCameraIntrinsic_IntrinsicModel *")] MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDistortionModelType([NativeTypeName("MFCameraIntrinsic_DistortionModelType *")] MFCameraIntrinsic_DistortionModelType* pDistortionModelType)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFCameraIntrinsic_DistortionModelType*, int>)(lpVtbl[5]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pDistortionModelType);
        }
    }
}
