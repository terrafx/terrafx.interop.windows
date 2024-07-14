// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext"]/*' />
[Guid("6FA529F4-EFFD-4542-9AB2-705BBF94943A")]
[NativeTypeName("struct ICellularApnContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICellularApnContext : ICellularApnContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICellularApnContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, Guid*, void**, int>)(lpVtbl[0]))((ICellularApnContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, uint>)(lpVtbl[1]))((ICellularApnContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, uint>)(lpVtbl[2]))((ICellularApnContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, uint*, Guid**, int>)(lpVtbl[3]))((ICellularApnContext*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING*, int>)(lpVtbl[4]))((ICellularApnContext*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, TrustLevel*, int>)(lpVtbl[5]))((ICellularApnContext*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_ProviderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING*, int>)(lpVtbl[6]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_ProviderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProviderId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING, int>)(lpVtbl[7]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_AccessPointName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AccessPointName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING*, int>)(lpVtbl[8]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_AccessPointName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AccessPointName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING, int>)(lpVtbl[9]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING*, int>)(lpVtbl[10]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_UserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_UserName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING, int>)(lpVtbl[11]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_Password"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Password(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING*, int>)(lpVtbl[12]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_Password"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Password(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, HSTRING, int>)(lpVtbl[13]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_IsCompressionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsCompressionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, byte*, int>)(lpVtbl[14]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_IsCompressionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IsCompressionEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, byte, int>)(lpVtbl[15]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.get_AuthenticationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *")] CellularApnAuthenticationType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, CellularApnAuthenticationType*, int>)(lpVtbl[16]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICellularApnContext.xml' path='doc/member[@name="ICellularApnContext.put_AuthenticationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_AuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType")] CellularApnAuthenticationType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICellularApnContext*, CellularApnAuthenticationType, int>)(lpVtbl[17]))((ICellularApnContext*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ProviderId(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AccessPointName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AccessPointName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_UserName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Password(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Password(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_IsCompressionEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IsCompressionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_AuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *")] CellularApnAuthenticationType* value);

        [VtblIndex(17)]
        HRESULT put_AuthenticationType([NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType")] CellularApnAuthenticationType value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ProviderId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ProviderId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccessPointName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AccessPointName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Password;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Password;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCompressionEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCompressionEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularApnAuthenticationType*, int> get_AuthenticationType;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularApnAuthenticationType, int> put_AuthenticationType;
    }
}
