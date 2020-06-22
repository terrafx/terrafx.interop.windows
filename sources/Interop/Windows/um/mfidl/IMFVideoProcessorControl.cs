// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3F675D5-6119-4F7F-A100-1D8B280F0EFB")]
    public unsafe partial struct IMFVideoProcessorControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("MFARGB *")] MFARGB* pBorderColor)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceRectangle([NativeTypeName("RECT *")] RECT* pSrcRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationRectangle([NativeTypeName("RECT *")] RECT* pDstRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eMirror);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), eRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetConstrictionSize([NativeTypeName("SIZE *")] SIZE* pConstrictionSize)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }
    }
}
