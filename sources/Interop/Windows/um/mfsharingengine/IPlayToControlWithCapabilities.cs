// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA9DD80F-C50A-4220-91C1-332287F82A34")]
    [NativeTypeName("struct IPlayToControlWithCapabilities : IPlayToControl")]
    public unsafe partial struct IPlayToControlWithCapabilities
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint>)(lpVtbl[1]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint>)(lpVtbl[2]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IMFSharingEngineClassFactory* pFactory)
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, IMFSharingEngineClassFactory*, int>)(lpVtbl[3]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, int>)(lpVtbl[4]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities)
        {
            return ((delegate* unmanaged<IPlayToControlWithCapabilities*, PLAYTO_SOURCE_CREATEFLAGS*, int>)(lpVtbl[5]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pCapabilities);
        }
    }
}
