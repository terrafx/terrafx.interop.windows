// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWordSegment.xml' path='doc/member[@name="IWordSegment"]/*' />
[Guid("D2D4BA6D-987C-4CC0-B6BD-D49A11B38F9A")]
[NativeTypeName("struct IWordSegment : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWordSegment : IWordSegment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWordSegment));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, Guid*, void**, int>)(lpVtbl[0]))((IWordSegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, uint>)(lpVtbl[1]))((IWordSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, uint>)(lpVtbl[2]))((IWordSegment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, uint*, Guid**, int>)(lpVtbl[3]))((IWordSegment*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, HSTRING*, int>)(lpVtbl[4]))((IWordSegment*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, TrustLevel*, int>)(lpVtbl[5]))((IWordSegment*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWordSegment.xml' path='doc/member[@name="IWordSegment.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, HSTRING*, int>)(lpVtbl[6]))((IWordSegment*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWordSegment.xml' path='doc/member[@name="IWordSegment.get_SourceTextSegment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SourceTextSegment([NativeTypeName("ABI::Windows::Data::Text::TextSegment *")] TextSegment* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, TextSegment*, int>)(lpVtbl[7]))((IWordSegment*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWordSegment.xml' path='doc/member[@name="IWordSegment.get_AlternateForms"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AlternateForms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CAlternateWordForm_t **")] IVectorView<Pointer<IAlternateWordForm>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWordSegment*, IVectorView<Pointer<IAlternateWordForm>>**, int>)(lpVtbl[8]))((IWordSegment*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SourceTextSegment([NativeTypeName("ABI::Windows::Data::Text::TextSegment *")] TextSegment* value);

        [VtblIndex(8)]
        HRESULT get_AlternateForms([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CAlternateWordForm_t **")] IVectorView<Pointer<IAlternateWordForm>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Text::TextSegment *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSegment*, int> get_SourceTextSegment;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CAlternateWordForm_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAlternateWordForm>>**, int> get_AlternateForms;
    }
}
