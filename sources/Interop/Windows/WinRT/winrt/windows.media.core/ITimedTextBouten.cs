// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten"]/*' />
[Guid("D9062783-5597-5092-820C-8F738E0F774A")]
[NativeTypeName("struct ITimedTextBouten : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextBouten : ITimedTextBouten.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextBouten));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, uint>)(lpVtbl[1]))((ITimedTextBouten*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, uint>)(lpVtbl[2]))((ITimedTextBouten*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType *")] TimedTextBoutenType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, TimedTextBoutenType*, int>)(lpVtbl[6]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType")] TimedTextBoutenType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, TimedTextBoutenType, int>)(lpVtbl[7]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.get_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, Color*, int>)(lpVtbl[8]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.put_Color"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, Color, int>)(lpVtbl[9]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition *")] TimedTextBoutenPosition* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, TimedTextBoutenPosition*, int>)(lpVtbl[10]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextBouten.xml' path='doc/member[@name="ITimedTextBouten.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition")] TimedTextBoutenPosition value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextBouten*, TimedTextBoutenPosition, int>)(lpVtbl[11]))((ITimedTextBouten*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType *")] TimedTextBoutenType* value);

        [VtblIndex(7)]
        HRESULT put_Type([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenType")] TimedTextBoutenType value);

        [VtblIndex(8)]
        HRESULT get_Color([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(9)]
        HRESULT put_Color([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(10)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition *")] TimedTextBoutenPosition* value);

        [VtblIndex(11)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Media::Core::TimedTextBoutenPosition")] TimedTextBoutenPosition value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextBoutenType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextBoutenType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextBoutenType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextBoutenType, int> put_Type;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_Color;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color, int> put_Color;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextBoutenPosition *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextBoutenPosition*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::TimedTextBoutenPosition) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimedTextBoutenPosition, int> put_Position;
    }
}
