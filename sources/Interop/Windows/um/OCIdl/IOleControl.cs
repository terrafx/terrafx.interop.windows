// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IOleControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetControlInfo([NativeTypeName("CONTROLINFO *")] CONTROLINFO* pCI)
        {
            return lpVtbl->GetControlInfo((IOleControl*)Unsafe.AsPointer(ref this), pCI);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnMnemonic([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return lpVtbl->OnMnemonic((IOleControl*)Unsafe.AsPointer(ref this), pMsg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnAmbientPropertyChange([NativeTypeName("DISPID")] int dispID)
        {
            return lpVtbl->OnAmbientPropertyChange((IOleControl*)Unsafe.AsPointer(ref this), dispID);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreezeEvents([NativeTypeName("BOOL")] int bFreeze)
        {
            return lpVtbl->FreezeEvents((IOleControl*)Unsafe.AsPointer(ref this), bFreeze);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, uint> Release;

            [NativeTypeName("HRESULT (CONTROLINFO *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, CONTROLINFO*, int> GetControlInfo;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, MSG*, int> OnMnemonic;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, int, int> OnAmbientPropertyChange;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleControl*, int, int> FreezeEvents;
        }
    }
}
