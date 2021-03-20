// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9FFDF7F5-B8C9-4EF0-B7D2-1DE626561FC8")]
    [NativeTypeName("struct ICoreAcceleratorKeys : IInspectable")]
    public unsafe partial struct ICoreAcceleratorKeys
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, Guid*, void**, int>)(lpVtbl[0]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, uint>)(lpVtbl[1]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, uint>)(lpVtbl[2]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, IntPtr*, int>)(lpVtbl[4]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, TrustLevel*, int>)(lpVtbl[5]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_AcceleratorKeyActivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreDispatcher_Windows__CUI__CCore__CAcceleratorKeyEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_AcceleratorKeyActivated(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreAcceleratorKeys*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreAcceleratorKeys*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
