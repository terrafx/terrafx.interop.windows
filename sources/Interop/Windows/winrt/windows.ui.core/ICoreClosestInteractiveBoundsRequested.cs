// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F303043A-E8BF-4E8E-AE69-C9DADD57A114")]
    [NativeTypeName("struct ICoreClosestInteractiveBoundsRequested : IInspectable")]
    public unsafe partial struct ICoreClosestInteractiveBoundsRequested
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, Guid*, void**, int>)(lpVtbl[0]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, uint>)(lpVtbl[1]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, uint>)(lpVtbl[2]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, IntPtr*, int>)(lpVtbl[4]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, TrustLevel*, int>)(lpVtbl[5]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ClosestInteractiveBoundsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreComponentInputSource_Windows__CUI__CCore__CClosestInteractiveBoundsRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* pCookie)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), handler, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ClosestInteractiveBoundsRequested(EventRegistrationToken cookie)
        {
            return ((delegate* unmanaged<ICoreClosestInteractiveBoundsRequested*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreClosestInteractiveBoundsRequested*)Unsafe.AsPointer(ref this), cookie);
        }
    }
}
