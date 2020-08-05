// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7901327-05DD-4469-A7B7-0E01979E361D")]
    [NativeTypeName("struct IMFMediaSourceExtensionNotify : IUnknown")]
    public unsafe partial struct IMFMediaSourceExtensionNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionNotify*, uint>)(lpVtbl[1]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSourceExtensionNotify*, uint>)(lpVtbl[2]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
        }

        public void OnSourceOpen()
        {
            ((delegate* stdcall<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[3]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
        }

        public void OnSourceEnded()
        {
            ((delegate* stdcall<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[4]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
        }

        public void OnSourceClose()
        {
            ((delegate* stdcall<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[5]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
