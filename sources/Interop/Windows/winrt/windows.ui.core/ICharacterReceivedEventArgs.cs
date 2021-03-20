// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C584659F-99B2-4BCC-BD33-04E63F42902E")]
    [NativeTypeName("struct ICharacterReceivedEventArgs : IInspectable")]
    public unsafe partial struct ICharacterReceivedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, uint>)(lpVtbl[1]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, uint>)(lpVtbl[2]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyCode([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, uint*, int>)(lpVtbl[6]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value)
        {
            return ((delegate* unmanaged<ICharacterReceivedEventArgs*, CorePhysicalKeyStatus*, int>)(lpVtbl[7]))((ICharacterReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
