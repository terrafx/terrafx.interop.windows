// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue"]/*' />
[Guid("51C79E51-3B86-494D-B359-BB2EA7ACA9A9")]
[NativeTypeName("struct ITimedTextCue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextCue : ITimedTextCue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextCue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextCue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, uint>)(lpVtbl[1]))((ITimedTextCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, uint>)(lpVtbl[2]))((ITimedTextCue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextCue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextCue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextCue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue.get_CueRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CueRegion([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRegion **")] ITimedTextRegion** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, ITimedTextRegion**, int>)(lpVtbl[6]))((ITimedTextCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue.put_CueRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CueRegion([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRegion *")] ITimedTextRegion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, ITimedTextRegion*, int>)(lpVtbl[7]))((ITimedTextCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue.get_CueStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CueStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle **")] ITimedTextStyle** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, ITimedTextStyle**, int>)(lpVtbl[8]))((ITimedTextCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue.put_CueStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CueStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle *")] ITimedTextStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, ITimedTextStyle*, int>)(lpVtbl[9]))((ITimedTextCue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextCue.xml' path='doc/member[@name="ITimedTextCue.get_Lines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Lines([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedTextLine_t **")] IVector<Pointer<ITimedTextLine>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextCue*, IVector<Pointer<ITimedTextLine>>**, int>)(lpVtbl[10]))((ITimedTextCue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CueRegion([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRegion **")] ITimedTextRegion** value);

        [VtblIndex(7)]
        HRESULT put_CueRegion([NativeTypeName("ABI::Windows::Media::Core::ITimedTextRegion *")] ITimedTextRegion* value);

        [VtblIndex(8)]
        HRESULT get_CueStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle **")] ITimedTextStyle** value);

        [VtblIndex(9)]
        HRESULT put_CueStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle *")] ITimedTextStyle* value);

        [VtblIndex(10)]
        HRESULT get_Lines([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedTextLine_t **")] IVector<Pointer<ITimedTextLine>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextRegion **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextRegion**, int> get_CueRegion;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextRegion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextRegion*, int> put_CueRegion;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextStyle**, int> get_CueStyle;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextStyle*, int> put_CueStyle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CCore__CTimedTextLine_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ITimedTextLine>>**, int> get_Lines;
    }
}
