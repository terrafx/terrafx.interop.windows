// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDisplayPropertiesEventHandler.xml' path='doc/member[@name="IDisplayPropertiesEventHandler"]/*' />
[Guid("DBDD8B01-F1A1-46D1-9EE3-543BCC995980")]
[NativeTypeName("struct IDisplayPropertiesEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
public unsafe partial struct IDisplayPropertiesEventHandler : IDisplayPropertiesEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayPropertiesEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayPropertiesEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesEventHandler*, uint>)(lpVtbl[1]))((IDisplayPropertiesEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesEventHandler*, uint>)(lpVtbl[2]))((IDisplayPropertiesEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDisplayPropertiesEventHandler.xml' path='doc/member[@name="IDisplayPropertiesEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
    public HRESULT Invoke(IInspectable* sender)
    {
        return ((delegate* unmanaged[MemberFunction]<IDisplayPropertiesEventHandler*, IInspectable*, int>)(lpVtbl[3]))((IDisplayPropertiesEventHandler*)Unsafe.AsPointer(ref this), sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        HRESULT Invoke(IInspectable* sender);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        [Obsolete("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> Invoke;
    }
}
