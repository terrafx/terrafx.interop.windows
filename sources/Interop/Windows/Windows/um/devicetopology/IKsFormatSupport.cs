// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3CB4A69D-BB6F-4D2B-95B7-452D2C155DB5")]
[NativeTypeName("struct IKsFormatSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsFormatSupport : IKsFormatSupport.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, Guid*, void**, int>)(lpVtbl[0]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[1]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[2]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, BOOL* pbSupported)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT*, uint, BOOL*, int>)(lpVtbl[3]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), pKsFormat, cbFormat, pbSupported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT**, int>)(lpVtbl[4]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), ppKsFormat);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, BOOL* pbSupported);

        [VtblIndex(4)]
        HRESULT GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKsFormatSupport*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IKsFormatSupport*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IKsFormatSupport*, uint> Release;

        [NativeTypeName("HRESULT (PKSDATAFORMAT, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT*, uint, BOOL*, int> IsFormatSupported;

        [NativeTypeName("HRESULT (PKSDATAFORMAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT**, int> GetDevicePreferredFormat;
    }
}
