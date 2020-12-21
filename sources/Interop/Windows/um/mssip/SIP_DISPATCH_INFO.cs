// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIP_DISPATCH_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HANDLE")]
        public IntPtr hSIP;

        [NativeTypeName("pCryptSIPGetSignedDataMsg")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, int> pfGet;
#else
        public void* _pfGet;

        public delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, int> pfGet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint*, uint, uint*, byte*, int>)_pfGet;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfGet = value;
            }
        }
#endif

        [NativeTypeName("pCryptSIPPutSignedDataMsg")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, int> pfPut;
#else
        public void* _pfPut;

        public delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, int> pfPut
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint, uint*, uint, byte*, int>)_pfPut;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfPut = value;
            }
        }
#endif

        [NativeTypeName("pCryptSIPCreateIndirectData")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, int> pfCreate;
#else
        public void* _pfCreate;

        public delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, int> pfCreate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint*, SIP_INDIRECT_DATA*, int>)_pfCreate;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfCreate = value;
            }
        }
#endif

        [NativeTypeName("pCryptSIPVerifyIndirectData")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, int> pfVerify;
#else
        public void* _pfVerify;

        public delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, int> pfVerify
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, SIP_INDIRECT_DATA*, int>)_pfVerify;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfVerify = value;
            }
        }
#endif

        [NativeTypeName("pCryptSIPRemoveSignedDataMsg")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<SIP_SUBJECTINFO*, uint, int> pfRemove;
#else
        public void* _pfRemove;

        public delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint, int> pfRemove
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<SIP_SUBJECTINFO*, uint, int>)_pfRemove;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfRemove = value;
            }
        }
#endif
    }
}
