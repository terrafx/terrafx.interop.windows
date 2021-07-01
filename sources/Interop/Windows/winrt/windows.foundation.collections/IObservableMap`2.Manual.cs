// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("65DF2BF5-BF39-41B5-AEBC-5A9D865E472B")]
    public unsafe partial struct IObservableMap<K, V>
        where K : unmanaged
        where V : unmanaged
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, Guid*, void**, int>)(lpVtbl[0]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(lpVtbl[1]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, uint>)(lpVtbl[2]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, IntPtr*, int>)(lpVtbl[4]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, TrustLevel*, int>)(lpVtbl[5]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_MapChanged([NativeTypeName("MapChangedEventHandler<K_logical, V_logical> *")] MapChangedEventHandler<K, V>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, MapChangedEventHandler<K, V>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_MapChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IObservableMap<K, V>*, EventRegistrationToken, int>)(lpVtbl[7]))((IObservableMap<K, V>*)Unsafe.AsPointer(ref this), token);
        }
    }
}
