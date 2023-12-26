// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics"]/*' />
[Guid("B3B579D5-1BA9-48EB-9DAD-C095E8C23BA3")]
[NativeTypeName("struct IFontWeightsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFontWeightsStatics : IFontWeightsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFontWeightsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, uint>)(lpVtbl[1]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, uint>)(lpVtbl[2]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, HSTRING*, int>)(lpVtbl[4]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Black"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[6]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Bold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[7]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_ExtraBlack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ExtraBlack([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[8]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_ExtraBold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ExtraBold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[9]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_ExtraLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ExtraLight([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[10]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Light"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Light([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[11]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Medium"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Medium([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[12]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Normal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Normal([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[13]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_SemiBold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SemiBold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[14]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_SemiLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SemiLight([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[15]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFontWeightsStatics.xml' path='doc/member[@name="IFontWeightsStatics.get_Thin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Thin([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFontWeightsStatics*, FontWeight*, int>)(lpVtbl[16]))((IFontWeightsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Black([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(7)]
        HRESULT get_Bold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(8)]
        HRESULT get_ExtraBlack([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(9)]
        HRESULT get_ExtraBold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(10)]
        HRESULT get_ExtraLight([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(11)]
        HRESULT get_Light([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(12)]
        HRESULT get_Medium([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(13)]
        HRESULT get_Normal([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(14)]
        HRESULT get_SemiBold([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(15)]
        HRESULT get_SemiLight([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);

        [VtblIndex(16)]
        HRESULT get_Thin([NativeTypeName("ABI::Windows::UI::Text::FontWeight *")] FontWeight* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Black;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Bold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_ExtraBlack;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_ExtraBold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_ExtraLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Light;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Medium;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Normal;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_SemiBold;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_SemiLight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::FontWeight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FontWeight*, int> get_Thin;
    }
}
