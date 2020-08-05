// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("765763E6-6C01-4B01-BB0F-B829F60ED28C")]
    [NativeTypeName("struct IMFMediaEngineOPMInfo : IUnknown")]
    public unsafe partial struct IMFMediaEngineOPMInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineOPMInfo*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineOPMInfo*, uint>)(lpVtbl[1]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineOPMInfo*, uint>)(lpVtbl[2]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOPMInfo([NativeTypeName("MF_MEDIA_ENGINE_OPM_STATUS *")] MF_MEDIA_ENGINE_OPM_STATUS* pStatus, [NativeTypeName("BOOL *")] int* pConstricted)
        {
            return ((delegate* stdcall<IMFMediaEngineOPMInfo*, MF_MEDIA_ENGINE_OPM_STATUS*, int*, int>)(lpVtbl[3]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this), pStatus, pConstricted);
        }
    }
}
