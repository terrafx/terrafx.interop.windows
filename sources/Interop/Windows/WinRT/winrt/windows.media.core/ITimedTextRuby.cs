// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby"]/*' />
[Guid("10335C29-5B3C-5693-9959-D05A0BD24628")]
[NativeTypeName("struct ITimedTextRuby : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextRuby : ITimedTextRuby.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedTextRuby);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, uint>)(lpVtbl[1]))((ITimedTextRuby*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, uint>)(lpVtbl[2]))((ITimedTextRuby*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, HSTRING*, int>)(lpVtbl[6]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.put_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Text(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, HSTRING, int>)(lpVtbl[7]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition *")] TimedTextRubyPosition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyPosition*, int>)(lpVtbl[8]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition")] TimedTextRubyPosition value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyPosition, int>)(lpVtbl[9]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.get_Align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Align([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign *")] TimedTextRubyAlign* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyAlign*, int>)(lpVtbl[10]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.put_Align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Align([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign")] TimedTextRubyAlign value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyAlign, int>)(lpVtbl[11]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.get_Reserve"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Reserve([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve *")] TimedTextRubyReserve* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyReserve*, int>)(lpVtbl[12]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextRuby.xml' path='doc/member[@name="ITimedTextRuby.put_Reserve"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Reserve([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve")] TimedTextRubyReserve value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextRuby*, TimedTextRubyReserve, int>)(lpVtbl[13]))((ITimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Text(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition *")] TimedTextRubyPosition* value);

        [VtblIndex(9)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyPosition")] TimedTextRubyPosition value);

        [VtblIndex(10)]
        HRESULT get_Align([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign *")] TimedTextRubyAlign* value);

        [VtblIndex(11)]
        HRESULT put_Align([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyAlign")] TimedTextRubyAlign value);

        [VtblIndex(12)]
        HRESULT get_Reserve([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve *")] TimedTextRubyReserve* value);

        [VtblIndex(13)]
        HRESULT put_Reserve([NativeTypeName("ABI::Windows::Media::Core::TimedTextRubyReserve")] TimedTextRubyReserve value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Text;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyPosition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyPosition*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyPosition) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyPosition, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyAlign *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyAlign*, int> get_Align;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyAlign) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyAlign, int> put_Align;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyReserve *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyReserve*, int> get_Reserve;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextRubyReserve) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextRubyReserve, int> put_Reserve;
    }
}
