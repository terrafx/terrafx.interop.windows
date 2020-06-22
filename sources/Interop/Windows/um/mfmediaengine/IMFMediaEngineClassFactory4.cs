// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBE256C1-43CF-4A9B-8CB8-CE8632A34186")]
    public unsafe partial struct IMFMediaEngineClassFactory4
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactory4*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactory4*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactory4*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateContentDecryptionModuleFactory([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineClassFactory4*, ushort*, Guid*, void**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this), keySystem, riid, ppvObject);
        }
    }
}
