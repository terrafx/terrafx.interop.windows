// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FA6FA76B-66B7-4B11-95F1-86171118E816")]
    [NativeTypeName("struct ICredentialProviderCredentialEvents : IUnknown")]
    public unsafe partial struct ICredentialProviderCredentialEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, uint>)(lpVtbl[1]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, uint>)(lpVtbl[2]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE cpfs)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE, int>)(lpVtbl[3]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldInteractiveState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE, int>)(lpVtbl[4]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldString(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, ushort*, int>)(lpVtbl[5]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldCheckbox(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("BOOL")] int bChecked, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, int, ushort*, int>)(lpVtbl[6]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, bChecked, pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldBitmap(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("HBITMAP")] IntPtr hbmp)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, IntPtr, int>)(lpVtbl[7]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, hbmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldComboBoxSelectedItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[8]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwSelectedItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[9]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* pszItem)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, ushort*, int>)(lpVtbl[10]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, pszItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFieldSubmitButton(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwAdjacentTo)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, ICredentialProviderCredential*, uint, uint, int>)(lpVtbl[11]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwAdjacentTo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCreatingWindow([NativeTypeName("HWND *")] IntPtr* phwndOwner)
        {
            return ((delegate* unmanaged<ICredentialProviderCredentialEvents*, IntPtr*, int>)(lpVtbl[12]))((ICredentialProviderCredentialEvents*)Unsafe.AsPointer(ref this), phwndOwner);
        }
    }
}
