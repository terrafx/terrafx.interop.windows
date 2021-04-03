// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2424B3F2-EB23-40F1-91AA-74BDDEEA0883")]
    [NativeTypeName("struct IMFVideoProcessorControl3 : IMFVideoProcessorControl2")]
    public unsafe partial struct IMFVideoProcessorControl3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor(MFARGB* pBorderColor)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceRectangle(RECT* pSrcRect)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationRectangle(RECT* pDstRect)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eMirror);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConstrictionSize(SIZE* pConstrictionSize)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotationOverride([NativeTypeName("UINT")] uint uiRotation)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint, int>)(lpVtbl[9]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), uiRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHardwareEffects([NativeTypeName("BOOL")] int fEnabled)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, int, int>)(lpVtbl[10]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSupportedHardwareEffects([NativeTypeName("UINT *")] uint* puiSupport)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint*, int>)(lpVtbl[11]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), puiSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNaturalOutputType(IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, IMFMediaType**, int>)(lpVtbl[12]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableSphericalVideoProcessing([NativeTypeName("BOOL")] int fEnable, MFVideoSphericalFormat eFormat, MFVideoSphericalProjectionMode eProjectionMode)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, int, MFVideoSphericalFormat, MFVideoSphericalProjectionMode, int>)(lpVtbl[13]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnable, eFormat, eProjectionMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, float, float, float, float, float, int>)(lpVtbl[14]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), X, Y, Z, W, fieldOfView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputDevice(IUnknown* pOutputDevice)
        {
            return ((delegate* unmanaged<IMFVideoProcessorControl3*, IUnknown*, int>)(lpVtbl[15]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pOutputDevice);
        }
    }
}
