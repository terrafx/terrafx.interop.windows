// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("766C8FFB-5FDB-4FEA-A28D-B912996F51BD")]
    [NativeTypeName("struct IMFPMediaPlayerCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFPMediaPlayerCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMediaPlayerCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMediaPlayerCallback*, uint>)(lpVtbl[1]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMediaPlayerCallback*, uint>)(lpVtbl[2]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void OnMediaPlayerEvent(MFP_EVENT_HEADER* pEventHeader)
        {
            ((delegate* unmanaged<IMFPMediaPlayerCallback*, MFP_EVENT_HEADER*, void>)(lpVtbl[3]))((IMFPMediaPlayerCallback*)Unsafe.AsPointer(ref this), pEventHeader);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMediaPlayerCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMediaPlayerCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMediaPlayerCallback*, uint> Release;

            [NativeTypeName("void (MFP_EVENT_HEADER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMediaPlayerCallback*, MFP_EVENT_HEADER*, void> OnMediaPlayerEvent;
        }
    }
}
