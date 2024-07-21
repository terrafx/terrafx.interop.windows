// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics"]/*' />
[Guid("CA46C5C5-0ECC-4809-BEA3-CF79BC991E37")]
[NativeTypeName("struct IGattProtocolErrorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattProtocolErrorStatics : IGattProtocolErrorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattProtocolErrorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, uint>)(lpVtbl[1]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, uint>)(lpVtbl[2]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InvalidHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InvalidHandle(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[6]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_ReadNotPermitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReadNotPermitted(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[7]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_WriteNotPermitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WriteNotPermitted(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[8]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InvalidPdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InvalidPdu(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[9]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InsufficientAuthentication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InsufficientAuthentication(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[10]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_RequestNotSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RequestNotSupported(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[11]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InvalidOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InvalidOffset(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[12]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InsufficientAuthorization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_InsufficientAuthorization(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[13]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_PrepareQueueFull"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PrepareQueueFull(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[14]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_AttributeNotFound"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AttributeNotFound(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[15]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_AttributeNotLong"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AttributeNotLong(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[16]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InsufficientEncryptionKeySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_InsufficientEncryptionKeySize(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[17]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InvalidAttributeValueLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_InvalidAttributeValueLength(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[18]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_UnlikelyError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_UnlikelyError(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[19]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InsufficientEncryption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_InsufficientEncryption(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[20]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_UnsupportedGroupType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_UnsupportedGroupType(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[21]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattProtocolErrorStatics.xml' path='doc/member[@name="IGattProtocolErrorStatics.get_InsufficientResources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_InsufficientResources(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattProtocolErrorStatics*, byte*, int>)(lpVtbl[22]))((IGattProtocolErrorStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InvalidHandle(byte* value);

        [VtblIndex(7)]
        HRESULT get_ReadNotPermitted(byte* value);

        [VtblIndex(8)]
        HRESULT get_WriteNotPermitted(byte* value);

        [VtblIndex(9)]
        HRESULT get_InvalidPdu(byte* value);

        [VtblIndex(10)]
        HRESULT get_InsufficientAuthentication(byte* value);

        [VtblIndex(11)]
        HRESULT get_RequestNotSupported(byte* value);

        [VtblIndex(12)]
        HRESULT get_InvalidOffset(byte* value);

        [VtblIndex(13)]
        HRESULT get_InsufficientAuthorization(byte* value);

        [VtblIndex(14)]
        HRESULT get_PrepareQueueFull(byte* value);

        [VtblIndex(15)]
        HRESULT get_AttributeNotFound(byte* value);

        [VtblIndex(16)]
        HRESULT get_AttributeNotLong(byte* value);

        [VtblIndex(17)]
        HRESULT get_InsufficientEncryptionKeySize(byte* value);

        [VtblIndex(18)]
        HRESULT get_InvalidAttributeValueLength(byte* value);

        [VtblIndex(19)]
        HRESULT get_UnlikelyError(byte* value);

        [VtblIndex(20)]
        HRESULT get_InsufficientEncryption(byte* value);

        [VtblIndex(21)]
        HRESULT get_UnsupportedGroupType(byte* value);

        [VtblIndex(22)]
        HRESULT get_InsufficientResources(byte* value);
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

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InvalidHandle;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ReadNotPermitted;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_WriteNotPermitted;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InvalidPdu;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InsufficientAuthentication;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RequestNotSupported;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InvalidOffset;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InsufficientAuthorization;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PrepareQueueFull;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AttributeNotFound;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AttributeNotLong;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InsufficientEncryptionKeySize;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InvalidAttributeValueLength;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UnlikelyError;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InsufficientEncryption;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UnsupportedGroupType;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_InsufficientResources;
    }
}
