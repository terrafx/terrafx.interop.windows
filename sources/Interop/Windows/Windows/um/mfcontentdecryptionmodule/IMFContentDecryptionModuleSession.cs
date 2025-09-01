// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession"]/*' />
[Guid("4E233EFD-1DD2-49E8-B577-D63EEE4C0D33")]
[NativeTypeName("struct IMFContentDecryptionModuleSession : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleSession : IMFContentDecryptionModuleSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFContentDecryptionModuleSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.GetSessionId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSessionId([NativeTypeName("LPWSTR *")] char** sessionId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, char**, int>)(lpVtbl[3]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.GetExpiration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetExpiration(double* expiration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, double*, int>)(lpVtbl[4]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), expiration);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.GetKeyStatuses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetKeyStatuses(MFMediaKeyStatus** keyStatuses, uint* numKeyStatuses)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, MFMediaKeyStatus**, uint*, int>)(lpVtbl[5]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), keyStatuses, numKeyStatuses);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Load([NativeTypeName("LPCWSTR")] char* sessionId, BOOL* loaded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, char*, BOOL*, int>)(lpVtbl[6]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), sessionId, loaded);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.GenerateRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GenerateRequest([NativeTypeName("LPCWSTR")] char* initDataType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint initDataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, char*, byte*, uint, int>)(lpVtbl[7]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), initDataType, initData, initDataSize);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Update([NativeTypeName("const BYTE *")] byte* response, [NativeTypeName("DWORD")] uint responseSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, byte*, uint, int>)(lpVtbl[8]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this), response, responseSize);
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, int>)(lpVtbl[9]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptionModuleSession.xml' path='doc/member[@name="IMFContentDecryptionModuleSession.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFContentDecryptionModuleSession*, int>)(lpVtbl[10]))((IMFContentDecryptionModuleSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSessionId([NativeTypeName("LPWSTR *")] char** sessionId);

        [VtblIndex(4)]
        HRESULT GetExpiration(double* expiration);

        [VtblIndex(5)]
        HRESULT GetKeyStatuses(MFMediaKeyStatus** keyStatuses, uint* numKeyStatuses);

        [VtblIndex(6)]
        HRESULT Load([NativeTypeName("LPCWSTR")] char* sessionId, BOOL* loaded);

        [VtblIndex(7)]
        HRESULT GenerateRequest([NativeTypeName("LPCWSTR")] char* initDataType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint initDataSize);

        [VtblIndex(8)]
        HRESULT Update([NativeTypeName("const BYTE *")] byte* response, [NativeTypeName("DWORD")] uint responseSize);

        [VtblIndex(9)]
        HRESULT Close();

        [VtblIndex(10)]
        HRESULT Remove();
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetSessionId;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetExpiration;

        [NativeTypeName("HRESULT (MFMediaKeyStatus **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MFMediaKeyStatus**, uint*, int> GetKeyStatuses;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> Load;

        [NativeTypeName("HRESULT (LPCWSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint, int> GenerateRequest;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Remove;
    }
}
