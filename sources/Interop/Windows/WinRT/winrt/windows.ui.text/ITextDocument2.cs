// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextDocument2.xml' path='doc/member[@name="ITextDocument2"]/*' />
[Guid("F2311112-8C89-49C9-9118-F057CBB814EE")]
[NativeTypeName("struct ITextDocument2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextDocument2 : ITextDocument2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITextDocument2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, Guid*, void**, int>)(lpVtbl[0]))((ITextDocument2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, uint>)(lpVtbl[1]))((ITextDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, uint>)(lpVtbl[2]))((ITextDocument2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, uint*, Guid**, int>)(lpVtbl[3]))((ITextDocument2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, HSTRING*, int>)(lpVtbl[4]))((ITextDocument2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, TrustLevel*, int>)(lpVtbl[5]))((ITextDocument2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextDocument2.xml' path='doc/member[@name="ITextDocument2.get_AlignmentIncludesTrailingWhitespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlignmentIncludesTrailingWhitespace([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, byte*, int>)(lpVtbl[6]))((ITextDocument2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument2.xml' path='doc/member[@name="ITextDocument2.put_AlignmentIncludesTrailingWhitespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AlignmentIncludesTrailingWhitespace([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, byte, int>)(lpVtbl[7]))((ITextDocument2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument2.xml' path='doc/member[@name="ITextDocument2.get_IgnoreTrailingCharacterSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IgnoreTrailingCharacterSpacing([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, byte*, int>)(lpVtbl[8]))((ITextDocument2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextDocument2.xml' path='doc/member[@name="ITextDocument2.put_IgnoreTrailingCharacterSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IgnoreTrailingCharacterSpacing([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextDocument2*, byte, int>)(lpVtbl[9]))((ITextDocument2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlignmentIncludesTrailingWhitespace([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AlignmentIncludesTrailingWhitespace([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_IgnoreTrailingCharacterSpacing([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IgnoreTrailingCharacterSpacing([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AlignmentIncludesTrailingWhitespace;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AlignmentIncludesTrailingWhitespace;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IgnoreTrailingCharacterSpacing;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IgnoreTrailingCharacterSpacing;
    }
}
