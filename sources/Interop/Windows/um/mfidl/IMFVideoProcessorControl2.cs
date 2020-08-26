// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDE633D3-E1DC-4A7F-A693-BBAE399C4A20")]
    [NativeTypeName("struct IMFVideoProcessorControl2 : IMFVideoProcessorControl")]
    public unsafe partial struct IMFVideoProcessorControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("MFARGB *")] MFARGB* pBorderColor)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pBorderColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceRectangle([NativeTypeName("RECT *")] RECT* pSrcRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pSrcRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationRectangle([NativeTypeName("RECT *")] RECT* pDstRect)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pDstRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eMirror);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), eRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetConstrictionSize([NativeTypeName("SIZE *")] SIZE* pConstrictionSize)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), pConstrictionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotationOverride([NativeTypeName("UINT")] uint uiRotation)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, uint, int>)(lpVtbl[9]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), uiRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHardwareEffects([NativeTypeName("BOOL")] int fEnabled)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, int, int>)(lpVtbl[10]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), fEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSupportedHardwareEffects([NativeTypeName("UINT *")] uint* puiSupport)
        {
            return ((delegate* stdcall<IMFVideoProcessorControl2*, uint*, int>)(lpVtbl[11]))((IMFVideoProcessorControl2*)Unsafe.AsPointer(ref this), puiSupport);
        }
    }
}
