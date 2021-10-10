// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD672C54-40EA-4D6E-9B49-CFB1A7507BD7")]
    [NativeTypeName("struct ICredentialProviderCredential2 : ICredentialProviderCredential")]
    [NativeInheritance("ICredentialProviderCredential")]
    public unsafe partial struct ICredentialProviderCredential2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint>)(lpVtbl[1]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint>)(lpVtbl[2]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(ICredentialProviderCredentialEvents* pcpce)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, ICredentialProviderCredentialEvents*, int>)(lpVtbl[3]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pcpce);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UnAdvise()
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, int>)(lpVtbl[4]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelected([NativeTypeName("BOOL *")] int* pbAutoLogon)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, int*, int>)(lpVtbl[5]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pbAutoLogon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeselected()
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, int>)(lpVtbl[6]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int>)(lpVtbl[7]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pcpfs, pcpfis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, ushort**, int>)(lpVtbl[8]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, ppsz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("HBITMAP *")] IntPtr* phbmp)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, IntPtr*, int>)(lpVtbl[9]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, phbmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("BOOL *")] int* pbChecked, [NativeTypeName("LPWSTR *")] ushort** ppszLabel)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, int*, ushort**, int>)(lpVtbl[10]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pbChecked, ppszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint*, int>)(lpVtbl[11]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pdwAdjacentTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint*, uint*, int>)(lpVtbl[12]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pcItems, pdwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] ushort** ppszItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint, ushort**, int>)(lpVtbl[13]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, dwItem, ppszItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, ushort*, int>)(lpVtbl[14]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("BOOL")] int bChecked)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, int, int>)(lpVtbl[15]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, bChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint, int>)(lpVtbl[16]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, dwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, int>)(lpVtbl[17]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[18]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, int, int, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[19]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserSid([NativeTypeName("LPWSTR *")] ushort** sid)
        {
            return ((delegate* unmanaged<ICredentialProviderCredential2*, ushort**, int>)(lpVtbl[20]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), sid);
        }
    }
}
