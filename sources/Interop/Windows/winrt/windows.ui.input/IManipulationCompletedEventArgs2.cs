// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0C0DCE7-30A9-5B96-886F-6560A85E4757")]
    [NativeTypeName("struct IManipulationCompletedEventArgs2 : IInspectable")]
    public unsafe partial struct IManipulationCompletedEventArgs2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, uint>)(lpVtbl[1]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, uint>)(lpVtbl[2]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, IntPtr*, int>)(lpVtbl[4]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, uint*, int>)(lpVtbl[6]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IManipulationCompletedEventArgs2*, uint*, int>)(lpVtbl[7]))((IManipulationCompletedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
