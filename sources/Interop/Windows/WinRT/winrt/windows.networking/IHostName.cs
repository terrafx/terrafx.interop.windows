// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHostName.xml' path='doc/member[@name="IHostName"]/*' />
[Guid("BF8ECAAD-ED96-49A7-9084-D416CAE88DCB")]
[NativeTypeName("struct IHostName : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHostName : IHostName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHostName);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, Guid*, void**, int>)(lpVtbl[0]))((IHostName*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, uint>)(lpVtbl[1]))((IHostName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, uint>)(lpVtbl[2]))((IHostName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, uint*, Guid**, int>)(lpVtbl[3]))((IHostName*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, HSTRING*, int>)(lpVtbl[4]))((IHostName*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, TrustLevel*, int>)(lpVtbl[5]))((IHostName*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.get_IPInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IPInformation([NativeTypeName("ABI::Windows::Networking::Connectivity::IIPInformation **")] IIPInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, IIPInformation**, int>)(lpVtbl[6]))((IHostName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.get_RawName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RawName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, HSTRING*, int>)(lpVtbl[7]))((IHostName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, HSTRING*, int>)(lpVtbl[8]))((IHostName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.get_CanonicalName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CanonicalName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, HSTRING*, int>)(lpVtbl[9]))((IHostName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Networking::HostNameType *")] HostNameType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, HostNameType*, int>)(lpVtbl[10]))((IHostName*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHostName.xml' path='doc/member[@name="IHostName.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsEqual([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("boolean *")] byte* isEqual)
    {
        return ((delegate* unmanaged[MemberFunction]<IHostName*, IHostName*, byte*, int>)(lpVtbl[11]))((IHostName*)Unsafe.AsPointer(ref this), hostName, isEqual);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IPInformation([NativeTypeName("ABI::Windows::Networking::Connectivity::IIPInformation **")] IIPInformation** value);

        [VtblIndex(7)]
        HRESULT get_RawName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_CanonicalName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Networking::HostNameType *")] HostNameType* value);

        [VtblIndex(11)]
        HRESULT IsEqual([NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName* hostName, [NativeTypeName("boolean *")] byte* isEqual);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::IIPInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIPInformation**, int> get_IPInformation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RawName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CanonicalName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::HostNameType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HostNameType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHostName*, byte*, int> IsEqual;
    }
}
