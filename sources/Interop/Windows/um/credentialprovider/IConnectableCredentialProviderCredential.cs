// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9387928B-AC75-4BF9-8AB2-2B93C4A55290")]
    [NativeTypeName("struct IConnectableCredentialProviderCredential : ICredentialProviderCredential")]
    [NativeInheritance("ICredentialProviderCredential")]
    public unsafe partial struct IConnectableCredentialProviderCredential
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, Guid*, void**, int>)(lpVtbl[0]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint>)(lpVtbl[1]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint>)(lpVtbl[2]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(ICredentialProviderCredentialEvents* pcpce)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, ICredentialProviderCredentialEvents*, int>)(lpVtbl[3]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpce);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UnAdvise()
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int>)(lpVtbl[4]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelected([NativeTypeName("BOOL *")] int* pbAutoLogon)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int*, int>)(lpVtbl[5]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pbAutoLogon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeselected()
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int>)(lpVtbl[6]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int>)(lpVtbl[7]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcpfs, pcpfis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, ushort**, int>)(lpVtbl[8]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, ppsz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("HBITMAP *")] IntPtr* phbmp)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, IntPtr*, int>)(lpVtbl[9]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, phbmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("BOOL *")] int* pbChecked, [NativeTypeName("LPWSTR *")] ushort** ppszLabel)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, int*, ushort**, int>)(lpVtbl[10]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pbChecked, ppszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint*, int>)(lpVtbl[11]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pdwAdjacentTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint*, uint*, int>)(lpVtbl[12]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcItems, pdwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] ushort** ppszItem)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint, ushort**, int>)(lpVtbl[13]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwItem, ppszItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, ushort*, int>)(lpVtbl[14]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("BOOL")] int bChecked)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, int, int>)(lpVtbl[15]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, bChecked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint, int>)(lpVtbl[16]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, int>)(lpVtbl[17]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[18]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int, int, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int>)(lpVtbl[19]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IQueryContinueWithStatus* pqcws)
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, IQueryContinueWithStatus*, int>)(lpVtbl[20]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pqcws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int>)(lpVtbl[21]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
        }
    }
}
