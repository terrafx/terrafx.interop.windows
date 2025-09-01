// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential"]/*' />
[Guid("63913A93-40C1-481A-818D-4072FF8C70CC")]
[NativeTypeName("struct ICredentialProviderCredential : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderCredential : ICredentialProviderCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICredentialProviderCredential);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint>)(lpVtbl[1]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint>)(lpVtbl[2]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.Advise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ICredentialProviderCredentialEvents* pcpce)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, ICredentialProviderCredentialEvents*, int>)(lpVtbl[3]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpce);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.UnAdvise"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnAdvise()
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, int>)(lpVtbl[4]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.SetSelected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelected(BOOL* pbAutoLogon)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, BOOL*, int>)(lpVtbl[5]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), pbAutoLogon);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.SetDeselected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDeselected()
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, int>)(lpVtbl[6]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetFieldState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int>)(lpVtbl[7]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcpfs, pcpfis);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] char** ppsz)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, char**, int>)(lpVtbl[8]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, ppsz);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetBitmapValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, HBITMAP*, int>)(lpVtbl[9]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, phbmp);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetCheckboxValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL* pbChecked, [NativeTypeName("LPWSTR *")] char** ppszLabel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, BOOL*, char**, int>)(lpVtbl[10]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pbChecked, ppszLabel);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetSubmitButtonValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, uint*, int>)(lpVtbl[11]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pdwAdjacentTo);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetComboBoxValueCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, uint*, uint*, int>)(lpVtbl[12]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcItems, pdwSelectedItem);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetComboBoxValueAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] char** ppszItem)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, uint, char**, int>)(lpVtbl[13]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwItem, ppszItem);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.SetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] char* psz)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, char*, int>)(lpVtbl[14]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, psz);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.SetCheckboxValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, BOOL, int>)(lpVtbl[15]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, bChecked);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.SetComboBoxSelectedValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[16]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwSelectedItem);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.CommandLinkClicked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, uint, int>)(lpVtbl[17]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.GetSerialization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] char** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, char**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[18]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    /// <include file='ICredentialProviderCredential.xml' path='doc/member[@name="ICredentialProviderCredential.ReportResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] char** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged[MemberFunction]<ICredentialProviderCredential*, int, int, char**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[19]))((ICredentialProviderCredential*)Unsafe.AsPointer(ref this), ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(ICredentialProviderCredentialEvents* pcpce);

        [VtblIndex(4)]
        HRESULT UnAdvise();

        [VtblIndex(5)]
        HRESULT SetSelected(BOOL* pbAutoLogon);

        [VtblIndex(6)]
        HRESULT SetDeselected();

        [VtblIndex(7)]
        HRESULT GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis);

        [VtblIndex(8)]
        HRESULT GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] char** ppsz);

        [VtblIndex(9)]
        HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp);

        [VtblIndex(10)]
        HRESULT GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL* pbChecked, [NativeTypeName("LPWSTR *")] char** ppszLabel);

        [VtblIndex(11)]
        HRESULT GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo);

        [VtblIndex(12)]
        HRESULT GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem);

        [VtblIndex(13)]
        HRESULT GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] char** ppszItem);

        [VtblIndex(14)]
        HRESULT SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] char* psz);

        [VtblIndex(15)]
        HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked);

        [VtblIndex(16)]
        HRESULT SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem);

        [VtblIndex(17)]
        HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID);

        [VtblIndex(18)]
        HRESULT GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] char** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon);

        [VtblIndex(19)]
        HRESULT ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] char** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon);
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

        [NativeTypeName("HRESULT (ICredentialProviderCredentialEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICredentialProviderCredentialEvents*, int> Advise;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> UnAdvise;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> SetSelected;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetDeselected;

        [NativeTypeName("HRESULT (DWORD, CREDENTIAL_PROVIDER_FIELD_STATE *, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int> GetFieldState;

        [NativeTypeName("HRESULT (DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (DWORD, HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HBITMAP*, int> GetBitmapValue;

        [NativeTypeName("HRESULT (DWORD, BOOL *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, char**, int> GetCheckboxValue;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, int> GetSubmitButtonValue;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> GetComboBoxValueCount;

        [NativeTypeName("HRESULT (DWORD, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, char**, int> GetComboBoxValueAt;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetStringValue;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL, int> SetCheckboxValue;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetComboBoxSelectedValue;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> CommandLinkClicked;

        [NativeTypeName("HRESULT (CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE *, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, char**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> GetSerialization;

        [NativeTypeName("HRESULT (NTSTATUS, NTSTATUS, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, char**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> ReportResult;
    }
}
