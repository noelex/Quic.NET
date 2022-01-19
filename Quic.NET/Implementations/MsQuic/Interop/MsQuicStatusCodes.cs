// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Quic.Implementations.MsQuic.Internal
{
    internal static partial class MsQuicStatusCodes
    {
        internal static readonly uint Success = 0;
        internal static readonly uint Pending = unchecked((uint)-2);
        internal static readonly uint Continue = unchecked((uint)-1);
        internal static readonly uint OutOfMemory = 12;           // ENOMEM
        internal static readonly uint InvalidParameter = 22;      // EINVAL
        internal static readonly uint InvalidState = 1;           // EPERM
        internal static readonly uint NotSupported = 95;          // EOPNOTSUPP
        internal static readonly uint NotFound = 2;               // ENOENT
        internal static readonly uint BufferTooSmall = 75;        // EOVERFLOW
        internal static readonly uint HandshakeFailure = 103;     // ECONNABORTED
        internal static readonly uint Aborted = 125;              // ECANCELED
        internal static readonly uint AddressInUse = 98;          // EADDRINUSE
        internal static readonly uint ConnectionTimeout = 110;    // ETIMEDOUT
        internal static readonly uint ConnectionIdle = 62;        // ETIME
        internal static readonly uint HostUnreachable = 113;      // EHOSTUNREACH
        internal static readonly uint InternalError = 5;          // EIO
        internal static readonly uint ConnectionRefused = 111;    // ECONNREFUSED
        internal static readonly uint ProtocolError = 71;         // EPROTO
        internal static readonly uint VerNegError = 93;           // EPROTONOSUPPORT
        internal static readonly uint TlsError = 126;             // ENOKEY
        internal static readonly uint UserCanceled = 130;         // EOWNERDEAD
        internal static readonly uint AlpnNegotiationFailure = 92;// ENOPROTOOPT
        internal static readonly uint StreamLimit = 86;           // ESTRPIPE

        private static Dictionary<uint, string> _errorMessages;

        static MsQuicStatusCodes()
        {
            if (OperatingSystem.IsWindows())
            {
                Success = 0;
                Pending = 0x703E5;
                Continue = 0x704DE;
                OutOfMemory = 0x8007000E;
                InvalidParameter = 0x80070057;
                InvalidState = 0x8007139F;
                NotSupported = 0x80004002;
                NotFound = 0x80070490;
                BufferTooSmall = 0x8007007A;
                HandshakeFailure = 0x80410000;
                Aborted = 0x80004004;
                AddressInUse = 0x80072740;
                ConnectionTimeout = 0x80410006;
                ConnectionIdle = 0x80410005;
                HostUnreachable = 0x800704D0;
                InternalError = 0x80410003;
                ConnectionRefused = 0x800704C9;
                ProtocolError = 0x80410004;
                VerNegError = 0x80410001;
                TlsError = 0x80072B18;
                UserCanceled = 0x80410002;
                AlpnNegotiationFailure = 0x80410007;
                StreamLimit = 0x80410008;
            }
            else if (OperatingSystem.IsMacOS())
            {
                Success = 0;
                Pending = unchecked((uint)-2);
                Continue = unchecked((uint)-1);
                OutOfMemory = 12;           // ENOMEM
                InvalidParameter = 22;      // EINVAL
                InvalidState = 1;           // EPERM
                NotSupported = 102;         // EOPNOTSUPP
                NotFound = 2;               // ENOENT
                BufferTooSmall = 84;        // EOVERFLOW
                HandshakeFailure = 53;      // ECONNABORTED
                Aborted = 89;               // ECANCELED
                AddressInUse = 48;          // EADDRINUSE
                ConnectionTimeout = 60;     // ETIMEDOUT
                ConnectionIdle = 101;       // ETIME
                HostUnreachable = 65;       // EHOSTUNREACH
                InternalError = 5;          // EIO
                ConnectionRefused = 61;     // ECONNREFUSED
                ProtocolError = 100;        // EPROTO
                VerNegError = 43;           // EPROTONOSUPPORT
                TlsError = 126;             // ENOKEY Linux value
                UserCanceled = 105;         // EOWNERDEAD
                AlpnNegotiationFailure = 42;// ENOPROTOOPT
                StreamLimit = 86;           // ESTRPIPE Linux value
            }

            _errorMessages = new Dictionary<uint, string>
            {
                [Success] = "SUCCESS",
                [Pending] = "PENDING",
                [Continue] = "CONTINUE",
                [OutOfMemory] = "OUT_OF_MEMORY",
                [InvalidParameter] = "INVALID_PARAMETER",
                [InvalidState] = "INVALID_STATE",
                [NotSupported] = "NOT_SUPPORTED",
                [NotFound] = "NOT_FOUND",
                [BufferTooSmall] = "BUFFER_TOO_SMALL",
                [HandshakeFailure] = "HANDSHAKE_FAILURE",
                [Aborted] = "ABORTED",
                [AddressInUse] = "ADDRESS_IN_USE",
                [ConnectionTimeout] = "CONNECTION_TIMEOUT",
                [ConnectionIdle] = "CONNECTION_IDLE",
                [HostUnreachable] = "UNREACHABLE",
                [InternalError] = "INTERNAL_ERROR",
                [ConnectionRefused] = "CONNECTION_REFUSED",
                [ProtocolError] = "PROTOCOL_ERROR",
                [VerNegError] = "VER_NEG_ERROR",
                [TlsError] = "TLS_ERROR",
                [UserCanceled] = "USER_CANCELED",
                [AlpnNegotiationFailure] = "ALPN_NEG_FAILURE",
                [StreamLimit] = "STREAM_LIMIT_REACHED",
            };
        }

        // TODO return better error messages here.
        public static string GetError(uint status)
        {
            if(_errorMessages.TryGetValue(status, out var message))
            {
                return message;
            }

            return $"0x{status:X8}";
        }
    }
}
