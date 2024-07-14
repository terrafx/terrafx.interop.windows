// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx"]/*' />
[Guid("1A21EB69-962A-4BC4-8BD3-681797D38B23")]
[NativeTypeName("struct IDiaDataSourceEx : IDiaDataSource")]
[NativeInheritance("IDiaDataSource")]
public unsafe partial struct IDiaDataSourceEx : IDiaDataSourceEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaDataSourceEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, Guid*, void**, int>)(lpVtbl[0]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, uint>)(lpVtbl[1]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, uint>)(lpVtbl[2]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaDataSource.get_lastError" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_lastError([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char**, int>)(lpVtbl[3]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaDataSource.loadDataFromPdb" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT loadDataFromPdb([NativeTypeName("LPCOLESTR")] char* pdbPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, int>)(lpVtbl[4]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pdbPath);
    }

    /// <inheritdoc cref="IDiaDataSource.loadAndValidateDataFromPdb" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT loadAndValidateDataFromPdb([NativeTypeName("LPCOLESTR")] char* pdbPath, Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, Guid*, uint, uint, int>)(lpVtbl[5]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pdbPath, pcsig70, sig, age);
    }

    /// <inheritdoc cref="IDiaDataSource.loadDataForExe" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT loadDataForExe([NativeTypeName("LPCOLESTR")] char* executable, [NativeTypeName("LPCOLESTR")] char* searchPath, IUnknown* pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, char*, IUnknown*, int>)(lpVtbl[6]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), executable, searchPath, pCallback);
    }

    /// <inheritdoc cref="IDiaDataSource.loadDataFromIStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT loadDataFromIStream(IStream* pIStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, IStream*, int>)(lpVtbl[7]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pIStream);
    }

    /// <inheritdoc cref="IDiaDataSource.openSession" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT openSession(IDiaSession** ppSession)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, IDiaSession**, int>)(lpVtbl[8]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), ppSession);
    }

    /// <inheritdoc cref="IDiaDataSource.loadDataFromCodeViewInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT loadDataFromCodeViewInfo([NativeTypeName("LPCOLESTR")] char* executable, [NativeTypeName("LPCOLESTR")] char* searchPath, [NativeTypeName("DWORD")] uint cbCvInfo, byte* pbCvInfo, IUnknown* pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, char*, uint, byte*, IUnknown*, int>)(lpVtbl[9]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), executable, searchPath, cbCvInfo, pbCvInfo, pCallback);
    }

    /// <inheritdoc cref="IDiaDataSource.loadDataFromMiscInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT loadDataFromMiscInfo([NativeTypeName("LPCOLESTR")] char* executable, [NativeTypeName("LPCOLESTR")] char* searchPath, [NativeTypeName("DWORD")] uint timeStampExe, [NativeTypeName("DWORD")] uint timeStampDbg, [NativeTypeName("DWORD")] uint sizeOfExe, [NativeTypeName("DWORD")] uint cbMiscInfo, byte* pbMiscInfo, IUnknown* pCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, char*, uint, uint, uint, uint, byte*, IUnknown*, int>)(lpVtbl[10]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), executable, searchPath, timeStampExe, timeStampDbg, sizeOfExe, cbMiscInfo, pbMiscInfo, pCallback);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.loadDataFromPdbEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT loadDataFromPdbEx([NativeTypeName("LPCOLESTR")] char* pdbPath, BOOL fPdbPrefetching)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, BOOL, int>)(lpVtbl[11]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pdbPath, fPdbPrefetching);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.loadAndValidateDataFromPdbEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT loadAndValidateDataFromPdbEx([NativeTypeName("LPCOLESTR")] char* pdbPath, Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age, BOOL fPdbPrefetching)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, Guid*, uint, uint, BOOL, int>)(lpVtbl[12]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pdbPath, pcsig70, sig, age, fPdbPrefetching);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.loadDataForExeEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT loadDataForExeEx([NativeTypeName("LPCOLESTR")] char* executable, [NativeTypeName("LPCOLESTR")] char* searchPath, IUnknown* pCallback, BOOL fPdbPrefetching)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, char*, IUnknown*, BOOL, int>)(lpVtbl[13]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), executable, searchPath, pCallback, fPdbPrefetching);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.loadDataFromIStreamEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT loadDataFromIStreamEx(IStream* pIStream, BOOL fPdbPrefetching)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, IStream*, BOOL, int>)(lpVtbl[14]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pIStream, fPdbPrefetching);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.getStreamSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT getStreamSize([NativeTypeName("LPCOLESTR")] char* stream, [NativeTypeName("ULONGLONG *")] ulong* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, ulong*, int>)(lpVtbl[15]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), stream, pcb);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.getStreamRawData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT getStreamRawData([NativeTypeName("LPCOLESTR")] char* stream, [NativeTypeName("ULONGLONG")] ulong cbOffset, [NativeTypeName("ULONGLONG")] ulong cbRead, [NativeTypeName("ULONGLONG *")] ulong* pcbRead, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, ulong, ulong, ulong*, byte*, int>)(lpVtbl[16]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), stream, cbOffset, cbRead, pcbRead, pbData);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.setPfnMiniPDBErrorCallback2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setPfnMiniPDBErrorCallback2(void* pvContext, [NativeTypeName("PFNMINIPDBERRORCALLBACK2")] delegate* unmanaged<void*, uint, char*, char*, HRESULT> pfn)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, void*, delegate* unmanaged<void*, uint, char*, char*, HRESULT>, int>)(lpVtbl[17]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pvContext, pfn);
    }

    /// <include file='IDiaDataSourceEx.xml' path='doc/member[@name="IDiaDataSourceEx.ValidatePdb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ValidatePdb([NativeTypeName("LPCOLESTR")] char* pdbPath, [NativeTypeName("const GUID *")] Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age, BOOL* pfStripped)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaDataSourceEx*, char*, Guid*, uint, uint, BOOL*, int>)(lpVtbl[18]))((IDiaDataSourceEx*)Unsafe.AsPointer(ref this), pdbPath, pcsig70, sig, age, pfStripped);
    }

    public interface Interface : IDiaDataSource.Interface
    {
        [VtblIndex(11)]
        HRESULT loadDataFromPdbEx([NativeTypeName("LPCOLESTR")] char* pdbPath, BOOL fPdbPrefetching);

        [VtblIndex(12)]
        HRESULT loadAndValidateDataFromPdbEx([NativeTypeName("LPCOLESTR")] char* pdbPath, Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age, BOOL fPdbPrefetching);

        [VtblIndex(13)]
        HRESULT loadDataForExeEx([NativeTypeName("LPCOLESTR")] char* executable, [NativeTypeName("LPCOLESTR")] char* searchPath, IUnknown* pCallback, BOOL fPdbPrefetching);

        [VtblIndex(14)]
        HRESULT loadDataFromIStreamEx(IStream* pIStream, BOOL fPdbPrefetching);

        [VtblIndex(15)]
        HRESULT getStreamSize([NativeTypeName("LPCOLESTR")] char* stream, [NativeTypeName("ULONGLONG *")] ulong* pcb);

        [VtblIndex(16)]
        HRESULT getStreamRawData([NativeTypeName("LPCOLESTR")] char* stream, [NativeTypeName("ULONGLONG")] ulong cbOffset, [NativeTypeName("ULONGLONG")] ulong cbRead, [NativeTypeName("ULONGLONG *")] ulong* pcbRead, byte* pbData);

        [VtblIndex(18)]
        HRESULT ValidatePdb([NativeTypeName("LPCOLESTR")] char* pdbPath, [NativeTypeName("const GUID *")] Guid* pcsig70, [NativeTypeName("DWORD")] uint sig, [NativeTypeName("DWORD")] uint age, BOOL* pfStripped);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_lastError;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> loadDataFromPdb;

        [NativeTypeName("HRESULT (LPCOLESTR, GUID *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, uint, int> loadAndValidateDataFromPdb;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IUnknown*, int> loadDataForExe;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int> loadDataFromIStream;

        [NativeTypeName("HRESULT (IDiaSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSession**, int> openSession;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR, DWORD, BYTE *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, byte*, IUnknown*, int> loadDataFromCodeViewInfo;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR, DWORD, DWORD, DWORD, DWORD, BYTE *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, uint, uint, uint, byte*, IUnknown*, int> loadDataFromMiscInfo;

        [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL, int> loadDataFromPdbEx;

        [NativeTypeName("HRESULT (LPCOLESTR, GUID *, DWORD, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, uint, BOOL, int> loadAndValidateDataFromPdbEx;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR, IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IUnknown*, BOOL, int> loadDataForExeEx;

        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, BOOL, int> loadDataFromIStreamEx;

        [NativeTypeName("HRESULT (LPCOLESTR, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ulong*, int> getStreamSize;

        [NativeTypeName("HRESULT (LPCOLESTR, ULONGLONG, ULONGLONG, ULONGLONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ulong, ulong, ulong*, byte*, int> getStreamRawData;

        [NativeTypeName("HRESULT (void *, PFNMINIPDBERRORCALLBACK2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, delegate* unmanaged<void*, uint, char*, char*, HRESULT>, int> setPfnMiniPDBErrorCallback2;

        [NativeTypeName("HRESULT (LPCOLESTR, const GUID *, DWORD, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, uint, BOOL*, int> ValidatePdb;
    }
}
