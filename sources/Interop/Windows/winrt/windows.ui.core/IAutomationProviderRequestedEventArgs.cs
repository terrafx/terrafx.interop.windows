// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("961FF258-21BF-4B42-A298-FA479D4C52E2")]
    [NativeTypeName("struct IAutomationProviderRequestedEventArgs : IInspectable")]
    public unsafe partial struct IAutomationProviderRequestedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, uint>)(lpVtbl[1]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, uint>)(lpVtbl[2]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AutomationProvider([NativeTypeName("IInspectable **")] IInspectable** value)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, IInspectable**, int>)(lpVtbl[6]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AutomationProvider([NativeTypeName("IInspectable *")] IInspectable* value)
        {
            return ((delegate* unmanaged<IAutomationProviderRequestedEventArgs*, IInspectable*, int>)(lpVtbl[7]))((IAutomationProviderRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
