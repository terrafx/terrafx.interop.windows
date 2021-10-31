// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4652651D-C1FE-4BA1-9F0A-C0F56596F721")]
    [NativeTypeName("struct IProtectionPolicyManagerInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IProtectionPolicyManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RequestAccessForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HWND, HSTRING, HSTRING, Guid*, void**, int>)(lpVtbl[6]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, riid, asyncOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** result)
        {
            return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[7]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, result);
        }
    }
}
