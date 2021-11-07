// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("812D5F95-B572-45DC-BAFC-AE24199DDDA8")]
    [NativeTypeName("struct IMFExtendedCameraIntrinsicsDistortionModelArcTan : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFExtendedCameraIntrinsicsDistortionModelArcTan : IMFExtendedCameraIntrinsicsDistortionModelArcTan.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelArcTan *")] MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel)
        {
            return ((delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicsDistortionModelArcTan*)Unsafe.AsPointer(ref this), pDistortionModel);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel);

            [VtblIndex(4)]
            HRESULT SetDistortionModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelArcTan *")] MFCameraIntrinsic_DistortionModelArcTan* pDistortionModel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, uint> Release;

            [NativeTypeName("HRESULT (MFCameraIntrinsic_DistortionModelArcTan *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int> GetDistortionModel;

            [NativeTypeName("HRESULT (const MFCameraIntrinsic_DistortionModelArcTan *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModelArcTan*, MFCameraIntrinsic_DistortionModelArcTan*, int> SetDistortionModel;
        }
    }
}
