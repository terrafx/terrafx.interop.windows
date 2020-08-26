// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IOleControl : IUnknown")]
    public unsafe partial struct IOleControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleControl*, Guid*, void**, int>)(lpVtbl[0]))((IOleControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleControl*, uint>)(lpVtbl[1]))((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleControl*, uint>)(lpVtbl[2]))((IOleControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlInfo([NativeTypeName("CONTROLINFO *")] CONTROLINFO* pCI)
        {
            return ((delegate* stdcall<IOleControl*, CONTROLINFO*, int>)(lpVtbl[3]))((IOleControl*)Unsafe.AsPointer(ref this), pCI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnMnemonic([NativeTypeName("MSG *")] MSG* pMsg)
        {
            return ((delegate* stdcall<IOleControl*, MSG*, int>)(lpVtbl[4]))((IOleControl*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnAmbientPropertyChange([NativeTypeName("DISPID")] int dispID)
        {
            return ((delegate* stdcall<IOleControl*, int, int>)(lpVtbl[5]))((IOleControl*)Unsafe.AsPointer(ref this), dispID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreezeEvents([NativeTypeName("BOOL")] int bFreeze)
        {
            return ((delegate* stdcall<IOleControl*, int, int>)(lpVtbl[6]))((IOleControl*)Unsafe.AsPointer(ref this), bFreeze);
        }
    }
}
