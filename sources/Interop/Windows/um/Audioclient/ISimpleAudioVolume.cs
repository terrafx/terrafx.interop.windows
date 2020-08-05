// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8")]
    [NativeTypeName("struct ISimpleAudioVolume : IUnknown")]
    public unsafe partial struct ISimpleAudioVolume
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, uint>)(lpVtbl[1]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, uint>)(lpVtbl[2]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMasterVolume(float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, float, Guid*, int>)(lpVtbl[3]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this), fLevel, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMasterVolume([NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, float*, int>)(lpVtbl[4]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this), pfLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("const BOOL")] int bMute, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, int, Guid*, int>)(lpVtbl[5]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this), bMute, EventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pbMute)
        {
            return ((delegate* stdcall<ISimpleAudioVolume*, int*, int>)(lpVtbl[6]))((ISimpleAudioVolume*)Unsafe.AsPointer(ref this), pbMute);
        }
    }
}
