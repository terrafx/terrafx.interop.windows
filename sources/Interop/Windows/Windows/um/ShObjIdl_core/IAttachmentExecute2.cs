// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAttachmentExecute2.xml' path='doc/member[@name="IAttachmentExecute2"]/*' />
[Guid("4F2B781F-A608-4543-ABF0-49C246EBBBA9")]
[NativeTypeName("struct IAttachmentExecute2 : IAttachmentExecute")]
[NativeInheritance("IAttachmentExecute")]
public unsafe partial struct IAttachmentExecute2 : IAttachmentExecute2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAttachmentExecute2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, Guid*, void**, int>)(lpVtbl[0]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, uint>)(lpVtbl[1]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, uint>)(lpVtbl[2]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAttachmentExecute.SetClientTitle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetClientTitle([NativeTypeName("LPCWSTR")] char* pszTitle)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, char*, int>)(lpVtbl[3]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), pszTitle);
    }

    /// <inheritdoc cref="IAttachmentExecute.SetClientGuid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, Guid*, int>)(lpVtbl[4]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref="IAttachmentExecute.SetLocalPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLocalPath([NativeTypeName("LPCWSTR")] char* pszLocalPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, char*, int>)(lpVtbl[5]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), pszLocalPath);
    }

    /// <inheritdoc cref="IAttachmentExecute.SetFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] char* pszFileName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, char*, int>)(lpVtbl[6]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), pszFileName);
    }

    /// <inheritdoc cref="IAttachmentExecute.SetSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSource([NativeTypeName("LPCWSTR")] char* pszSource)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, char*, int>)(lpVtbl[7]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), pszSource);
    }

    /// <inheritdoc cref="IAttachmentExecute.SetReferrer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetReferrer([NativeTypeName("LPCWSTR")] char* pszReferrer)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, char*, int>)(lpVtbl[8]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), pszReferrer);
    }

    /// <inheritdoc cref="IAttachmentExecute.CheckPolicy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CheckPolicy()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, int>)(lpVtbl[9]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAttachmentExecute.Prompt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Prompt(HWND hwnd, ATTACHMENT_PROMPT prompt, ATTACHMENT_ACTION* paction)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION*, int>)(lpVtbl[10]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), hwnd, prompt, paction);
    }

    /// <inheritdoc cref="IAttachmentExecute.Save" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Save()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, int>)(lpVtbl[11]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IAttachmentExecute.Execute" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Execute(HWND hwnd, [NativeTypeName("LPCWSTR")] char* pszVerb, HANDLE* phProcess)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, HWND, char*, HANDLE*, int>)(lpVtbl[12]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), hwnd, pszVerb, phProcess);
    }

    /// <inheritdoc cref="IAttachmentExecute.SaveWithUI" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SaveWithUI(HWND hwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, HWND, int>)(lpVtbl[13]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <inheritdoc cref="IAttachmentExecute.ClearClientState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ClearClientState()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, int>)(lpVtbl[14]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAttachmentExecute2.xml' path='doc/member[@name="IAttachmentExecute2.SaveNoVirusCheck"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SaveNoVirusCheck()
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, int>)(lpVtbl[15]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAttachmentExecute2.xml' path='doc/member[@name="IAttachmentExecute2.SaveWithUINoVirusCheck"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SaveWithUINoVirusCheck(HWND hwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IAttachmentExecute2*, HWND, int>)(lpVtbl[16]))((IAttachmentExecute2*)Unsafe.AsPointer(ref this), hwnd);
    }

    public interface Interface : IAttachmentExecute.Interface
    {
        [VtblIndex(15)]
        HRESULT SaveNoVirusCheck();

        [VtblIndex(16)]
        HRESULT SaveWithUINoVirusCheck(HWND hwnd);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetClientTitle;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetClientGuid;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetLocalPath;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFileName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetSource;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetReferrer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CheckPolicy;

        [NativeTypeName("HRESULT (HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, ATTACHMENT_PROMPT, ATTACHMENT_ACTION*, int> Prompt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Save;

        [NativeTypeName("HRESULT (HWND, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, char*, HANDLE*, int> Execute;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int> SaveWithUI;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearClientState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SaveNoVirusCheck;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int> SaveWithUINoVirusCheck;
    }
}
