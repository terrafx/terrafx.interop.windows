// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7699B465-1DCF-5791-B4B9-6CAFBEED2056")]
    [NativeTypeName("struct IInputActivationListenerActivationChangedEventArgs : IInspectable")]
    public unsafe partial struct IInputActivationListenerActivationChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, uint>)(lpVtbl[1]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, uint>)(lpVtbl[2]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("ABI::Windows::UI::Input::InputActivationState *")] InputActivationState* value)
        {
            return ((delegate* unmanaged<IInputActivationListenerActivationChangedEventArgs*, InputActivationState*, int>)(lpVtbl[6]))((IInputActivationListenerActivationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
