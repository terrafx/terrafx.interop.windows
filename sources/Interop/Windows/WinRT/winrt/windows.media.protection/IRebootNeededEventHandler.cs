// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRebootNeededEventHandler.xml' path='doc/member[@name="IRebootNeededEventHandler"]/*' />
[Guid("64E12A45-973B-4A3A-B260-91898A49A82C")]
[NativeTypeName("struct IRebootNeededEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRebootNeededEventHandler : IRebootNeededEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRebootNeededEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRebootNeededEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IRebootNeededEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRebootNeededEventHandler*, uint>)(lpVtbl[1]))((IRebootNeededEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRebootNeededEventHandler*, uint>)(lpVtbl[2]))((IRebootNeededEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRebootNeededEventHandler.xml' path='doc/member[@name="IRebootNeededEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* sender)
    {
        return ((delegate* unmanaged[MemberFunction]<IRebootNeededEventHandler*, IMediaProtectionManager*, int>)(lpVtbl[3]))((IRebootNeededEventHandler*)Unsafe.AsPointer(ref this), sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Protection::IMediaProtectionManager *")] IMediaProtectionManager* sender);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IMediaProtectionManager *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaProtectionManager*, int> Invoke;
    }
}
