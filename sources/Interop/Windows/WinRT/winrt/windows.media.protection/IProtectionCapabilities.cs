// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProtectionCapabilities.xml' path='doc/member[@name="IProtectionCapabilities"]/*' />
[Guid("C7AC5D7E-7480-4D29-A464-7BCD913DD8E4")]
[NativeTypeName("struct IProtectionCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionCapabilities : IProtectionCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, uint>)(lpVtbl[1]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, uint>)(lpVtbl[2]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionCapabilities.xml' path='doc/member[@name="IProtectionCapabilities.IsTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsTypeSupported(HSTRING type, HSTRING keySystem, [NativeTypeName("ABI::Windows::Media::Protection::ProtectionCapabilityResult *")] ProtectionCapabilityResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProtectionCapabilities*, HSTRING, HSTRING, ProtectionCapabilityResult*, int>)(lpVtbl[6]))((IProtectionCapabilities*)Unsafe.AsPointer(ref this), type, keySystem, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsTypeSupported(HSTRING type, HSTRING keySystem, [NativeTypeName("ABI::Windows::Media::Protection::ProtectionCapabilityResult *")] ProtectionCapabilityResult* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Protection::ProtectionCapabilityResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ProtectionCapabilityResult*, int> IsTypeSupported;
    }
}
