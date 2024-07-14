// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics"]/*' />
[Guid("887411EB-7F54-4732-A5F0-5E43E3B8C2F5")]
[NativeTypeName("struct IFileIOStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileIOStatics : IFileIOStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileIOStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileIOStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, uint>)(lpVtbl[1]))((IFileIOStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, uint>)(lpVtbl[2]))((IFileIOStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileIOStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, HSTRING*, int>)(lpVtbl[4]))((IFileIOStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileIOStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.ReadTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.ReadTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, UnicodeEncoding, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, encoding, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, HSTRING, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[9]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, encoding, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.AppendTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, HSTRING, IAsyncAction**, int>)(lpVtbl[10]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.AppendTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AppendTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, HSTRING, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[11]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, encoding, textOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.ReadLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReadLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<Pointer<IVector<HSTRING>>>** linesOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IAsyncOperation<Pointer<IVector<HSTRING>>>**, int>)(lpVtbl[12]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, linesOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.ReadLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<Pointer<IVector<HSTRING>>>** linesOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, UnicodeEncoding, IAsyncOperation<Pointer<IVector<HSTRING>>>**, int>)(lpVtbl[13]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, encoding, linesOperation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[14]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[15]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, encoding, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.AppendLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AppendLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[16]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.AppendLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AppendLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[17]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, encoding, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.ReadBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IAsyncOperation<Pointer<IBuffer>>**, int>)(lpVtbl[18]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, IBuffer*, IAsyncAction**, int>)(lpVtbl[19]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, buffer, operation);
    }

    /// <include file='IFileIOStatics.xml' path='doc/member[@name="IFileIOStatics.WriteBytesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteBytesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileIOStatics*, IStorageFile*, uint, byte*, IAsyncAction**, int>)(lpVtbl[20]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, bufferLength, buffer, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation);

        [VtblIndex(7)]
        HRESULT ReadTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation);

        [VtblIndex(8)]
        HRESULT WriteTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(9)]
        HRESULT WriteTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(10)]
        HRESULT AppendTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(11)]
        HRESULT AppendTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(12)]
        HRESULT ReadLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<Pointer<IVector<HSTRING>>>** linesOperation);

        [VtblIndex(13)]
        HRESULT ReadLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<Pointer<IVector<HSTRING>>>** linesOperation);

        [VtblIndex(14)]
        HRESULT WriteLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(15)]
        HRESULT WriteLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(16)]
        HRESULT AppendLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(17)]
        HRESULT AppendLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(18)]
        HRESULT ReadBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<Pointer<IBuffer>>** operation);

        [VtblIndex(19)]
        HRESULT WriteBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(20)]
        HRESULT WriteBytesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<HSTRING>**, int> ReadTextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, UnicodeEncoding, IAsyncOperation<HSTRING>**, int> ReadTextWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, IAsyncAction**, int> WriteTextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, UnicodeEncoding, IAsyncAction**, int> WriteTextWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, IAsyncAction**, int> AppendTextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, UnicodeEncoding, IAsyncAction**, int> AppendTextWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IVector<HSTRING>>>**, int> ReadLinesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, UnicodeEncoding, IAsyncOperation<Pointer<IVector<HSTRING>>>**, int> ReadLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IIterable<HSTRING>*, IAsyncAction**, int> WriteLinesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int> WriteLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IIterable<HSTRING>*, IAsyncAction**, int> AppendLinesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int> AppendLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IBuffer>>**, int> ReadBufferAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IBuffer*, IAsyncAction**, int> WriteBufferAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, UINT32, BYTE *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, uint, byte*, IAsyncAction**, int> WriteBytesAsync;
    }
}
