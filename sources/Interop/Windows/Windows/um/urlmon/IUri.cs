// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IUri.xml' path='doc/member[@name="IUri"]/*' />
[Guid("A39EE748-6A27-4817-A6F2-13914BEF5890")]
[NativeTypeName("struct IUri : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUri : IUri.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUri));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, Guid*, void**, int>)(lpVtbl[0]))((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint>)(lpVtbl[1]))((IUri*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint>)(lpVtbl[2]))((IUri*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPropertyBSTR"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] char** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, Uri_PROPERTY, char**, uint, int>)(lpVtbl[3]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPropertyLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[4]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPropertyDWORD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[5]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.HasProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HasProperty(Uri_PROPERTY uriProp, BOOL* pfHasProperty)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, Uri_PROPERTY, BOOL*, int>)(lpVtbl[6]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetAbsoluteUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAbsoluteUri([NativeTypeName("BSTR *")] char** pbstrAbsoluteUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[7]))((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetAuthority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAuthority([NativeTypeName("BSTR *")] char** pbstrAuthority)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[8]))((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetDisplayUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDisplayUri([NativeTypeName("BSTR *")] char** pbstrDisplayString)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[9]))((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetDomain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDomain([NativeTypeName("BSTR *")] char** pbstrDomain)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[10]))((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetExtension([NativeTypeName("BSTR *")] char** pbstrExtension)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[11]))((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFragment([NativeTypeName("BSTR *")] char** pbstrFragment)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[12]))((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetHost"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetHost([NativeTypeName("BSTR *")] char** pbstrHost)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[13]))((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPassword"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetPassword([NativeTypeName("BSTR *")] char** pbstrPassword)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[14]))((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPath([NativeTypeName("BSTR *")] char** pbstrPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[15]))((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPathAndQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPathAndQuery([NativeTypeName("BSTR *")] char** pbstrPathAndQuery)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[16]))((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetQuery([NativeTypeName("BSTR *")] char** pbstrQuery)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[17]))((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetRawUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetRawUri([NativeTypeName("BSTR *")] char** pbstrRawUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[18]))((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetSchemeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetSchemeName([NativeTypeName("BSTR *")] char** pbstrSchemeName)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[19]))((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetUserInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetUserInfo([NativeTypeName("BSTR *")] char** pbstrUserInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[20]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetUserName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUserName([NativeTypeName("BSTR *")] char** pbstrUserName)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, char**, int>)(lpVtbl[21]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetHostType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint*, int>)(lpVtbl[22]))((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint*, int>)(lpVtbl[23]))((IUri*)Unsafe.AsPointer(ref this), pdwPort);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetScheme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint*, int>)(lpVtbl[24]))((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint*, int>)(lpVtbl[25]))((IUri*)Unsafe.AsPointer(ref this), pdwZone);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.GetProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, uint*, int>)(lpVtbl[26]))((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    /// <include file='IUri.xml' path='doc/member[@name="IUri.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT IsEqual(IUri* pUri, BOOL* pfEqual)
    {
        return ((delegate* unmanaged[MemberFunction]<IUri*, IUri*, BOOL*, int>)(lpVtbl[27]))((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] char** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(5)]
        HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT HasProperty(Uri_PROPERTY uriProp, BOOL* pfHasProperty);

        [VtblIndex(7)]
        HRESULT GetAbsoluteUri([NativeTypeName("BSTR *")] char** pbstrAbsoluteUri);

        [VtblIndex(8)]
        HRESULT GetAuthority([NativeTypeName("BSTR *")] char** pbstrAuthority);

        [VtblIndex(9)]
        HRESULT GetDisplayUri([NativeTypeName("BSTR *")] char** pbstrDisplayString);

        [VtblIndex(10)]
        HRESULT GetDomain([NativeTypeName("BSTR *")] char** pbstrDomain);

        [VtblIndex(11)]
        HRESULT GetExtension([NativeTypeName("BSTR *")] char** pbstrExtension);

        [VtblIndex(12)]
        HRESULT GetFragment([NativeTypeName("BSTR *")] char** pbstrFragment);

        [VtblIndex(13)]
        HRESULT GetHost([NativeTypeName("BSTR *")] char** pbstrHost);

        [VtblIndex(14)]
        HRESULT GetPassword([NativeTypeName("BSTR *")] char** pbstrPassword);

        [VtblIndex(15)]
        HRESULT GetPath([NativeTypeName("BSTR *")] char** pbstrPath);

        [VtblIndex(16)]
        HRESULT GetPathAndQuery([NativeTypeName("BSTR *")] char** pbstrPathAndQuery);

        [VtblIndex(17)]
        HRESULT GetQuery([NativeTypeName("BSTR *")] char** pbstrQuery);

        [VtblIndex(18)]
        HRESULT GetRawUri([NativeTypeName("BSTR *")] char** pbstrRawUri);

        [VtblIndex(19)]
        HRESULT GetSchemeName([NativeTypeName("BSTR *")] char** pbstrSchemeName);

        [VtblIndex(20)]
        HRESULT GetUserInfo([NativeTypeName("BSTR *")] char** pbstrUserInfo);

        [VtblIndex(21)]
        HRESULT GetUserName([NativeTypeName("BSTR *")] char** pbstrUserName);

        [VtblIndex(22)]
        HRESULT GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType);

        [VtblIndex(23)]
        HRESULT GetPort([NativeTypeName("DWORD *")] uint* pdwPort);

        [VtblIndex(24)]
        HRESULT GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme);

        [VtblIndex(25)]
        HRESULT GetZone([NativeTypeName("DWORD *")] uint* pdwZone);

        [VtblIndex(26)]
        HRESULT GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags);

        [VtblIndex(27)]
        HRESULT IsEqual(IUri* pUri, BOOL* pfEqual);
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

        [NativeTypeName("HRESULT (Uri_PROPERTY, BSTR *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Uri_PROPERTY, char**, uint, int> GetPropertyBSTR;

        [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Uri_PROPERTY, uint*, uint, int> GetPropertyLength;

        [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Uri_PROPERTY, uint*, uint, int> GetPropertyDWORD;

        [NativeTypeName("HRESULT (Uri_PROPERTY, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Uri_PROPERTY, BOOL*, int> HasProperty;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAbsoluteUri;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAuthority;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDisplayUri;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDomain;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetExtension;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetFragment;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetHost;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPassword;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPathAndQuery;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetQuery;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetRawUri;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetSchemeName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetUserInfo;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetUserName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetHostType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetPort;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetScheme;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetZone;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetProperties;

        [NativeTypeName("HRESULT (IUri *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, BOOL*, int> IsEqual;
    }
}
