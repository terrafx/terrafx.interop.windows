// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension"]/*' />
[Guid("84CF0656-A9E6-454D-8E45-2EA7C4BCD53B")]
[NativeTypeName("struct ICertificateExtension : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICertificateExtension : ICertificateExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICertificateExtension);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, Guid*, void**, int>)(lpVtbl[0]))((ICertificateExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, uint>)(lpVtbl[1]))((ICertificateExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, uint>)(lpVtbl[2]))((ICertificateExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, uint*, Guid**, int>)(lpVtbl[3]))((ICertificateExtension*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, HSTRING*, int>)(lpVtbl[4]))((ICertificateExtension*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, TrustLevel*, int>)(lpVtbl[5]))((ICertificateExtension*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.get_ObjectId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ObjectId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, HSTRING*, int>)(lpVtbl[6]))((ICertificateExtension*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.put_ObjectId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ObjectId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, HSTRING, int>)(lpVtbl[7]))((ICertificateExtension*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.get_IsCritical"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCritical([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, byte*, int>)(lpVtbl[8]))((ICertificateExtension*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.put_IsCritical"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsCritical([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, byte, int>)(lpVtbl[9]))((ICertificateExtension*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.EncodeValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EncodeValue(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, HSTRING, int>)(lpVtbl[10]))((ICertificateExtension*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Value([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, uint*, byte**, int>)(lpVtbl[11]))((ICertificateExtension*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ICertificateExtension.xml' path='doc/member[@name="ICertificateExtension.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Value([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICertificateExtension*, uint, byte*, int>)(lpVtbl[12]))((ICertificateExtension*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ObjectId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ObjectId(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_IsCritical([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsCritical([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT EncodeValue(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_Value([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(12)]
        HRESULT put_Value([NativeTypeName("UINT32")] uint valueLength, byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ObjectId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ObjectId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCritical;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCritical;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> EncodeValue;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> get_Value;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> put_Value;
    }
}
