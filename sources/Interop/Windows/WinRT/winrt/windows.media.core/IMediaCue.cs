// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue"]/*' />
[Guid("C7D15E5D-59DC-431F-A0EE-27744323B36D")]
[NativeTypeName("struct IMediaCue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCue : IMediaCue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, uint>)(lpVtbl[1]))((IMediaCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, uint>)(lpVtbl[2]))((IMediaCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, HSTRING*, int>)(lpVtbl[4]))((IMediaCue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, TimeSpan, int>)(lpVtbl[6]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, TimeSpan*, int>)(lpVtbl[7]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, TimeSpan, int>)(lpVtbl[8]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, TimeSpan*, int>)(lpVtbl[9]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.put_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, HSTRING, int>)(lpVtbl[10]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCue.xml' path='doc/member[@name="IMediaCue.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCue*, HSTRING*, int>)(lpVtbl[11]))((IMediaCue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(7)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(9)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Id(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;
    }
}
