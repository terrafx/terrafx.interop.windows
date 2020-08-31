// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D0751585-D216-4344-B5BF-463B68F977BB")]
    [NativeTypeName("struct IAdvancedMediaCapture : IUnknown")]
    public unsafe partial struct IAdvancedMediaCapture
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAdvancedMediaCapture*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAdvancedMediaCapture*, uint>)(lpVtbl[1]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAdvancedMediaCapture*, uint>)(lpVtbl[2]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdvancedMediaCaptureSettings([NativeTypeName("IAdvancedMediaCaptureSettings **")] IAdvancedMediaCaptureSettings** value)
        {
            return ((delegate* stdcall<IAdvancedMediaCapture*, IAdvancedMediaCaptureSettings**, int>)(lpVtbl[3]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this), value);
        }
    }
}
