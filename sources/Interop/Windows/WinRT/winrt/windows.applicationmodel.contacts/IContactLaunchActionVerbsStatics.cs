// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics"]/*' />
[Guid("FB1232D6-EE73-46E7-8761-11CD0157728F")]
[NativeTypeName("struct IContactLaunchActionVerbsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactLaunchActionVerbsStatics : IContactLaunchActionVerbsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactLaunchActionVerbsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, uint>)(lpVtbl[1]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, uint>)(lpVtbl[2]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[4]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics.get_Call"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Call(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[6]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics.get_Message"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Message(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[7]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics.get_Map"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Map(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[8]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics.get_Post"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Post(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[9]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactLaunchActionVerbsStatics.xml' path='doc/member[@name="IContactLaunchActionVerbsStatics.get_VideoCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoCall(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLaunchActionVerbsStatics*, HSTRING*, int>)(lpVtbl[10]))((IContactLaunchActionVerbsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Call(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Message(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Map(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Post(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_VideoCall(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Call;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Message;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Map;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Post;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoCall;
    }
}
