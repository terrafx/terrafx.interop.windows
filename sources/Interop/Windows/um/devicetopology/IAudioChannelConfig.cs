// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB11C46F-EC28-493C-B88A-5DB88062CE98")]
    public unsafe partial struct IAudioChannelConfig
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioChannelConfig*, Guid*, void**, int>)(lpVtbl[0]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioChannelConfig*, uint>)(lpVtbl[1]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioChannelConfig*, uint>)(lpVtbl[2]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelConfig([NativeTypeName("DWORD")] uint dwConfig, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IAudioChannelConfig*, uint, Guid*, int>)(lpVtbl[3]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), dwConfig, pguidEventContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelConfig([NativeTypeName("DWORD *")] uint* pdwConfig)
        {
            return ((delegate* stdcall<IAudioChannelConfig*, uint*, int>)(lpVtbl[4]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), pdwConfig);
        }
    }
}
