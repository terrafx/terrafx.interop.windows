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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("MFARGB *")] MFARGB* pBorderColor)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceRectangle([NativeTypeName("RECT *")] RECT* pSrcRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationRectangle([NativeTypeName("RECT *")] RECT* pDstRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eMirror);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetConstrictionSize([NativeTypeName("SIZE *")] SIZE* pConstrictionSize)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotationOverride([NativeTypeName("UINT")] uint uiRotation)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, uint, int>)(lpVtbl[9]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), uiRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableHardwareEffects([NativeTypeName("BOOL")] int fEnabled)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, int, int>)(lpVtbl[10]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSupportedHardwareEffects([NativeTypeName("UINT *")] uint* puiSupport)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, uint*, int>)(lpVtbl[11]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), puiSupport);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNaturalOutputType([NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, IMFMediaType**, int>)(lpVtbl[12]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), ppType);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableSphericalVideoProcessing([NativeTypeName("BOOL")] int fEnable, MFVideoSphericalFormat eFormat, MFVideoSphericalProjectionMode eProjectionMode)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, int, MFVideoSphericalFormat, MFVideoSphericalProjectionMode, int>)(lpVtbl[13]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnable, eFormat, eProjectionMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, float, float, float, float, float, int>)(lpVtbl[14]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), X, Y, Z, W, fieldOfView);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputDevice([NativeTypeName("IUnknown *")] IUnknown* pOutputDevice)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl3*, IUnknown*, int>)(lpVtbl[15]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pOutputDevice);
        }
    }
}
