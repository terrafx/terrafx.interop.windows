// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2"]/*' />
[Guid("E9707E05-6D55-4636-B185-3DE21210BD75")]
[NativeTypeName("struct IMFMediaKeySession2 : IMFMediaKeySession")]
[NativeInheritance("IMFMediaKeySession")]
public unsafe partial struct IMFMediaKeySession2 : IMFMediaKeySession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFMediaKeySession2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, uint>)(lpVtbl[1]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, uint>)(lpVtbl[2]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaKeySession.GetError" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetError(ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, ushort*, uint*, int>)(lpVtbl[3]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), code, systemCode);
    }

    /// <inheritdoc cref="IMFMediaKeySession.get_KeySystem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] char** keySystem)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, char**, int>)(lpVtbl[4]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), keySystem);
    }

    /// <inheritdoc cref="IMFMediaKeySession.get_SessionId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_SessionId([NativeTypeName("BSTR *")] char** sessionId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, char**, int>)(lpVtbl[5]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), sessionId);
    }

    /// <inheritdoc cref="IMFMediaKeySession.Update" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update([NativeTypeName("const BYTE *")] byte* key, [NativeTypeName("DWORD")] uint cb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, byte*, uint, int>)(lpVtbl[6]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), key, cb);
    }

    /// <inheritdoc cref="IMFMediaKeySession.Close" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, int>)(lpVtbl[7]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.get_KeyStatuses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, uint* puSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)(lpVtbl[8]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), pKeyStatusesArray, puSize);
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Load([NativeTypeName("BSTR")] char* bstrSessionId, BOOL* pfLoaded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, char*, BOOL*, int>)(lpVtbl[9]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), bstrSessionId, pfLoaded);
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.GenerateRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GenerateRequest([NativeTypeName("BSTR")] char* initDataType, [NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, char*, byte*, uint, int>)(lpVtbl[10]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), initDataType, pbInitData, cb);
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.get_Expiration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Expiration(double* dblExpiration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, double*, int>)(lpVtbl[11]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this), dblExpiration);
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, int>)(lpVtbl[12]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaKeySession2.xml' path='doc/member[@name="IMFMediaKeySession2.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaKeySession2*, int>)(lpVtbl[13]))((IMFMediaKeySession2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFMediaKeySession.Interface
    {
        [VtblIndex(8)]
        HRESULT get_KeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, uint* puSize);

        [VtblIndex(9)]
        HRESULT Load([NativeTypeName("BSTR")] char* bstrSessionId, BOOL* pfLoaded);

        [VtblIndex(10)]
        HRESULT GenerateRequest([NativeTypeName("BSTR")] char* initDataType, [NativeTypeName("const BYTE *")] byte* pbInitData, [NativeTypeName("DWORD")] uint cb);

        [VtblIndex(11)]
        HRESULT get_Expiration(double* dblExpiration);

        [VtblIndex(12)]
        HRESULT Remove();

        [VtblIndex(13)]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT (USHORT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, uint*, int> GetError;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_KeySystem;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_SessionId;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("HRESULT (MFMediaKeyStatus **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MFMediaKeyStatus**, uint*, int> get_KeyStatuses;

        [NativeTypeName("HRESULT (BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> Load;

        [NativeTypeName("HRESULT (BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint, int> GenerateRequest;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Expiration;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Shutdown;
    }
}
