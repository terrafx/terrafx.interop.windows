// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1C03933-B398-4D93-B0FD-2972ADF802C2")]
    [NativeTypeName("struct IProtectionPolicyManagerInterop3 : IInspectable")]
    public unsafe partial struct IProtectionPolicyManagerInterop3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr*, int>)(lpVtbl[4]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessWithBehaviorForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr targetIdentity, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("UINT32")] uint behavior, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IntPtr, IntPtr, IUnknown*, IntPtr, uint, Guid*, void**, int>)(lpVtbl[6]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, auditInfoUnk, messageFromApp, behavior, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessForAppWithBehaviorForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, [NativeTypeName("HSTRING")] IntPtr sourceIdentity, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("UINT32")] uint behavior, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IntPtr, IntPtr, IUnknown*, IntPtr, uint, Guid*, void**, int>)(lpVtbl[7]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, auditInfoUnk, messageFromApp, behavior, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessToFilesForAppForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, IUnknown* sourceItemListUnk, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IUnknown*, IntPtr, IUnknown*, Guid*, void**, int>)(lpVtbl[8]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceItemListUnk, appPackageFamilyName, auditInfoUnk, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessToFilesForAppWithMessageAndBehaviorForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, IUnknown* sourceItemListUnk, [NativeTypeName("HSTRING")] IntPtr appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("UINT32")] uint behavior, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IUnknown*, IntPtr, IUnknown*, IntPtr, uint, Guid*, void**, int>)(lpVtbl[9]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceItemListUnk, appPackageFamilyName, auditInfoUnk, messageFromApp, behavior, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessToFilesForProcessForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, IUnknown* sourceItemListUnk, [NativeTypeName("UINT32")] uint processId, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IUnknown*, uint, IUnknown*, Guid*, void**, int>)(lpVtbl[10]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceItemListUnk, processId, auditInfoUnk, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessToFilesForProcessWithMessageAndBehaviorForWindowAsync([NativeTypeName("HWND")] IntPtr appWindow, IUnknown* sourceItemListUnk, [NativeTypeName("UINT32")] uint processId, IUnknown* auditInfoUnk, [NativeTypeName("HSTRING")] IntPtr messageFromApp, [NativeTypeName("UINT32")] uint behavior, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop3*, IntPtr, IUnknown*, uint, IUnknown*, IntPtr, uint, Guid*, void**, int>)(lpVtbl[11]))((IProtectionPolicyManagerInterop3*)Unsafe.AsPointer(ref this), appWindow, sourceItemListUnk, processId, auditInfoUnk, messageFromApp, behavior, riid, asyncOperation);
        }
    }
}
