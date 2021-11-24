// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("F4376F00-BEF5-4D45-80F3-1E023BBF1209")]
[NativeTypeName("struct IThumbnailSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IThumbnailSettings : IThumbnailSettings.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailSettings*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailSettings*, uint>)(lpVtbl[1]))((IThumbnailSettings*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailSettings*, uint>)(lpVtbl[2]))((IThumbnailSettings*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetContext(WTS_CONTEXTFLAGS dwContext)
    {
        return ((delegate* unmanaged<IThumbnailSettings*, WTS_CONTEXTFLAGS, int>)(lpVtbl[3]))((IThumbnailSettings*)Unsafe.AsPointer(ref this), dwContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetContext(WTS_CONTEXTFLAGS dwContext);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailSettings*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailSettings*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailSettings*, uint> Release;

        [NativeTypeName("HRESULT (WTS_CONTEXTFLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<IThumbnailSettings*, WTS_CONTEXTFLAGS, int> SetContext;
    }
}
