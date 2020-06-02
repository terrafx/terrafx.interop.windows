// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetProtocolSinkStackable
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SwitchSink([NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink)
        {
            return lpVtbl->SwitchSink((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), pOIProtSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitSwitch()
        {
            return lpVtbl->CommitSwitch((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RollbackSwitch()
        {
            return lpVtbl->RollbackSwitch((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, uint> Release;

            [NativeTypeName("HRESULT (IInternetProtocolSink *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, IInternetProtocolSink*, int> SwitchSink;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, int> CommitSwitch;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetProtocolSinkStackable*, int> RollbackSwitch;
        }
    }
}
