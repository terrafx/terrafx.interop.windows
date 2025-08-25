// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder"]/*' />
[Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
[NativeTypeName("struct IUriBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUriBuilder : IUriBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUriBuilder);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint>)(lpVtbl[1]))((IUriBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint>)(lpVtbl[2]))((IUriBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUriSimple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint, nuint, IUri**, int>)(lpVtbl[3]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint, uint, nuint, IUri**, int>)(lpVtbl[4]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.CreateUriWithFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint, uint, uint, nuint, IUri**, int>)(lpVtbl[5]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetIUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIUri(IUri** ppIUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, IUri**, int>)(lpVtbl[6]))((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetIUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIUri(IUri* pIUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, IUri*, int>)(lpVtbl[7]))((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] char** ppwzFragment)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[8]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] char** ppwzHost)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[9]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] char** ppwzPassword)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[10]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] char** ppwzPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[11]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPort(BOOL* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, BOOL*, uint*, int>)(lpVtbl[12]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] char** ppwzQuery)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[13]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetSchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] char** ppwzSchemeName)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[14]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.GetUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] char** ppwzUserName)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint*, char**, int>)(lpVtbl[15]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetFragment([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[16]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetHost([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[17]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetPassword([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[18]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetPath([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[19]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetPort(BOOL fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, BOOL, uint, int>)(lpVtbl[20]))((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetQuery([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[21]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetSchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetSchemeName([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[22]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.SetUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetUserName([NativeTypeName("LPCWSTR")] char* pwzNewValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, char*, int>)(lpVtbl[23]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.RemoveProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, uint, int>)(lpVtbl[24]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
    }

    /// <include file='IUriBuilder.xml' path='doc/member[@name="IUriBuilder.HasBeenModified"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT HasBeenModified(BOOL* pfModified)
    {
        return ((delegate* unmanaged[MemberFunction]<IUriBuilder*, BOOL*, int>)(lpVtbl[25]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(4)]
        HRESULT CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(5)]
        HRESULT CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri);

        [VtblIndex(6)]
        HRESULT GetIUri(IUri** ppIUri);

        [VtblIndex(7)]
        HRESULT SetIUri(IUri* pIUri);

        [VtblIndex(8)]
        HRESULT GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] char** ppwzFragment);

        [VtblIndex(9)]
        HRESULT GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] char** ppwzHost);

        [VtblIndex(10)]
        HRESULT GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] char** ppwzPassword);

        [VtblIndex(11)]
        HRESULT GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] char** ppwzPath);

        [VtblIndex(12)]
        HRESULT GetPort(BOOL* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort);

        [VtblIndex(13)]
        HRESULT GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] char** ppwzQuery);

        [VtblIndex(14)]
        HRESULT GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] char** ppwzSchemeName);

        [VtblIndex(15)]
        HRESULT GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] char** ppwzUserName);

        [VtblIndex(16)]
        HRESULT SetFragment([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(17)]
        HRESULT SetHost([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(18)]
        HRESULT SetPassword([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(19)]
        HRESULT SetPath([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(20)]
        HRESULT SetPort(BOOL fHasPort, [NativeTypeName("DWORD")] uint dwNewValue);

        [VtblIndex(21)]
        HRESULT SetQuery([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(22)]
        HRESULT SetSchemeName([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(23)]
        HRESULT SetUserName([NativeTypeName("LPCWSTR")] char* pwzNewValue);

        [VtblIndex(24)]
        HRESULT RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask);

        [VtblIndex(25)]
        HRESULT HasBeenModified(BOOL* pfModified);
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

        [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, nuint, IUri**, int> CreateUriSimple;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, nuint, IUri**, int> CreateUri;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, nuint, IUri**, int> CreateUriWithFlags;

        [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUri**, int> GetIUri;

        [NativeTypeName("HRESULT (IUri *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, int> SetIUri;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetFragment;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetHost;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetPassword;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetPath;

        [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, uint*, int> GetPort;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetQuery;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetSchemeName;

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetUserName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFragment;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetHost;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetPassword;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetPath;

        [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, uint, int> SetPort;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetQuery;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetSchemeName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetUserName;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> RemoveProperties;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> HasBeenModified;
    }
}
