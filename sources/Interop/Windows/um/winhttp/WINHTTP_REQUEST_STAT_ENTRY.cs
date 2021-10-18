// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WINHTTP_REQUEST_STAT_ENTRY
    {
        WinHttpConnectFailureCount = 0,
        WinHttpProxyFailureCount,
        WinHttpTlsHandshakeClientLeg1Size,
        WinHttpTlsHandshakeServerLeg1Size,
        WinHttpTlsHandshakeClientLeg2Size,
        WinHttpTlsHandshakeServerLeg2Size,
        WinHttpRequestHeadersSize,
        WinHttpRequestHeadersCompressedSize,
        WinHttpResponseHeadersSize,
        WinHttpResponseHeadersCompressedSize,
        WinHttpResponseBodySize,
        WinHttpResponseBodyCompressedSize,
        WinHttpProxyTlsHandshakeClientLeg1Size,
        WinHttpProxyTlsHandshakeServerLeg1Size,
        WinHttpProxyTlsHandshakeClientLeg2Size,
        WinHttpProxyTlsHandshakeServerLeg2Size,
        WinHttpRequestStatLast,
        WinHttpRequestStatMax = 32,
    }
}
