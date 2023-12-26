// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics"]/*' />
[Guid("0F2F3758-8EC7-4381-922B-8F6C07D288F3")]
[NativeTypeName("struct IPathIOStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPathIOStatics : IPathIOStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPathIOStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPathIOStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, uint>)(lpVtbl[1]))((IPathIOStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, uint>)(lpVtbl[2]))((IPathIOStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPathIOStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING*, int>)(lpVtbl[4]))((IPathIOStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPathIOStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.ReadTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadTextAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IAsyncOperation<HSTRING>**, int>)(lpVtbl[6]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.ReadTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadTextWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, UnicodeEncoding, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, encoding, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteTextAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteTextWithEncodingAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, HSTRING, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[9]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, encoding, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.AppendTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendTextAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, HSTRING, IAsyncAction**, int>)(lpVtbl[10]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.AppendTextWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AppendTextWithEncodingAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, HSTRING, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[11]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, encoding, textOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.ReadLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReadLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, linesOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.ReadLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, UnicodeEncoding, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, encoding, linesOperation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[14]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[15]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, encoding, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.AppendLinesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AppendLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[16]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.AppendLinesWithEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AppendLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[17]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, encoding, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.ReadBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadBufferAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteBufferAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteBufferAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, IBuffer*, IAsyncAction**, int>)(lpVtbl[19]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, buffer, operation);
    }

    /// <include file='IPathIOStatics.xml' path='doc/member[@name="IPathIOStatics.WriteBytesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteBytesAsync(HSTRING absolutePath, [NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPathIOStatics*, HSTRING, uint, byte*, IAsyncAction**, int>)(lpVtbl[20]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, bufferLength, buffer, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadTextAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation);

        [VtblIndex(7)]
        HRESULT ReadTextWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** textOperation);

        [VtblIndex(8)]
        HRESULT WriteTextAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(9)]
        HRESULT WriteTextWithEncodingAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(10)]
        HRESULT AppendTextAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(11)]
        HRESULT AppendTextWithEncodingAsync(HSTRING absolutePath, HSTRING contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation);

        [VtblIndex(12)]
        HRESULT ReadLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation);

        [VtblIndex(13)]
        HRESULT ReadLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation);

        [VtblIndex(14)]
        HRESULT WriteLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(15)]
        HRESULT WriteLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(16)]
        HRESULT AppendLinesAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(17)]
        HRESULT AppendLinesWithEncodingAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(18)]
        HRESULT ReadBufferAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(19)]
        HRESULT WriteBufferAsync(HSTRING absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(20)]
        HRESULT WriteBytesAsync(HSTRING absolutePath, [NativeTypeName("UINT32")] uint bufferLength, byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<HSTRING>**, int> ReadTextAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, UnicodeEncoding, IAsyncOperation<HSTRING>**, int> ReadTextWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncAction**, int> WriteTextAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, UnicodeEncoding, IAsyncAction**, int> WriteTextWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncAction**, int> AppendTextAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, UnicodeEncoding, IAsyncAction**, int> AppendTextWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> ReadLinesAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, UnicodeEncoding, IAsyncOperation<IntPtr>**, int> ReadLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int> WriteLinesAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int> WriteLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, IAsyncAction**, int> AppendLinesAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIterable<HSTRING>*, UnicodeEncoding, IAsyncAction**, int> AppendLinesWithEncodingAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> ReadBufferAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer*, IAsyncAction**, int> WriteBufferAsync;

        [NativeTypeName("HRESULT (HSTRING, UINT32, BYTE *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, byte*, IAsyncAction**, int> WriteBytesAsync;
    }
}
