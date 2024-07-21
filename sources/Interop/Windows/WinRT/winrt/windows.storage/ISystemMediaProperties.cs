// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties"]/*' />
[Guid("A42B3316-8415-40DC-8C44-98361D235430")]
[NativeTypeName("struct ISystemMediaProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaProperties : ISystemMediaProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMediaProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, uint>)(lpVtbl[1]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, uint>)(lpVtbl[2]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[4]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Duration(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[6]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_Producer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Producer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[7]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_Publisher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Publisher(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[8]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_SubTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SubTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[9]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_Writer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Writer(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[10]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaProperties.xml' path='doc/member[@name="ISystemMediaProperties.get_Year"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Year(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaProperties*, HSTRING*, int>)(lpVtbl[11]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Duration(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Producer(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Publisher(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_SubTitle(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Writer(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Year(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Duration;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Producer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Publisher;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SubTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Writer;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Year;
    }
}
