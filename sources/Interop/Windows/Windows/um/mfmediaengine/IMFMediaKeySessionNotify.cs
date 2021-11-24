// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("6A0083F9-8947-4C1D-9CE0-CDEE22B23135")]
[NativeTypeName("struct IMFMediaKeySessionNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IMFMediaKeySessionNotify : IMFMediaKeySessionNotify.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify*, uint>)(lpVtbl[1]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify*, uint>)(lpVtbl[2]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void KeyMessage([NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint cb)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify*, ushort*, byte*, uint, void>)(lpVtbl[3]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), destinationURL, message, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void KeyAdded()
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify*, void>)(lpVtbl[4]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void KeyError(ushort code, [NativeTypeName("DWORD")] uint systemCode)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify*, ushort, uint, void>)(lpVtbl[5]))((IMFMediaKeySessionNotify*)Unsafe.AsPointer(ref this), code, systemCode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void KeyMessage([NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint cb);

        [VtblIndex(4)]
        void KeyAdded();

        [VtblIndex(5)]
        void KeyError(ushort code, [NativeTypeName("DWORD")] uint systemCode);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, uint> Release;

        [NativeTypeName("void (BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, ushort*, byte*, uint, void> KeyMessage;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, void> KeyAdded;

        [NativeTypeName("void (USHORT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaKeySessionNotify*, ushort, uint, void> KeyError;
    }
}
