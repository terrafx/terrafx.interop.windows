// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D8B1437-DD53-4350-9C1B-1EE2890BD938")]
    [NativeTypeName("struct IAudioLoudness : IUnknown")]
    public unsafe partial struct IAudioLoudness
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioLoudness*, Guid*, void**, int>)(lpVtbl[0]))((IAudioLoudness*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioLoudness*, uint>)(lpVtbl[1]))((IAudioLoudness*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioLoudness*, uint>)(lpVtbl[2]))((IAudioLoudness*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnabled([NativeTypeName("BOOL *")] int* pbEnabled)
        {
            return ((delegate* stdcall<IAudioLoudness*, int*, int>)(lpVtbl[3]))((IAudioLoudness*)Unsafe.AsPointer(ref this), pbEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEnabled([NativeTypeName("BOOL")] int bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioLoudness*, int, Guid*, int>)(lpVtbl[4]))((IAudioLoudness*)Unsafe.AsPointer(ref this), bEnable, pguidEventContext);
        }
    }
}
