// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C595E64-4630-4231-855A-12842F733245")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsicModel : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsicModel
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetModel(MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetModel([NativeTypeName("const MFExtendedCameraIntrinsic_IntrinsicModel *")] MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDistortionModelType(MFCameraIntrinsic_DistortionModelType* pDistortionModelType)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFCameraIntrinsic_DistortionModelType*, int>)(lpVtbl[5]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pDistortionModelType);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint> Release;

            [NativeTypeName("HRESULT (MFExtendedCameraIntrinsic_IntrinsicModel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int> GetModel;

            [NativeTypeName("HRESULT (const MFExtendedCameraIntrinsic_IntrinsicModel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int> SetModel;

            [NativeTypeName("HRESULT (MFCameraIntrinsic_DistortionModelType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFCameraIntrinsic_DistortionModelType*, int> GetDistortionModelType;
        }
    }
}
