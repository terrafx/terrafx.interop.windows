// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2"]/*' />
[Guid("4315D938-F369-4F93-95A2-252017CC3807")]
[NativeTypeName("struct IDxcPdbUtils2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcPdbUtils2 : IDxcPdbUtils2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcPdbUtils2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint>)(lpVtbl[1]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint>)(lpVtbl[2]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pPdbOrDxil)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pPdbOrDxil);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetSourceCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[4]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetSourceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobUtf16**, int>)(lpVtbl[6]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetLibraryPDBCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLibraryPDBCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[7]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetLibraryPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLibraryPDB([NativeTypeName("UINT32")] uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppLibraryName)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobUtf16**, int>)(lpVtbl[8]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppOutPdbUtils, ppLibraryName);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetFlagCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[9]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetFlag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobUtf16**, int>)(lpVtbl[10]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[11]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetArg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobUtf16**, int>)(lpVtbl[12]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetArgPairCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[13]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetArgPair"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppName, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)(lpVtbl[14]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppName, ppValue);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetDefineCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[15]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetDefine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint, IDxcBlobUtf16**, int>)(lpVtbl[16]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetTargetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTargetProfile([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlobUtf16**, int>)(lpVtbl[17]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetEntryPoint([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlobUtf16**, int>)(lpVtbl[18]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetMainFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMainFileName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlobUtf16**, int>)(lpVtbl[19]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetHash(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlob**, int>)(lpVtbl[20]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlobUtf16**, int>)(lpVtbl[21]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetVersionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcVersionInfo**, int>)(lpVtbl[22]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppVersionInfo);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetCustomToolchainID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetCustomToolchainID([NativeTypeName("UINT32 *")] uint* pID)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, uint*, int>)(lpVtbl[23]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), pID);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetCustomToolchainData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetCustomToolchainData(IDxcBlob** ppBlob)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlob**, int>)(lpVtbl[24]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppBlob);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.GetWholeDxil"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetWholeDxil(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, IDxcBlob**, int>)(lpVtbl[25]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.IsFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL IsFullPDB()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, int>)(lpVtbl[26]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils2.xml' path='doc/member[@name="IDxcPdbUtils2.IsPDBRef"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public BOOL IsPDBRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils2*, int>)(lpVtbl[27]))((IDxcPdbUtils2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(IDxcBlob* pPdbOrDxil);

        [VtblIndex(4)]
        HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(5)]
        HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult);

        [VtblIndex(6)]
        HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(7)]
        HRESULT GetLibraryPDBCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(8)]
        HRESULT GetLibraryPDB([NativeTypeName("UINT32")] uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppLibraryName);

        [VtblIndex(9)]
        HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(10)]
        HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(11)]
        HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(12)]
        HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(13)]
        HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(14)]
        HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppName, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppValue);

        [VtblIndex(15)]
        HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(16)]
        HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(17)]
        HRESULT GetTargetProfile([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(18)]
        HRESULT GetEntryPoint([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(19)]
        HRESULT GetMainFileName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(20)]
        HRESULT GetHash(IDxcBlob** ppResult);

        [VtblIndex(21)]
        HRESULT GetName([NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppResult);

        [VtblIndex(22)]
        HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo);

        [VtblIndex(23)]
        HRESULT GetCustomToolchainID([NativeTypeName("UINT32 *")] uint* pID);

        [VtblIndex(24)]
        HRESULT GetCustomToolchainData(IDxcBlob** ppBlob);

        [VtblIndex(25)]
        HRESULT GetWholeDxil(IDxcBlob** ppResult);

        [VtblIndex(26)]
        BOOL IsFullPDB();

        [VtblIndex(27)]
        BOOL IsPDBRef();
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

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlob*, int> Load;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSourceCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobEncoding**, int> GetSource;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobUtf16**, int> GetSourceName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetLibraryPDBCount;

        [NativeTypeName("HRESULT (UINT32, IDxcPdbUtils2 **, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcPdbUtils2**, IDxcBlobUtf16**, int> GetLibraryPDB;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetFlagCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobUtf16**, int> GetFlag;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetArgCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobUtf16**, int> GetArg;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetArgPairCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobUtf16**, IDxcBlobUtf16**, int> GetArgPair;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetDefineCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDxcBlobUtf16**, int> GetDefine;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlobUtf16**, int> GetTargetProfile;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlobUtf16**, int> GetEntryPoint;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlobUtf16**, int> GetMainFileName;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlob**, int> GetHash;

        [NativeTypeName("HRESULT (IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlobUtf16**, int> GetName;

        [NativeTypeName("HRESULT (IDxcVersionInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcVersionInfo**, int> GetVersionInfo;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCustomToolchainID;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlob**, int> GetCustomToolchainData;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDxcBlob**, int> GetWholeDxil;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsFullPDB;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsPDBRef;
    }
}
