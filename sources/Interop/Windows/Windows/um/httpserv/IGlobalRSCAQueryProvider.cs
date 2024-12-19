// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider"]/*' />
[Guid("63FDC43F-934A-4EE5-BCD8-7E7B50B75605")]
[NativeTypeName("struct IGlobalRSCAQueryProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalRSCAQueryProvider : IGlobalRSCAQueryProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalRSCAQueryProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpEventProvider.SetErrorStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, HRESULT, void>)(lpVtbl[0]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this), hrError);
    }

    /// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider.GetFunctionName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetFunctionName()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, char*>)(lpVtbl[1]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider.GetFunctionParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetFunctionParameters()
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, char*>)(lpVtbl[2]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider.GetOutputBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputBuffer([NativeTypeName("DWORD")] uint cbBuffer, byte** ppbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, uint, byte**, int>)(lpVtbl[3]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this), cbBuffer, ppbBuffer);
    }

    /// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider.ResizeOutputBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ResizeOutputBuffer([NativeTypeName("DWORD")] uint cbNewBuffer, [NativeTypeName("DWORD")] uint cbBytesToCopy, byte** ppbBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, uint, uint, byte**, int>)(lpVtbl[4]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this), cbNewBuffer, cbBytesToCopy, ppbBuffer);
    }

    /// <include file='IGlobalRSCAQueryProvider.xml' path='doc/member[@name="IGlobalRSCAQueryProvider.SetResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetResult([NativeTypeName("DWORD")] uint cbData, HRESULT hr)
    {
        ((delegate* unmanaged[MemberFunction]<IGlobalRSCAQueryProvider*, uint, HRESULT, void>)(lpVtbl[5]))((IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this), cbData, hr);
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetFunctionName();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        char* GetFunctionParameters();

        [VtblIndex(3)]
        HRESULT GetOutputBuffer([NativeTypeName("DWORD")] uint cbBuffer, byte** ppbBuffer);

        [VtblIndex(4)]
        HRESULT ResizeOutputBuffer([NativeTypeName("DWORD")] uint cbNewBuffer, [NativeTypeName("DWORD")] uint cbBytesToCopy, byte** ppbBuffer);

        [VtblIndex(5)]
        void SetResult([NativeTypeName("DWORD")] uint cbData, HRESULT hr);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetFunctionName;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetFunctionParameters;

        [NativeTypeName("HRESULT (DWORD, BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte**, int> GetOutputBuffer;

        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte**, int> ResizeOutputBuffer;

        [NativeTypeName("void (DWORD, HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HRESULT, void> SetResult;
    }
}
