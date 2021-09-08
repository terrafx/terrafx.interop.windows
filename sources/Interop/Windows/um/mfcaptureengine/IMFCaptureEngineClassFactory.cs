// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8F02D140-56FC-4302-A705-3A97C78BE779")]
    [NativeTypeName("struct IMFCaptureEngineClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFCaptureEngineClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureEngineClassFactory*, uint>)(lpVtbl[1]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureEngineClassFactory*, uint>)(lpVtbl[2]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngineClassFactory*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((IMFCaptureEngineClassFactory*)Unsafe.AsPointer(ref this), clsid, riid, ppvObject);
        }
    }
}
