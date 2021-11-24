// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("A7901327-05DD-4469-A7B7-0E01979E361D")]
[NativeTypeName("struct IMFMediaSourceExtensionNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSourceExtensionNotify : IMFMediaSourceExtensionNotify.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, uint>)(lpVtbl[1]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, uint>)(lpVtbl[2]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void OnSourceOpen()
    {
        ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[3]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void OnSourceEnded()
    {
        ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[4]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void OnSourceClose()
    {
        ((delegate* unmanaged<IMFMediaSourceExtensionNotify*, void>)(lpVtbl[5]))((IMFMediaSourceExtensionNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void OnSourceOpen();

        [VtblIndex(4)]
        void OnSourceEnded();

        [VtblIndex(5)]
        void OnSourceClose();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, uint> Release;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, void> OnSourceOpen;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, void> OnSourceEnded;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSourceExtensionNotify*, void> OnSourceClose;
    }
}
