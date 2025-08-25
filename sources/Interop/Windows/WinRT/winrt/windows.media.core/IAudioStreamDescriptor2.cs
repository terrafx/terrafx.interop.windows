// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioStreamDescriptor2.xml' path='doc/member[@name="IAudioStreamDescriptor2"]/*' />
[Guid("2E68F1F6-A448-497B-8840-85082665ACF9")]
[NativeTypeName("struct IAudioStreamDescriptor2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioStreamDescriptor2 : IAudioStreamDescriptor2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioStreamDescriptor2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, uint>)(lpVtbl[1]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, uint>)(lpVtbl[2]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, HSTRING*, int>)(lpVtbl[4]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, TrustLevel*, int>)(lpVtbl[5]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioStreamDescriptor2.xml' path='doc/member[@name="IAudioStreamDescriptor2.put_LeadingEncoderPadding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_LeadingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, IReference<uint>*, int>)(lpVtbl[6]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioStreamDescriptor2.xml' path='doc/member[@name="IAudioStreamDescriptor2.get_LeadingEncoderPadding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LeadingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, IReference<uint>**, int>)(lpVtbl[7]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioStreamDescriptor2.xml' path='doc/member[@name="IAudioStreamDescriptor2.put_TrailingEncoderPadding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TrailingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, IReference<uint>*, int>)(lpVtbl[8]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioStreamDescriptor2.xml' path='doc/member[@name="IAudioStreamDescriptor2.get_TrailingEncoderPadding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TrailingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioStreamDescriptor2*, IReference<uint>**, int>)(lpVtbl[9]))((IAudioStreamDescriptor2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_LeadingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(7)]
        HRESULT get_LeadingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(8)]
        HRESULT put_TrailingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(9)]
        HRESULT get_TrailingEncoderPadding([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_LeadingEncoderPadding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_LeadingEncoderPadding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_TrailingEncoderPadding;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_TrailingEncoderPadding;
    }
}
