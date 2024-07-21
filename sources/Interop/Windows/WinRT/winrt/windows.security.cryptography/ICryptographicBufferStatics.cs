// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics"]/*' />
[Guid("320B7E22-3CB0-4CDF-8663-1D28910065EB")]
[NativeTypeName("struct ICryptographicBufferStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicBufferStatics : ICryptographicBufferStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICryptographicBufferStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint>)(lpVtbl[1]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint>)(lpVtbl[2]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, HSTRING*, int>)(lpVtbl[4]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.Compare"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* object1, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* object2, [NativeTypeName("boolean *")] byte* isEqual)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, IBuffer*, IBuffer*, byte*, int>)(lpVtbl[6]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), object1, object2, isEqual);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.GenerateRandom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GenerateRandom([NativeTypeName("UINT32")] uint length, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint, IBuffer**, int>)(lpVtbl[7]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), length, buffer);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.GenerateRandomNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GenerateRandomNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint*, int>)(lpVtbl[8]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.CreateFromByteArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromByteArray([NativeTypeName("UINT32")] uint valueLength, byte* value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, uint, byte*, IBuffer**, int>)(lpVtbl[9]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), valueLength, value, buffer);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.CopyToByteArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyToByteArray([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, IBuffer*, uint*, byte**, int>)(lpVtbl[10]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), buffer, valueLength, value);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.DecodeFromHexString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DecodeFromHexString(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, HSTRING, IBuffer**, int>)(lpVtbl[11]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), value, buffer);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.EncodeToHexString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EncodeToHexString([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, IBuffer*, HSTRING*, int>)(lpVtbl[12]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), buffer, value);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.DecodeFromBase64String"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DecodeFromBase64String(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, HSTRING, IBuffer**, int>)(lpVtbl[13]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), value, buffer);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.EncodeToBase64String"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EncodeToBase64String([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, IBuffer*, HSTRING*, int>)(lpVtbl[14]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), buffer, value);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.ConvertStringToBinary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ConvertStringToBinary(HSTRING value, [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")] BinaryStringEncoding encoding, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, HSTRING, BinaryStringEncoding, IBuffer**, int>)(lpVtbl[15]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), value, encoding, buffer);
    }

    /// <include file='ICryptographicBufferStatics.xml' path='doc/member[@name="ICryptographicBufferStatics.ConvertBinaryToString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ConvertBinaryToString([NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")] BinaryStringEncoding encoding, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICryptographicBufferStatics*, BinaryStringEncoding, IBuffer*, HSTRING*, int>)(lpVtbl[16]))((ICryptographicBufferStatics*)Unsafe.AsPointer(ref this), encoding, buffer, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Compare([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* object1, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* object2, [NativeTypeName("boolean *")] byte* isEqual);

        [VtblIndex(7)]
        HRESULT GenerateRandom([NativeTypeName("UINT32")] uint length, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(8)]
        HRESULT GenerateRandomNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT CreateFromByteArray([NativeTypeName("UINT32")] uint valueLength, byte* value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(10)]
        HRESULT CopyToByteArray([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(11)]
        HRESULT DecodeFromHexString(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(12)]
        HRESULT EncodeToHexString([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value);

        [VtblIndex(13)]
        HRESULT DecodeFromBase64String(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(14)]
        HRESULT EncodeToBase64String([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value);

        [VtblIndex(15)]
        HRESULT ConvertStringToBinary(HSTRING value, [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")] BinaryStringEncoding encoding, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(16)]
        HRESULT ConvertBinaryToString([NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")] BinaryStringEncoding encoding, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer*, byte*, int> Compare;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBuffer**, int> GenerateRandom;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GenerateRandomNumber;

        [NativeTypeName("HRESULT (UINT32, BYTE *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, IBuffer**, int> CreateFromByteArray;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, uint*, byte**, int> CopyToByteArray;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer**, int> DecodeFromHexString;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, HSTRING*, int> EncodeToHexString;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer**, int> DecodeFromBase64String;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, HSTRING*, int> EncodeToBase64String;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Cryptography::BinaryStringEncoding, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, BinaryStringEncoding, IBuffer**, int> ConvertStringToBinary;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Cryptography::BinaryStringEncoding, ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BinaryStringEncoding, IBuffer*, HSTRING*, int> ConvertBinaryToString;
    }
}
