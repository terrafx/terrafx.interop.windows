// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics"]/*' />
[Guid("FAF1BA0A-30BA-409C-BEF7-CFFB6D03B8FB")]
[NativeTypeName("struct IGattPresentationFormatTypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattPresentationFormatTypesStatics : IGattPresentationFormatTypesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattPresentationFormatTypesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, uint>)(lpVtbl[1]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, uint>)(lpVtbl[2]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Boolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Boolean(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[6]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Bit2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bit2(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[7]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Nibble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Nibble(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[8]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UInt8(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[9]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UInt12(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[10]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UInt16(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[11]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt24"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UInt24(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[12]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UInt32(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[13]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt48"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UInt48(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[14]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_UInt64(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[15]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_UInt128"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UInt128(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[16]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SInt8(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[17]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_SInt12(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[18]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SInt16(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[19]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt24"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_SInt24(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[20]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SInt32(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[21]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt48"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SInt48(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[22]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_SInt64(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[23]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SInt128"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_SInt128(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[24]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Float32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Float32(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[25]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Float64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Float64(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[26]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_SFloat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_SFloat(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[27]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Float"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Float(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[28]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_DUInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_DUInt16(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[29]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Utf8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_Utf8(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[30]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Utf16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_Utf16(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[31]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattPresentationFormatTypesStatics.xml' path='doc/member[@name="IGattPresentationFormatTypesStatics.get_Struct"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_Struct(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatTypesStatics*, byte*, int>)(lpVtbl[32]))((IGattPresentationFormatTypesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Boolean(byte* value);

        [VtblIndex(7)]
        HRESULT get_Bit2(byte* value);

        [VtblIndex(8)]
        HRESULT get_Nibble(byte* value);

        [VtblIndex(9)]
        HRESULT get_UInt8(byte* value);

        [VtblIndex(10)]
        HRESULT get_UInt12(byte* value);

        [VtblIndex(11)]
        HRESULT get_UInt16(byte* value);

        [VtblIndex(12)]
        HRESULT get_UInt24(byte* value);

        [VtblIndex(13)]
        HRESULT get_UInt32(byte* value);

        [VtblIndex(14)]
        HRESULT get_UInt48(byte* value);

        [VtblIndex(15)]
        HRESULT get_UInt64(byte* value);

        [VtblIndex(16)]
        HRESULT get_UInt128(byte* value);

        [VtblIndex(17)]
        HRESULT get_SInt8(byte* value);

        [VtblIndex(18)]
        HRESULT get_SInt12(byte* value);

        [VtblIndex(19)]
        HRESULT get_SInt16(byte* value);

        [VtblIndex(20)]
        HRESULT get_SInt24(byte* value);

        [VtblIndex(21)]
        HRESULT get_SInt32(byte* value);

        [VtblIndex(22)]
        HRESULT get_SInt48(byte* value);

        [VtblIndex(23)]
        HRESULT get_SInt64(byte* value);

        [VtblIndex(24)]
        HRESULT get_SInt128(byte* value);

        [VtblIndex(25)]
        HRESULT get_Float32(byte* value);

        [VtblIndex(26)]
        HRESULT get_Float64(byte* value);

        [VtblIndex(27)]
        HRESULT get_SFloat(byte* value);

        [VtblIndex(28)]
        HRESULT get_Float(byte* value);

        [VtblIndex(29)]
        HRESULT get_DUInt16(byte* value);

        [VtblIndex(30)]
        HRESULT get_Utf8(byte* value);

        [VtblIndex(31)]
        HRESULT get_Utf16(byte* value);

        [VtblIndex(32)]
        HRESULT get_Struct(byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Boolean;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Bit2;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Nibble;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt12;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt24;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt48;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_UInt128;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt12;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt24;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt48;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SInt128;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Float32;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Float64;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SFloat;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Float;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DUInt16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Utf8;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Utf16;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Struct;
    }
}
