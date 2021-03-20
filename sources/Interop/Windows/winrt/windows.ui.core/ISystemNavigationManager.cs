// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93023118-CF50-42A6-9706-69107FA122E1")]
    [NativeTypeName("struct ISystemNavigationManager : IInspectable")]
    public unsafe partial struct ISystemNavigationManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, Guid*, void**, int>)(lpVtbl[0]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, uint>)(lpVtbl[1]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, uint>)(lpVtbl[2]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, IntPtr*, int>)(lpVtbl[4]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, TrustLevel*, int>)(lpVtbl[5]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_BackRequested([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CUI__CCore__CBackRequestedEventArgs_t *")] IEventHandler<IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_BackRequested(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<ISystemNavigationManager*, EventRegistrationToken, int>)(lpVtbl[7]))((ISystemNavigationManager*)Unsafe.AsPointer(ref this), token);
        }
    }
}
