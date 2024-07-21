// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat"]/*' />
[Guid("D713502F-3261-4722-A0C2-B937B2390F14")]
[NativeTypeName("struct ITimedTextSubformat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextSubformat : ITimedTextSubformat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextSubformat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, Guid*, void**, int>)(lpVtbl[0]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, uint>)(lpVtbl[1]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, uint>)(lpVtbl[2]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, HSTRING*, int>)(lpVtbl[4]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, TrustLevel*, int>)(lpVtbl[5]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.get_StartIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StartIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, int*, int>)(lpVtbl[6]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.put_StartIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_StartIndex([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, int, int>)(lpVtbl[7]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Length([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, int*, int>)(lpVtbl[8]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.put_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Length([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, int, int>)(lpVtbl[9]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.get_SubformatStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SubformatStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle **")] ITimedTextStyle** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, ITimedTextStyle**, int>)(lpVtbl[10]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimedTextSubformat.xml' path='doc/member[@name="ITimedTextSubformat.put_SubformatStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SubformatStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle *")] ITimedTextStyle* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedTextSubformat*, ITimedTextStyle*, int>)(lpVtbl[11]))((ITimedTextSubformat*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StartIndex([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_StartIndex([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_Length([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT put_Length([NativeTypeName("INT32")] int value);

        [VtblIndex(10)]
        HRESULT get_SubformatStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle **")] ITimedTextStyle** value);

        [VtblIndex(11)]
        HRESULT put_SubformatStyle([NativeTypeName("ABI::Windows::Media::Core::ITimedTextStyle *")] ITimedTextStyle* value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StartIndex;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_StartIndex;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Length;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_Length;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextStyle**, int> get_SubformatStyle;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::ITimedTextStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITimedTextStyle*, int> put_SubformatStyle;
    }
}
