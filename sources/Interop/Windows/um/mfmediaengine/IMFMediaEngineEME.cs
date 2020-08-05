// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("50DC93E4-BA4F-4275-AE66-83E836E57469")]
    [NativeTypeName("struct IMFMediaEngineEME : IUnknown")]
    public unsafe partial struct IMFMediaEngineEME
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineEME*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineEME*, uint>)(lpVtbl[1]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineEME*, uint>)(lpVtbl[2]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Keys([NativeTypeName("IMFMediaKeys **")] IMFMediaKeys** keys)
        {
            return ((delegate* stdcall<IMFMediaEngineEME*, IMFMediaKeys**, int>)(lpVtbl[3]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMediaKeys([NativeTypeName("IMFMediaKeys *")] IMFMediaKeys* keys)
        {
            return ((delegate* stdcall<IMFMediaEngineEME*, IMFMediaKeys*, int>)(lpVtbl[4]))((IMFMediaEngineEME*)Unsafe.AsPointer(ref this), keys);
        }
    }
}
