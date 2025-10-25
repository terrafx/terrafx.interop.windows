// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM_EX"]/*' />
public partial struct HTTP_SERVICE_CONFIG_SSL_PARAM_EX
{
    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM_EX.ParamType"]/*' />
    public HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE ParamType;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM_EX.Flags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Flags;

    /// <include file='HTTP_SERVICE_CONFIG_SSL_PARAM_EX.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SSL_PARAM_EX.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_http_L2508_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Http2WindowSizeParam"]/*' />
    [UnscopedRef]
    public ref HTTP2_WINDOW_SIZE_PARAM Http2WindowSizeParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Http2WindowSizeParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Http2SettingsLimitsParam"]/*' />
    [UnscopedRef]
    public ref HTTP2_SETTINGS_LIMITS_PARAM Http2SettingsLimitsParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Http2SettingsLimitsParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpPerformanceParam"]/*' />
    [UnscopedRef]
    public ref HTTP_PERFORMANCE_PARAM HttpPerformanceParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HttpPerformanceParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpTlsRestrictionsParam"]/*' />
    [UnscopedRef]
    public ref HTTP_TLS_RESTRICTIONS_PARAM HttpTlsRestrictionsParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HttpTlsRestrictionsParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpErrorHeadersParam"]/*' />
    [UnscopedRef]
    public ref HTTP_ERROR_HEADERS_PARAM HttpErrorHeadersParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HttpErrorHeadersParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpTlsSessionTicketKeysParam"]/*' />
    [UnscopedRef]
    public ref HTTP_TLS_SESSION_TICKET_KEYS_PARAM HttpTlsSessionTicketKeysParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HttpTlsSessionTicketKeysParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpCertConfigParam"]/*' />
    [UnscopedRef]
    public ref HTTP_CERT_CONFIG_PARAM HttpCertConfigParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HttpCertConfigParam;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Http2WindowSizeParam"]/*' />
        [FieldOffset(0)]
        public HTTP2_WINDOW_SIZE_PARAM Http2WindowSizeParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Http2SettingsLimitsParam"]/*' />
        [FieldOffset(0)]
        public HTTP2_SETTINGS_LIMITS_PARAM Http2SettingsLimitsParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpPerformanceParam"]/*' />
        [FieldOffset(0)]
        public HTTP_PERFORMANCE_PARAM HttpPerformanceParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpTlsRestrictionsParam"]/*' />
        [FieldOffset(0)]
        public HTTP_TLS_RESTRICTIONS_PARAM HttpTlsRestrictionsParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpErrorHeadersParam"]/*' />
        [FieldOffset(0)]
        public HTTP_ERROR_HEADERS_PARAM HttpErrorHeadersParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpTlsSessionTicketKeysParam"]/*' />
        [FieldOffset(0)]
        public HTTP_TLS_SESSION_TICKET_KEYS_PARAM HttpTlsSessionTicketKeysParam;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HttpCertConfigParam"]/*' />
        [FieldOffset(0)]
        public HTTP_CERT_CONFIG_PARAM HttpCertConfigParam;
    }
}
