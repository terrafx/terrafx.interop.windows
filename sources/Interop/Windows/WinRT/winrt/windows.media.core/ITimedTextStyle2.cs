// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2"]/*' />
[Guid("655F492D-6111-4787-89CC-686FECE57E14")]
[NativeTypeName("struct ITimedTextStyle2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextStyle2 : ITimedTextStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimedTextStyle2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, uint>)(lpVtbl[1]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, uint>)(lpVtbl[2]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.get_FontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FontStyle([NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle *")] TimedTextFontStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, TimedTextFontStyle*, int>)(lpVtbl[6]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.put_FontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FontStyle([NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle")] TimedTextFontStyle value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, TimedTextFontStyle, int>)(lpVtbl[7]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.get_IsUnderlineEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsUnderlineEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte*, int>)(lpVtbl[8]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.put_IsUnderlineEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsUnderlineEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte, int>)(lpVtbl[9]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.get_IsLineThroughEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsLineThroughEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte*, int>)(lpVtbl[10]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.put_IsLineThroughEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsLineThroughEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte, int>)(lpVtbl[11]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.get_IsOverlineEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsOverlineEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte*, int>)(lpVtbl[12]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextStyle2.xml' path='doc/member[@name="ITimedTextStyle2.put_IsOverlineEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsOverlineEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextStyle2*, byte, int>)(lpVtbl[13]))((ITimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FontStyle([NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle *")] TimedTextFontStyle* value);

        [VtblIndex(7)]
        HRESULT put_FontStyle([NativeTypeName("ABI::Windows::Media::Core::TimedTextFontStyle")] TimedTextFontStyle value);

        [VtblIndex(8)]
        HRESULT get_IsUnderlineEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsUnderlineEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_IsLineThroughEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsLineThroughEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IsOverlineEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsOverlineEnabled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextFontStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextFontStyle*, int> get_FontStyle;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextFontStyle) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextFontStyle, int> put_FontStyle;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUnderlineEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsUnderlineEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLineThroughEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsLineThroughEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOverlineEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsOverlineEnabled;
    }
}
