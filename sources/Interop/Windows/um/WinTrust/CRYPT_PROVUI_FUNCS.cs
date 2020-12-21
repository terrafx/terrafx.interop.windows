// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVUI_FUNCS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("struct _CRYPT_PROVUI_DATA *")]
        public CRYPT_PROVUI_DATA* psUIData;

        [NativeTypeName("PFN_PROVUI_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClick;
#else
        public void* _pfnOnMoreInfoClick;

        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int>)_pfnOnMoreInfoClick;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnOnMoreInfoClick = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVUI_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClickDefault;
#else
        public void* _pfnOnMoreInfoClickDefault;

        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClickDefault
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int>)_pfnOnMoreInfoClickDefault;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnOnMoreInfoClickDefault = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVUI_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClick;
#else
        public void* _pfnOnAdvancedClick;

        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClick
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int>)_pfnOnAdvancedClick;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnOnAdvancedClick = value;
            }
        }
#endif

        [NativeTypeName("PFN_PROVUI_CALL")]
#if !NETSTANDARD2_0
        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClickDefault;
#else
        public void* _pfnOnAdvancedClickDefault;

        public delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClickDefault
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Cdecl]<IntPtr, CRYPT_PROVIDER_DATA*, int>)_pfnOnAdvancedClickDefault;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnOnAdvancedClickDefault = value;
            }
        }
#endif
    }
}
