// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("AA9DD80F-C50A-4220-91C1-332287F82A34")]
[NativeTypeName("struct IPlayToControlWithCapabilities : IPlayToControl")]
[NativeInheritance("IPlayToControl")]
public unsafe partial struct IPlayToControlWithCapabilities : IPlayToControlWithCapabilities.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint>)(lpVtbl[1]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint>)(lpVtbl[2]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IMFSharingEngineClassFactory* pFactory)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, IMFSharingEngineClassFactory*, int>)(lpVtbl[3]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pFactory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, int>)(lpVtbl[4]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, PLAYTO_SOURCE_CREATEFLAGS*, int>)(lpVtbl[5]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pCapabilities);
    }

    public interface Interface : IPlayToControl.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, uint> Release;

        [NativeTypeName("HRESULT (IMFSharingEngineClassFactory *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, IMFSharingEngineClassFactory*, int> Connect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, int> Disconnect;

        [NativeTypeName("HRESULT (PLAYTO_SOURCE_CREATEFLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPlayToControlWithCapabilities*, PLAYTO_SOURCE_CREATEFLAGS*, int> GetCapabilities;
    }
}
