// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("157CFBE4-A78D-4156-B384-61FDAC41E686")]
    [NativeTypeName("struct IProtectionPolicyManagerInterop2 : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IProtectionPolicyManagerInterop2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr*, int>)(lpVtbl[4]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RequestAccessForAppWithWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr, IntPtr, IntPtr, Guid*, void**, int>)(lpVtbl[6]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RequestAccessWithAuditingInfoForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr targetIdentity, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr, IntPtr, IntPtr, IUnknown*, Guid*, void**, int>)(lpVtbl[7]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, auditInfoUnk, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RequestAccessWithMessageForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr targetIdentity, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr, IntPtr, IntPtr, IUnknown*, IntPtr, Guid*, void**, int>)(lpVtbl[8]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, auditInfoUnk, messageFromApp, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RequestAccessForAppWithAuditingInfoForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr, IntPtr, IntPtr, IUnknown*, Guid*, void**, int>)(lpVtbl[9]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, auditInfoUnk, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RequestAccessForAppWithMessageForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, IntPtr, IntPtr, IntPtr, IUnknown*, IntPtr, Guid*, void**, int>)(lpVtbl[10]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, auditInfoUnk, messageFromApp, riid, asyncOperation);
        }
    }
}
